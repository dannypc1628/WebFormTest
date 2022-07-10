<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:TextBox ID="TitleTextBox" runat="server"></asp:TextBox>
    <asp:TextBox ID="ContentTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="InsertButton" runat="server" Text="Button" OnClick="InsertButton_Click" />
    <asp:Panel ID="Panel1" runat="server"></asp:Panel>

    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</asp:Content>
