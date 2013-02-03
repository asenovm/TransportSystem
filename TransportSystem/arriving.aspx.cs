using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using System.Web.Security;

namespace TransportSystem
{
    public partial class arriving : System.Web.UI.Page
    {

        private DBRetriever retriever;

        protected void Page_Load(object sender, EventArgs e)
        {
            retriever = new DBRetriever();
            PopulateWithAllTravels();
        }

        protected void OnFilterButtonClicked(object sender, EventArgs e) {
            if (filterValue.Text.Length > 0)
            {
                Filter();
            }
            else
            {
                PopulateWithAllTravels();
            }
        }

        private void PopulateWithAllTravels() {
            results.DataSource = retriever.GetAllTravels();
            results.DataBind();
        }

        private void Filter() {
            results.DataSource = retriever.GetMatchingTravels(retriever.GetAllTravels(), filterValues.SelectedValue, filterValue.Text);
            results.DataBind();
        }

        protected void Logout(object sender, EventArgs e) {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        protected bool IsUserLogged() {
            return Membership.GetUser() != null;
        }
    }
}