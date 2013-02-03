<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="TransportSystem.register" %>

<!DOCTYPE html>
<html>
	<head>
		<title>Transport system - Login</title>
		<link type="text/css" rel="stylesheet" href="styles/main.css" />
		<script src="jscript/jquery-1.8.3.js"></script>
		<script src="jscript/utils.js"></script>
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
			    <section class="container big bordered">
					    <label for="name">Company name</label>
					    <asp:TextBox runat="server" class="input" ID="name" type="text" value="company name" name="company name" />
					    <br />
					    <label for="city" >City</label>
					    <asp:TextBox runat="server" class="input" ID="city" type="text" value="city" name="city" />
					    <br />
					    <label for="address">Address</label>
					    <asp:TextBox runat="server" class="input" ID="address" type="text" value="address" name="address" />
					    <br />
					    <label for="phone" >Phone number</label>
					    <asp:TextBox runat="server" class="input" ID="phone" type="tel" value="phone" name="phone"/>
					    <br />
					    <label for="email" >Email</label>
					    <asp:TextBox runat="server" class="input" ID="email"/>
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