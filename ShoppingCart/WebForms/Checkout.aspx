<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="ShoppingCart.WebForms.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="CheckoutStyle.css" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 145px;
        }
        .auto-style2 {
            width: 520px;
        }
        .auto-style3 {
            height: 148px;
        }
    </style>
</head>
<body style="width: 926px; height: 542px">
    <form id="form1" runat="server">
        <asp:ListBox ID="CartListBox" runat="server" Height="352px" Width="919px" OnSelectedIndexChanged="CartListBox_SelectedIndexChanged"></asp:ListBox>
    <div class="auto-style3">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Change Quantity:
                    <asp:TextBox ID="QuantityTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="AcceptBtn" runat="server" Text="Accept Change" OnClick="AcceptBtn_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="PayBtn" runat="server" Text="Pay" Width="180px" OnClick="PayBtn_Click" />
                </td>
                <td>
                    <asp:Button ID="ExitBtn" runat="server" Text="Exit" Width="148px" OnClick="ExitBtn_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="TotalLabel" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
