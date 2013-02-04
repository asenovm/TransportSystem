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
            if (!Page.IsValid) {
                return;
            }

            if (!Roles.RoleExists("admin")) {
                Roles.CreateRole("admin");
            }
            Membership.CreateUser(username.Text, password.Text, email.Text);
            Roles.AddUserToRole(username.Text, "admin");
            registerLabel.Text = "User successfully registered";
            ClearFields();
        }

        private void ClearFields() {
            username.Text = "";
            password.Text = "";
            repeatPassword.Text = "";
            email.Text = "";
        }

        protected void ValidateUsername(object sender, ServerValidateEventArgs args) {
            args.IsValid = Membership.GetUser(username.Text) == null;
        }
    }
}