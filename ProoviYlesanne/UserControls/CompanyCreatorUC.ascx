<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CompanyCreatorUC.ascx.cs" Inherits="ProoviYlesanne.UserControls.CompanyCreatorUC" %>
<p>Company name:</p>
<asp:TextBox ID="textBoxCompanyName" runat="server" MaxLength="100" Width="600px"></asp:TextBox><br />
<asp:RequiredFieldValidator ID="companyNameValidator" runat="server" ControlToValidate="textBoxCompanyName" ForeColor="Red" ErrorMessage="Enter a name"></asp:RequiredFieldValidator>
<p>Registry number:</p>
<asp:TextBox ID="textBoxRegNo" runat="server" MaxLength="25" Width="600px"></asp:TextBox><br />
<asp:RequiredFieldValidator ID="companyRegNoValidator" runat="server" ControlToValidate="textBoxRegNo" ForeColor="Red" ErrorMessage="Enter a registry number"></asp:RequiredFieldValidator>
<p>Number of participants:</p>
<asp:TextBox ID="textBoxParticipants" runat="server" MaxLength="4" Width="600px"></asp:TextBox><br />
<asp:RequiredFieldValidator ID="participantsValidator" runat="server" ControlToValidate="textBoxParticipants" ForeColor="Red" ErrorMessage="Enter the amount of participants"></asp:RequiredFieldValidator>
<p>Type of payment:</p>
<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem>Cash</asp:ListItem>
    <asp:ListItem>Bank transfer</asp:ListItem>
</asp:DropDownList>
<p>Info</p>
<asp:TextBox ID="textBoxCompanyInfo" MaxLength="5000" TextMode="MultiLine" runat="server" Width="600px"></asp:TextBox>
<br />
<asp:Button ID="btnCompanySubmit" runat="server" Text="Submit" 
    onclick="btnCompanySubmit_Click" />
<asp:Button ID="btnChangeCompany" runat="server" Text="Change" Visible="false" 
    onclick="btnChangeCompany_Click" />
