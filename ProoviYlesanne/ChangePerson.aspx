<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangePerson.aspx.cs" Inherits="ProoviYlesanne.ChangePerson" %>
<%@ Register Src="UserControls/PersonCreatorUC.ascx" TagName="personCreator" TagPrefix="personControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<personControl:personCreator ID ="personChanger" runat="server"></personControl:personCreator>
</asp:Content>