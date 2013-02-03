<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="schedule.aspx.cs" Inherits="TransportSystem.schedule" %>

<!DOCTYPE html>
<html>
	<head>
		<title>Transport system - Login</title>
		<link type="text/css" rel="stylesheet" href="styles/main.css" />
        <script type="text/javascript" src="jscript/utils.js"></script>
		<script type="text/javascript" src="jscript/jquery-1.8.3.js"></script>
	</head>
	<body>
        <form runat="server">
        <asp:ScriptManager EnablePageMethods="true" runat="server" />
		    <header>
			    <h1>Transport Information System</h1>
			    <h2>Find the best way to travel</h2>
			    <ul id="menu">
				    <li><a href="register.aspx" >Register</a></li>
				    <li><a href="edit.aspx" >Edit</a></li>
				    <li><a href="#" class="active">Schedule</a></li>
				    <li><a href="delete.aspx" >Delete</a></li>
				    <li><a href="arriving.aspx" >Arriving</a></li>
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
				    You need to provide the following information in order to add a new line to the schedule
			    </article>
			    <section class="container bigger bordered">
				    <label for="company">Company name</label>
				    <asp:DropDownList runat="server" ID="companiesList" class="input" />
				    <br />
				    <label for="start">Start City</label>
				    <asp:TextBox runat="server" class="input" type="text" name="Start City" value="Start City" ID="startCity" />
				    <br />
				    <label for="startTime">Start Time</label>
				    <asp:TextBox runat="server" class="input" type="text" name="Start Time" value="Start Time" ID="startTime" />
				    <br />
				    <label for="intermediary">Intermediary Stop</label>
				    <asp:TextBox runat="server" class="input" type="text" name="Intermediary Stop" value="Intermediary Stop" ID="intermediaryStop" />
				    <button class="right" type="button">Add</button>
				    <br />
				    <label for="end">End City</label>
				    <asp:TextBox runat="server" class="input" type="text" name="End City" value="End City" ID="endCity" />
				    <br />
				    <label for="endTime">End Time</label>
				    <asp:TextBox runat="server" class="input" type="text" name="End Time" value="End Time" ID="endTime" />
				    <br />
				    <label for="price">Ticket Price</label>
				    <asp:TextBox runat="server" class="input" type="text" name="Ticket Price" value="Ticket Price" ID="ticketPrice" />
				    <asp:Button runat="server" type="submit" Text="Submit" id="submit" OnClick="scheduleButtonClicked" />
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