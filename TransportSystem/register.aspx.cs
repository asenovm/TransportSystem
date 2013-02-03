using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using TransportSystem;
using DataLayer;
using System.Web.Security;

namespace TransportSystem
{
    public partial class register : System.Web.UI.Page
    {

        protected void registerButtonClicked(object sender, EventArgs e)
        {
            DBSaver saver = new DBSaver();
            saver.RegisterCompany(name.Text, city.Text, address.Text, phone.Text, email.Text);
            Response.Redirect(Request.RawUrl);
        }


        protected void Logout(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}