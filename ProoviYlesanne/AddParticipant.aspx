<%@ Page Title="Add participant" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddParticipant.aspx.cs" Inherits="ProoviYlesanne.AddParticipant" %>
<%@ Register Src="UserControls/CompanyCreatorUC.ascx" TagName="companyUC" TagPrefix="companyControl" %>
<%@ Register Src="UserControls/PersonCreatorUC.ascx" TagName="personUC" TagPrefix="personControl" %>
<%@ Register Src="UserControls/AddParticipantStartUC.ascx" TagName="startUC" TagPrefix="participantStartControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<asp:PlaceHolder ID="addParticipantPlaceHolder" runat="server"></asp:PlaceHolder>
</asp:Content>
