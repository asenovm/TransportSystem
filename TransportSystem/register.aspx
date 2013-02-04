<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="TransportSystem.register" %>

<!DOCTYPE html>
<html>
	<head>
		<title>Transport system - Login</title>
		<link type="text/css" rel="stylesheet" href="styles/main.css" />
		<script src="jscript/jquery-1.8.3.js"></script>
	</head>
	<body>
        <form runat="server">
		    <header>
			    <h1>Transport Information System</h1>
			    <h2>Find the best way to travel</h2>
			    <article id="logout">
				    <asp:Button CssClass="logout" runat="server" Text="Logout" OnClick="Logout" />
			    </article>
			    <ul id="menu">
				    <li><a href="#" class="active">Register</a></li>
				    <li><a href="edit.aspx">Edit</a></li>
				    <li><a href="schedule.aspx">Schedule</a></li>
				    <li><a href="delete.aspx">Delete</a></li>
				    <li><a href="arriving.aspx">Arriving</a></li>
				    <li><a href="departing.aspx">Departing</a></li>
				    <li><a href="fastest.aspx">Fastest</a></li>
				    <li><a href="cheapest.aspx">Cheapest</a></li>
			    </ul>
		    </header>
		    <section class="centerText">
			    <article class="grey bold label">
				    You need to enter the following information in order to register a company
			    </article>
			    <section class="container bigger bordered">
					    <label for="name">Company name</label>
					    <asp:TextBox runat="server" class="input" ID="name"  />
                        <br />
                        <asp:CustomValidator runat="server" ControlToValidate="name" ErrorMessage="Company already exists. Pick another name."  OnServerValidate="ValidateCompanyName" Display="Dynamic" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="name" ErrorMessage="Company name cannot be blank" Display="Dynamic" />
					    <br />
					    <label for="city" >City</label>
					    <asp:TextBox runat="server" class="input" ID="city" />
                        <br />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="city" ErrorMessage="City cannot be blank" />
					    <br />
					    <label for="address">Address</label>
					    <asp:TextBox runat="server" class="input" ID="address" />
                        <br />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="address" ErrorMessage="Address cannot be blank" />
					    <br />
					    <label for="phone" >Phone number</label>
					    <asp:TextBox runat="server" class="input" ID="phone" />
                        <br />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="phone" ErrorMessage="Phone cannot be blank" Display="Dynamic" />
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="phone" ValidationExpression="\+?\d{4,}" ErrorMessage="Invalid Phone Number" Display="Dynamic"/>
					    <br />
					    <label for="email" >Email</label>
					    <asp:TextBox runat="server" class="input" ID="email"/>
                        <br />
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="email" ErrorMessage="invalid email" ValidationExpression="[a-zA-Z0-9_\-\.]+@[a-zA-Z]+\.[a-zA-Z]+" Display="Dynamic" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="email" ErrorMessage="Email cannot be blank" Display="Dynamic" />
                        <br />
                        <asp:Label runat="server" ID="registerLabel" />
					    <asp:Button runat="server" Text="Submit" id="submit" OnClick="registerButtonClicked" />
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