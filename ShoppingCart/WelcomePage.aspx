<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="ShoppingCart.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="WebForms/site.css"/>    
    <style type="text/css">
        .auto-style1 {
            height: 493px;
        }
    </style>
    </head>
<body style="width: 781px; height: 517px">
    <form id="form1" runat="server">
    <div class="auto-style1">
      <h1>Welcome to the Shopping Plaza!!!</h1>
      <p> Here you can purchase books and DVDs. Simply follow the instructions provided below:</p>
      <p>Instructions: </p>
        <p>1. Select the book and enter the quantity. Click Add.</p>
        <p>2. Select the DVD and enter the quantity. Click Add.</p>
        <p>3. To check-out, click Check-Out.</p>
        <p>4. To close the application, click Exit. You will lose your selections.</p>
        <p>5. In the check out screen, revise the quantities if you wisht to. If you do, click Edit.</p>
        <p>6. To place the final order, click Pay.</p>
        <p>7. To close the application, click Exit. You will lose your selections. </p>
        <asp:Button ID="ShoppingPlazaButton" class="mybutton" runat="server" Text="Go to Shopping Plaza" Width="239px" OnClick="ShoppingPlazaButton_Click" />
        <asp:Button ID="ExitBtn" runat="server" Text="Exit" Width="117px" OnClick="ExitBtn_Click" />
    </div>
    </form>
</body>
</html>
