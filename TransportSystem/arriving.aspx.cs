using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using System.Web.Security;
using System.Text.RegularExpressions;

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
            if (Page.IsValid)
            {
                results.DataSource = retriever.GetMatchingTravels(retriever.GetAllTravels(), filterValues.SelectedValue, filterValue.Text);
                results.DataBind();
            }
        }

        protected void Logout(object sender, EventArgs e) {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        protected bool IsUserLogged() {
            return Membership.GetUser() != null;
        }

        protected void ValidateFilter(object sender, ServerValidateEventArgs args) {
            switch (filterValues.SelectedValue) { 
                case "start":
                    args.IsValid = ValidationUtil.IsValidCity(filterValue.Text);
                    break;
                case "end":
                    args.IsValid = ValidationUtil.IsValidCity(filterValue.Text);
                    break;
                case "company":
                    args.IsValid = ValidationUtil.IsValidName(filterValue.Text);
                    break;
                case "startTime":
                    args.IsValid = ValidationUtil.IsValidTime(filterValue.Text);
                    break;
                case "endTime":
                    args.IsValid = ValidationUtil.IsValidTime(filterValue.Text);
                    break;
            }
        }

        protected void OnGridViewPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            results.PageIndex = e.NewPageIndex;
            results.DataBind();
        }


    }
}