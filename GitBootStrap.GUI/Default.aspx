<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GitBootStrap.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title>First BootStrap</title>
    <meta charset="utf-8" />
    <script src="js/bootstrap.min.js"></script>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/bootstrap-theme.min.css" rel="stylesheet" />
</head>
<body>
    <header>
        <h1>Hi GUYS!!!</h1>
    </header>

    <article>
        <h2>CONTAINERS</h2>
        <div class="container" style="background-color:coral;">
            <h3>div class='container'</h3>
            <ul>
                <li><h4>Item 1</h4></li>
                <li><h4>Item 2</h4></li>
                <li><h4>Item 3</h4></li>
                <li><h4>Item 4</h4></li>
            </ul>
        </div>

        <div class="container-fluid" style="background-color:limegreen;">
            <h3>div class='container-fluid'</h3>
            <ul>
                <li><h4>Item 1</h4></li>
                <li><h4>Item 2</h4></li>
                <li><h4>Item 3</h4></li>
                <li><h4>Item 4</h4></li>
            </ul>
        </div>

        <br /><br />

        <form runat="server" id="form1">
            <asp:ListBox ID="ListBox1" runat="server" SelectMethod="detailsList" ItemType="GitBootStrap.Domain.Entities.Team" DataTextField="Name" DataValueField="Id"></asp:ListBox>
        </form>
    </article>

    <footer>Copyright &copy; ESPRIT 2014</footer>
</body>
</html>
