<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>222</title>
</head>
<body>

    <form id="form1" runat="server">
    <asp:TreeView ID="TreeView1" runat="server" Height="244px" 
        onselectednodechanged="TreeView1_SelectedNodeChanged1" ShowLines="True" 
        Width="205px">
        <Nodes>
            <asp:TreeNode Text="NODE1" Value="NODE1">
                <asp:TreeNode Text="BranchNode" Value="BranchNode"></asp:TreeNode>
                <asp:TreeNode Text="LeafNode" Value="LeafNode"></asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="NODE2" Value="NODE2">
                <asp:TreeNode Text="BranchNode" Value="BranchNode"></asp:TreeNode>
                <asp:TreeNode Text="LeafNode" Value="LeafNode"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
    </asp:TreeView>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Height="22px" 
            style="margin-left: 21px; margin-top: 0px" Width="253px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="36px" onclick="Button1_Click1" 
            style="margin-left: 19px; margin-top: 1px" Text="Добавить корень" 
            Width="136px" />
        <asp:Button ID="Button2" runat="server" Height="32px" onclick="Button2_Click" 
            style="margin-left: 73px; margin-top: 22px" Text="Добавить ветвь" 
            Width="153px" />
    </p>
    <p>
        <asp:Button ID="Button3" runat="server" Height="27px" onclick="Button3_Click" 
            style="margin-left: 112px" Text="Удалить узел" Width="125px" />
    </p>
    <p style="width: 685px; height: 32px; margin-top: 35px">
        <asp:Button ID="Button5" runat="server" Height="29px" onclick="Button5_Click" 
            style="margin-left: 107px" Text="Переименовать" Width="144px" />
    </p>
    <asp:Panel ID="Panel1" runat="server" Height="36px" Visible="False" 
        Width="653px" style="margin-right: 0px">
        <asp:TextBox ID="TextBox2" runat="server" Height="25px" style="margin-top: 0px" 
            Width="151px"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" Height="27px" 
    onclick="Button4_Click" style="margin-left: 46px" Text="Выполнить" 
    Width="133px" />
    </asp:Panel>
    <p>
        &nbsp;</p>
    <p>
        
        &nbsp;</p>
        <p>
        
            &nbsp;</p>
        <p>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    </form>

    </body>
</html>
