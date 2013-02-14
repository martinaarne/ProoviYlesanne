<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangeCompany.aspx.cs" Inherits="ProoviYlesanne.ChangeCompany" %>
<%@ Register Src="UserControls/CompanyCreatorUC.ascx" TagName="companyCreator" TagPrefix="companyControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <companyControl:companyCreator ID ="companyChanger" runat="server"></companyControl:companyCreator>
</asp:Content>
