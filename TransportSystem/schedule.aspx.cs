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
            if (!Regex.IsMatch(textBox.Text, "\\d+/\\d+/\\d+ \\d+:\\d+:\\d+"))
            {
                args.IsValid = false;
            }
            else {
                string[] time = textBox.Text.Split(' ');
                string[] date = time[0].Split('/');
                string[] hours = time[1].Split(':');
                int month = int.Parse(date[0]);
                int day = int.Parse(date[1]);
                int year = int.Parse(date[2]);

                int hour = int.Parse(hours[0]);
                int minute = int.Parse(hours[1]);
                int seconds = int.Parse(hours[2]);

                args.IsValid = month < 12 && month > 0 &&  day > 1 && day < 31 &&  hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && seconds >= 0 && seconds < 60;
            }
        }
        
    }
}