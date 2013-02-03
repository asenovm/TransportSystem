<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="arriving.aspx.cs" Inherits="TransportSystem.arriving" %>

<!DOCTYPE html>
<html>
	<head>
		<title>Transport system - Login</title>
		<link type="text/css" rel="stylesheet" href="styles/main.css" />
		<script type="text/javascript" src="jscript/jquery-1.8.3.js"></script>
        <script type="text/javascript">
            var isUserLogged = '<%= IsUserLogged() %>' === 'True';
            $(document).ready(function () {
                if (!isUserLogged) {
                    $('ul li:lt(4)').css('display', 'none');
                }
            });
        </script>
	</head>
	<body>
        <form runat="server">
		    <header>
			    <h1>Transport Information System</h1>
			    <h2>Find the best way to travel</h2>
			    <ul id="menu">
				    <li><a href="register.aspx" >Register</a></li>
				    <li><a href="edit.aspx" >Edit</a></li>
				    <li><a href="schedule.aspx" >Schedule</a></li>
				    <li><a href="delete.aspx" >Delete</a></li>
				    <li><a href="#" class="active">Arriving</a></li>
				    <li><a href="departing.aspx" >Departing</a></li>
				    <li><a href="fastest.aspx">Fastest</a></li>
				    <li><a href="cheapest.aspx">Cheapest</a></li>
			    </ul>
			    <article id="logout">
				     <asp:Button CssClass="logout" runat="server" Text="Logout" OnClick="Logout" />
			    </article>
		    </header>
		    <section class="centerText">
			    <article class="grey bold label">
				    Information about the arriving buses
			    </article>
			    <section class="container bigger bordered">
				    <article class="pick">
					    Please, select the filter criteria you'd like to be applied
				    </article>
				    <br />
				    <asp:DropDownList ID="filterValues" runat="server" >
					    <asp:ListItem value="start">Start</asp:ListItem>
					    <asp:ListItem value="end">End</asp:ListItem>
					    <asp:ListItem value="company">Company</asp:ListItem>
					    <asp:ListItem value="startTime">Start Time</asp:ListItem>
					    <asp:ListItem value="endTime">End Time</asp:ListItem>
				    </asp:DropDownList>
				    <br />
				    <label for="Enter the filter value">Option value</label>
				    <asp:TextBox class="input" Text="Enter the filter value" runat="server" ID="filterValue" />
				    <br />
                    <asp:Button Text="Filter" id="filter" runat="server" OnClick="OnFilterButtonClicked"/>
				    <article class="pick">
					    Results
				    </article>
				    <asp:GridView ID="results" runat="server" CssClass="gridView">
                        <HeaderStyle CssClass="gridViewItem" />
                        <RowStyle CssClass="gridViewItem" />
                    
                    </asp:GridView>
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