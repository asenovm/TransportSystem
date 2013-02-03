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
    public partial class delete : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            DBRetriever retriever = new DBRetriever();
            companiesList = (DropDownList)Page.FindControl("companiesList");
            companiesList.DataSource = retriever.GetCompanyNames();
            companiesList.DataBind();
        }

        protected void deleteButtonClicked(object sender, EventArgs e) {
            DBSaver saver = new DBSaver();
            saver.DeleteCompany(companiesList.SelectedValue);
            Response.Redirect(Request.RawUrl);
        }

        protected void Logout(object sender, EventArgs e) {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}