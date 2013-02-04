<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="schedule.aspx.cs" Inherits="TransportSystem.schedule" %>

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
			    <section class="container biggest bordered">
				    <label for="company">Company name</label>
				    <asp:DropDownList runat="server" ID="companiesList" class="input" />
				    <br />
				    <label for="start">Start City</label>
				    <asp:TextBox runat="server" class="input" ID="startCity" />
                    <br />
                    <asp:RequiredFieldValidator ControlToValidate="startCity" runat="server" Display="Dynamic" ErrorMessage="Field cannot be blank" />
                    <asp:RegularExpressionValidator ControlToValidate="startCity" runat="server" Display="Dynamic" ValidationExpression="[a-zA-Z]{1,10}" ErrorMessage="Invalid start city" />
				    <br />
				    <label for="startTime">Start Time</label>
				    <asp:TextBox runat="server" class="input" ID="startTime" />
                    <br />
                    <asp:CustomValidator ControlToValidate="startTime" OnServerValidate="ValidateStartTime" runat="server" Display="Dynamic" ErrorMessage="Invalid time format. Format is MM/DD/YYYY HH:MM:SS" />
                    <asp:RequiredFieldValidator ControlToValidate="startTime" runat="server" ErrorMessage="Field cannot be blank." Display="Dynamic"/>
				    <br />
				    <label for="intermediary">Intermediary Stop</label>
				    <asp:TextBox runat="server" class="input" ID="intermediaryStop" />
                    <br />
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="intermediaryStop" ValidationExpression="[a-zA-Z]{1,10}" ErrorMessage="Invalid city" />
				    <br />
				    <label for="end">End City</label>
				    <asp:TextBox runat="server" class="input" ID="endCity" />
                    <br />
                    <asp:RequiredFieldValidator ControlToValidate="endCity" runat="server" Display="Dynamic" ErrorMessage="Field cannot be blank." />
                    <asp:RegularExpressionValidator ControlToValidate="endCity" runat="server" Display="Dynamic" ErrorMessage="Invalid end city" ValidationExpression="[a-zA-Z]{1,10}" />
				    <br />
				    <label for="endTime">End Time</label>
				    <asp:TextBox runat="server" class="input" ID="endTime" />
                    <br />
                    <asp:RequiredFieldValidator ControlToValidate="endTime" runat="server" ErrorMessage="Field cannot be blank" Display="Dynamic" />
                    <asp:CustomValidator ControlToValidate="endTime" runat="server" OnServerValidate="ValidateEndTime" ErrorMessage="Invalid time format. Format is MM/DD/YYYY HH:MM:SS" Display="Dynamic" />
				    <br />
				    <label for="price">Ticket Price</label>
				    <asp:TextBox runat="server" class="input" ID="ticketPrice" />
                    <br />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="ticketPrice" ErrorMessage="Field cannot be blank" Display="Dynamic" />
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="ticketPrice" ErrorMessage="Invalid price format" Display="Dynamic" ValidationExpression="\d+" />
                    <asp:CustomValidator runat="server" ControlToValidate="ticketPrice" ErrorMessage="Price out of range" OnServerValidate="ValidatePrice" Display="Dynamic" />
                    <br />
                    <asp:Label ID="scheduleLabel" runat="server" CssClass="successLabel" />
                    <br />
				    <asp:Button runat="server" type="submit" Text="Submit" id="submit" OnClick="scheduleButtonClicked" CssClass="successLabel" />
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