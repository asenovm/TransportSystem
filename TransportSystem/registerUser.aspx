<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerUser.aspx.cs" Inherits="TransportSystem.RegisterUser" %>

<!DOCTYPE html>
<html>
	<head>
		<title>Transport system - Login</title>
		<link type="text/css" rel="stylesheet" href="styles/main.css" />
		<script type="text/javascript" src="jscript/jquery-1.8.3.js"></script>
	</head>
	<body>
		<header>
			<h1>Transport Information System</h1>
			<h2>Find the best way to travel</h2>
		</header>
		<section class="centerText">
			<article class="grey bold label">
				In order to continue using the system as administrator, you need to first login.
			</article>
			<form runat="server" class="container bigger bordered">
					<label for="username">Username</label>
					<asp:TextBox ID="username" class="input" runat="server"/>
                    <br />
                    <asp:CustomValidator ControlToValidate="username" runat="server" OnServerValidate="ValidateUsername" ErrorMessage="Username already in use, pick another one" Display="Dynamic" />
                    <asp:RequiredFieldValidator ControlToValidate="username" runat="server" ErrorMessage="Username cannot be blank" Display="Dynamic" />
                    <br />
					<label for="password">Password</label>
					<asp:TextBox ID="password" TextMode="Password" CssClass="input" runat="server"/>
					<br />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="password" ErrorMessage="Password should be at least 6 chars." Display="Dynamic"/>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="password" ValidationExpression="\w{6,}" ErrorMessage="Password should be at least 6 chars." Display="Dynamic"/>
                    <br />
                    <label for="repeatPassword">Enter Password again</label>
                    <asp:TextBox ID="repeatPassword" TextMode="password" CssClass="input" runat="server" />
                    <br />
                    <asp:CompareValidator ControlToValidate="repeatPassword" ControlToCompare="password" runat="server" ErrorMessage="Passwords do not match." Display="Dynamic" />
                    <asp:RequiredFieldValidator ControlToValidate="repeatPassword" runat="server" ErrorMessage="Passwords do not match." Display="Dynamic" />
                    <br />
                    <label for="email">Email</label>
                    <asp:TextBox ID="email" CssClass="input" runat="server" />
                    <br />
                    <asp:RegularExpressionValidator ControlToValidate="email" runat="server" ValidationExpression="^[a-zA-Z0-9\-_\.]+@\w+\.\w+$" ErrorMessage="Invalid email address" Display="Dynamic"/>
                    <asp:RequiredFieldValidator ControlToValidate="email" runat="server" ErrorMessage="Email cannot be blank" Display="Dynamic"/>
                    <br />
                    <asp:Label runat="server" ID="registerLabel" CssClass="successLabel" />
                    <asp:Button id="submit" Text="Submit" runat="server" OnClick="OnRegisterButtonClicked" />
					<article class="light bottom">
                        Already have an account? <a href="login.aspx">Login</a>
                        <br />
						Not an administrator? <a href="arriving.aspx">Continue</a> as guest.
					</article>
			</form>
		</section>
		<footer class="grey">
			<hr />
			<br />
			Transport information system <br />
			WWW Technologies, FMI
		</footer>
	</body>
</html>