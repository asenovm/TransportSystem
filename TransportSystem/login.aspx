<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TransportSystem.login" %>

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
					<asp:TextBox ID="username" runat="server" Text="username" CssClass="input"/>
                    <br />
                    <asp:RequiredFieldValidator ID="usernameValidator" runat="server" ControlToValidate="username" ErrorMessage="Username cannot be blank" />
					<br />
					<label for="password">Password</label>
					<asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="input"/>
					<asp:Button Text="Submit" id="submit" runat="server" OnClick="OnLoginButtonClicked" />
					<br />
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