<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="TransportSystem.edit" %>

<!DOCTYPE html>
<html>
	<head>
		<title>Transport system - Login</title>
		<link type="text/css" rel="stylesheet" href="styles/main.css" />
		<script type="text/javascript" src="jscript/jquery-1.8.3.js"></script>
	</head>
	<body>
        <form runat="server">
		    <header>
			    <h1>Transport Information System</h1>
			    <h2>Find the best way to travel</h2>
			    <ul id="menu">
				    <li><a href="register.aspx">Register</a></li>
				    <li><a href="#" class="active">Edit</a></li>
				    <li><a href="schedule.aspx">Schedule</a></li>
				    <li><a href="delete.aspx">Delete</a></li>
				    <li><a href="arriving.aspx">Arriving</a></li>
				    <li><a href="departing.aspx">Departing</a></li>
				    <li><a href="fastest.aspx">Fastest</a></li>
				    <li><a href="cheapest.aspx">Cheapest</a></li>
			    </ul>
			    <article id="logout">
				    <asp:Button CssClass="logout" runat="server" Text="Logout" OnClick="Logout" />
			    </article>
		    </header>
		    <section class="centerText">
			    <article class="grey bold label">
				    Below you can edit the data about the selected company
			    </article>
			    <section class="container big bordered">
				    <article class="pick">
					    Please, select the company that you'd like to edit
				    </article>
				    <br />
				    <asp:DropDownList ID="companiesList" runat="server" />
				    <article class="pick">
					    Please, select the company attribute that you'd like to edit.
				    </article>
				    <br />
				    <asp:DropDownList runat="server" ID="attributesList">
					    <asp:ListItem value="City">City</asp:ListItem>
					    <asp:ListItem value="Address">Address</asp:ListItem>
					    <asp:ListItem value="Phone">Phone</asp:ListItem>
					    <asp:ListItem value="Email">Email</asp:ListItem>
				    </asp:DropDownList>
                    <br />
				    <label for="value">New Value</label>
				    <asp:TextBox class="input" runat="server" ID="newValue" />
                    <br />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="newValue" ErrorMessage="Field cannot be blank" Display="Dynamic" />
                    <asp:CustomValidator runat="server" ControlToValidate="newValue" ErrorMessage="Invalid value for attribute" OnServerValidate="ValidateEditedValue" Display="Dynamic" />
                    <br />
                    <asp:Label runat="server" CssClass="successLabel" ID="editLabel" />
                    <br />
				    <asp:Button runat="server" Text="Submit" id="submit" OnClick="editButtonClicked"/>
			    </section>
		    </section>
		    <footer class="grey">
			    <hr />
			    <br />
			    Transport information system <br />
			    WWW Technologies, FMI
		    </footer>
        </form>
	</body>
</html>