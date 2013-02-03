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
			<form runat="server" class="container big bordered">
					<label for="username">Username</label>
					<asp:TextBox ID="username" class="input" Text="username" runat="server"/>
					<br />
                    <asp:RequiredFieldValidator ControlToValidate="username" runat="server" ErrorMessage="Username cannot be blank" />
                    <br />
					<label for="password">Password</label>
					<asp:TextBox ID="password" TextMode="Password" CssClass="input" runat="server"/>
					<br />
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="password" ValidationExpression="\w{6,}" ErrorMessage="Password should be at least 6 chars."/>
                    <br />
                    <label for="repeatPassword">Enter Password again</label>
                    <asp:TextBox ID="repeatPassword" TextMode="password" CssClass="input" runat="server" />
                    <br />
                    <asp:CompareValidator ControlToValidate="repeatPassword" ControlToCompare="password" runat="server" ErrorMessage="Passwords do not match." />
                    <br />
                    <label for="email">Email</label>
                    <asp:TextBox ID="email" CssClass="input" runat="server" />
                    <br />
                    <asp:RegularExpressionValidator ControlToValidate="email" runat="server" ValidationExpression="^\w+@\w+\.\w+$" ErrorMessage="Invalid email address"/>
                    <asp:Button id="submit" Text="Submit" runat="server" OnClick="OnRegisterButtonClicked" />
					<article class="light bottom">
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