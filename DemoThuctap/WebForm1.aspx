<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoThuctap.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            margin-left: 38px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnGetValue" runat="server" OnClick="btnGetValue_Click" Text="GetValues" />
        <p>
            <asp:Label ID="lblValue" runat="server"></asp:Label>
        </p>
        <br />
               <table>
            <tr>
                <td>Id</td>
                <td><asp:Label ID="lblId" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Name</td>
                <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <br />

        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="92px" OnClick="btnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" CssClass="auto-style3" Text="Update" Width="84px" OnClick="btnUpdate_Click" style="height: 29px" />
         <asp:Button ID="btnDelete" runat="server" CssClass="auto-style3" Text="Delete" Width="84px" OnClick="btnDelete_Click" />
        <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged" PageSize="5">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>

    </form>
</body>
</html>
