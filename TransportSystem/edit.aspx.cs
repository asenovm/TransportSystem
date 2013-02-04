using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportSystem;
using DataLayer;
using System.Web.Security;
using System.Text.RegularExpressions;

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
            if (Page.IsValid)
            {
                DBSaver saver = new DBSaver();
                saver.EditCompany(companiesList.SelectedValue, attributesList.SelectedValue, newValue.Text);
                editLabel.Text = "Attribute successfully edited";
                editLabel.CssClass = "successLabel";
            }
            else {
                editLabel.Text = "";
            }
            newValue.Text = "";
        }

        protected void Logout(object sender, EventArgs e){
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        protected void ValidateEditedValue(object sender, ServerValidateEventArgs args) {
            switch (attributesList.SelectedValue) { 
                case "City":
                    args.IsValid = Regex.IsMatch(newValue.Text,"\\w+");
                    break;
                case "Address":
                    args.IsValid = Regex.IsMatch(newValue.Text,"\\w+");
                    break;
                case "Email":
                    args.IsValid = Regex.IsMatch(newValue.Text, "[a-zA-Z0-9_\\-\\.]+@[a-zA-Z0-9_\\-\\.]+\\.[a-zA-Z]+");
                    break;
                case "Phone":
                    args.IsValid = Regex.IsMatch(newValue.Text, "\\+?\\d{4,}");
                    break;
            }
        }
    }
}