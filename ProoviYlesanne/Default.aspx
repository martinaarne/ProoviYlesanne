<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ProoviYlesanne._Default" %>
<%@ Register Src="UserControls/EventListUC.ascx" TagName="eventList" TagPrefix="eventControl" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to Martin Aarne's excellent Event Infosystem!
    </h2>

    <asp:PlaceHolder ID="eventListPlaceHolder" runat="server"></asp:PlaceHolder>
    </asp:Content>
