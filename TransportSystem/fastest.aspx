<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fastest.aspx.cs" Inherits="TransportSystem.fastest" %>

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
				    <li><a href="arriving.aspx" >Arriving</a></li>
				    <li><a href="departing.aspx">Departing</a></li>
				    <li><a href="#" class="active">Fastest</a></li>
				    <li><a href="cheapest.aspx">Cheapest</a></li>
			    </ul>
			    <article id="logout">
				    <asp:Button CssClass="logout" runat="server" Text="Logout" OnClick="Logout" />
			    </article>
		    </header>
		    <section class="centerText">
			    <article class="grey bold label">
				    Information about the fastest buses to a given place
			    </article>
			    <section class="container bigger bordered">
				    <article class="pick">
					    Please, select that end point to which you'd like the fastest way to be computed.
				    </article>
				    <br />
				    <label for="endPoint"/>Enter the end point</label>
				    <asp:TextBox ID="endPoint" runat="server" CssClass="input" Text="Enter the end point" />
				    <asp:Button id="filter" Text="Submit" runat="server" OnClick="OnEndPointButtonClicked"/>
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