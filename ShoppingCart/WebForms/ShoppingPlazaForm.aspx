<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingPlazaForm.aspx.cs" Inherits="ShoppingCart.WebForms.ShoppingPlazaFormaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="ShoppingPlazaStyle.css" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 72px;
        }
        .auto-style3 {
            width: 365px;
        }
        .auto-style4 {
            width: 192px;
        }
        .auto-style5 {
            width: 127px;
        }
        .auto-style6 {
            width: 95px;
        }
        .auto-style7 {
            color: #FF0000;
        }
    </style>
</head>
<body style="width: 893px">
    <form id="form1" runat="server">
    <div>
        <h1>Here you make your selections. You can select one book title and one DVD title.</h1>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Books</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="BooksDropDownList" runat="server" AutoPostBack="True" Height="35px" Width="416px" OnSelectedIndexChanged="BooksDropDownList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style6">Quantity</td>
                <td class="auto-style4">
                    <asp:TextBox ID="BookQuantityTextBox" runat="server" Width="171px"></asp:TextBox>
                </td>
                <td class="auto-style5">Price of Book:</td>
                <td>
                    <asp:Label ID="BookPriceValLbl" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">DVDS</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DVDDropDownList" runat="server" AutoPostBack="True" Width="415px" OnSelectedIndexChanged="DVDDropDownList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style6">Quantity</td>
                <td>
                    <asp:TextBox ID="DVDQuantityTextbox" runat="server" Width="170px"></asp:TextBox>
                </td>
                <td class="auto-style5">Price of DVD:</td>
                <td>
                    <asp:Label ID="DVDPriceValLbl" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="MessageLbl" runat="server"></asp:Label>
                    <asp:Label ID="MessageLbl1" runat="server" CssClass="auto-style7"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="AddItemBtn" runat="server" Text="Add" Width="134px" OnClick="AddItemBtn_Click" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout" OnClick="CheckoutBtn_Click" />
                </td>
                <td></td>
                <td class="auto-style5">
                    <asp:Button ID="ExitBtn" runat="server" Text="Exit" Width="123px" OnClick="ExitBtn_Click" />
                </td>
                <td></td>
            </tr>
            </table>
    </div>
    </form>
</body>
</html>
