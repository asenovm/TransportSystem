using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace TransportSystem
{
    public partial class login : System.Web.UI.Page
    {

        protected void OnLoginButtonClicked(object sender, EventArgs e)
        { 
            if(Membership.ValidateUser(username.Text,password.Text)){
                FormsAuthentication.RedirectFromLoginPage(username.Text, false);
            }
        }
        
    }
}