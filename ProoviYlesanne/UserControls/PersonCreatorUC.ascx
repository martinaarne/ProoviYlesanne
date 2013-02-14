<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PersonCreatorUC.ascx.cs" Inherits="ProoviYlesanne.UserControls.PersonCreatorUC" %>
<p>Participant's first name:</p>
<asp:TextBox ID="textBoxPersonFirstName" runat="server" MaxLength="50" Width="600px"></asp:TextBox><br />
<asp:RequiredFieldValidator ID="personFirstNameValidator" runat="server" ControlToValidate="textBoxPersonFirstName" ForeColor="Red" ErrorMessage="Enter a name"></asp:RequiredFieldValidator>
<p>Participant's last name:</p>
<asp:TextBox ID="textBoxPersonLastName" runat="server" MaxLength="50" Width="600px"></asp:TextBox><br />
<asp:RequiredFieldValidator ID="personLastNameValidator" runat="server" ControlToValidate="textBoxPersonLastName" ForeColor="Red" ErrorMessage="Enter a registry number"></asp:RequiredFieldValidator>
<p>ID code:</p>
<asp:TextBox ID="textBoxPersonIDcode" runat="server" MaxLength="15" Width="600px"></asp:TextBox><br />
<asp:RequiredFieldValidator ID="personIDcodeValidator" runat="server" ControlToValidate="textBoxPersonIDcode" ForeColor="Red" ErrorMessage="Enter the amount of participants"></asp:RequiredFieldValidator>
<p>Type of payment:</p>
<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem>Cash</asp:ListItem>
    <asp:ListItem>Bank transfer</asp:ListItem>
</asp:DropDownList>
<p>Info</p>
<asp:TextBox ID="textBoxPersonInfo" MaxLength="1500" TextMode="MultiLine" runat="server" Width="600px"></asp:TextBox>
<br />
<asp:Button ID="btnPersonSubmit" runat="server" Text="Submit" 
    onclick="btnPersonSubmit_Click" />
<asp:Button ID="btnPersonChange" runat="server" Text="Change" Visible="false" 
    onclick="btnPersonChange_Click" />