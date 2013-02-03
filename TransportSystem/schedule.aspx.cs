using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using System.Web.Security;
using System.Web.Services;

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
            DBSaver saver = new DBSaver();
            saver.RegisterTravel(companiesList.SelectedValue, startCity.Text, DateTime.ParseExact(startTime.Text, "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture), intermediaryStop.Text, endCity.Text, DateTime.ParseExact(endTime.Text, "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture), Int32.Parse(ticketPrice.Text));
        }

        protected void Logout(object sender, EventArgs e) {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}