using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using System.Web.Security;
using System.Web.Services;
using System.Text.RegularExpressions;

namespace TransportSystem
{
    public partial class schedule : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DBRetriever retriever = new DBRetriever();
            companiesList.DataSource = retriever.GetCompanyNames();
            companiesList.DataBind();
        }

        protected void scheduleButtonClicked(object sender, EventArgs e) {
            if (Page.IsValid)
            {
                DBSaver saver = new DBSaver();
                saver.RegisterTravel(companiesList.SelectedValue, startCity.Text, DateTime.ParseExact(startTime.Text, "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture), intermediaryStop.Text, endCity.Text, DateTime.ParseExact(endTime.Text, "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture), Int32.Parse(ticketPrice.Text));
                scheduleLabel.Text = "Travel successfully scheduled";
                ClearFields();
            }
            else {
                scheduleLabel.Text = "";
            }
        }

        private void ClearFields() {
            startCity.Text = "";
            startTime.Text = "";
            endCity.Text = "";
            endTime.Text = "";
            intermediaryStop.Text = "";
            ticketPrice.Text = "";
        }

        protected void Logout(object sender, EventArgs e) {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        protected void ValidateStartTime(object sender, ServerValidateEventArgs args){
            ValidateTime(startTime, args);
        }

        protected void ValidateEndTime(object sender, ServerValidateEventArgs args) {
            ValidateTime(endTime, args);
        }

        private void ValidateTime(TextBox textBox, ServerValidateEventArgs args) {
            args.IsValid = ValidationUtil.IsValidTime(textBox.Text);
        }
        
    }
}