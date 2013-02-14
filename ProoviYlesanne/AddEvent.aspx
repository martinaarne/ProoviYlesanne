<%@ Page Title="Add Event" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEvent.aspx.cs" Inherits="ProoviYlesanne.AddEvent" %>
<%@ Register Src="UserControls/EventCreatorUC.ascx" TagName="eventCreator" TagPrefix="eventcontrol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <eventcontrol:eventCreator id="eventCreator" runat="server"></eventcontrol:eventCreator>
</asp:Content>
