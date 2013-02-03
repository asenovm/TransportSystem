using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportSystem;
using DataLayer;
using System.Web.Security;

namespace TransportSystem
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBRetriever retriever = new DBRetriever();
            companiesList.DataSource = retriever.GetCompanyNames();
            companiesList.DataBind();
        }

        protected void editButtonClicked(object sender, EventArgs e) {
            DBSaver saver = new DBSaver();
            saver.EditCompany(companiesList.SelectedValue, attributesList.SelectedValue, newValue.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void Logout(object sender, EventArgs e){
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}