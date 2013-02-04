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
    public partial class cheapest : System.Web.UI.Page
    {
        private DBRetriever retriever;

        protected void Page_Load(object sender, EventArgs e)
        {
            retriever = new DBRetriever();
            PopulateWithAllCheapestTravels();
        }

        protected void OnEndPointButtonClicked(object sender, EventArgs e)
        {
            if (endPoint.Text.Length > 0)
            {
                Filter();
            }
            else
            {
                PopulateWithAllCheapestTravels();
            }
        }

        private void Filter()
        {
            if (Page.IsValid) {
                results.DataSource = retriever.GetMatchingTravels(retriever.GetCheapestTravels(), "end", endPoint.Text);
                results.DataBind();
            }
        }

        private void PopulateWithAllCheapestTravels()
        {
            results.DataSource = retriever.GetCheapestTravels();
            results.DataBind();
        }

        protected void Logout(object sender, EventArgs e) {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        protected bool IsUserLogged() {
            return Membership.GetUser() != null;
        }


        protected void OnGridViewPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            results.PageIndex = e.NewPageIndex;
            results.DataBind();
        }

    }
}