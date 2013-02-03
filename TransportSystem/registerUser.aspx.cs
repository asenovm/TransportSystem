using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace TransportSystem
{
    public partial class RegisterUser : System.Web.UI.Page
    {

        protected void OnRegisterButtonClicked(object sender, EventArgs e) {
            if (!Roles.RoleExists("admin")) {
                Roles.CreateRole("admin");
            }
            Membership.CreateUser(username.Text, password.Text, email.Text);
            Roles.AddUserToRole(username.Text, "admin");
            Response.Redirect(Request.RawUrl);
        }
    }
}