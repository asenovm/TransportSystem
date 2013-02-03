<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="TransportSystem.delete" %>

<!DOCTYPE html>
<html>
	<head>
		<title>Delete company</title>
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
				    <li><a href="edit.aspx">Edit</a></li>
				    <li><a href="schedule.aspx">Schedule</a></li>
				    <li><a href="#" class="active">Delete</a></li>
				    <li><a href="arriving.aspx">Arriving</a></li>
				    <li><a href="departing.aspx">Departing</a></li>
				    <li><a href="fastest.aspx">Fastest</a></li>
				    <li><a href="cheapest.aspx">Cheapest</a></li>
			    </ul>
			    <article id="logout">
				    <asp:Button ID="Button1" CssClass="logout" runat="server" Text="Logout" OnClick="Logout" />
			    </article>
		    </header>
		    <section class="centerText">
			    <article class="grey bold label">
				    Pick a company to be deleted
			    </article>
			    <section class="container small bordered">
				    <article class="pick">
					    Please, select the company which you'd like to delete.
				    </article>
				    <br />
				    <section>
					    <asp:DropDownList runat="server" ID="companiesList"/>
					    <asp:Button id="submit" runat="server" Text="Delete" OnClick="deleteButtonClicked" />
				    </section>
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