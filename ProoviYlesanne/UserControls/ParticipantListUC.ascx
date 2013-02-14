<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ParticipantListUC.ascx.cs" Inherits="ProoviYlesanne.UserControls.ParticipantListUC" %>
<asp:Repeater runat="server" ID="rptPeopleList">
        <HeaderTemplate>
            <h3>Participating people</h3>
            <table>
                <tr>
                    <th>Name</th>
                    <th>ID Code</th>
                    <th>Delete Participant</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
                <tr>
                    <td><a href="/ChangePerson.aspx?id=<%#((ProoviYlesanneClassLibrary.ParticipantPerson)Container.DataItem).PersonID%>"><%#((ProoviYlesanneClassLibrary.ParticipantPerson)Container.DataItem).Firstname + " " + ((ProoviYlesanneClassLibrary.ParticipantPerson)Container.DataItem).Lastname%></a></td>
                    <td><%#((ProoviYlesanneClassLibrary.ParticipantPerson)Container.DataItem).IDcode%></td>
                    <td><a href="/DeleteParticipant.aspx?id=<%#((ProoviYlesanneClassLibrary.ParticipantPerson)Container.DataItem).PersonID%>&type=person">Delete</a></td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Repeater runat="server" ID="rptCompanyList">
        <HeaderTemplate>
            <h3>Participating companies</h3>
            <table>
                <tr>
                    <th>Name</th>
                    <th>Registry number</th>
                    <th>Delete Participant</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><a href="/ChangeCompany.aspx?id=<%#((ProoviYlesanneClassLibrary.ParticipantCompany)Container.DataItem).CompanyID%>"><%#((ProoviYlesanneClassLibrary.ParticipantCompany)Container.DataItem).Name%></a></td>
                <td><%#((ProoviYlesanneClassLibrary.ParticipantCompany)Container.DataItem).RegNumber%></td>
                <td><a href="/DeleteParticipant.aspx?id=<%#((ProoviYlesanneClassLibrary.ParticipantCompany)Container.DataItem).CompanyID%>&type=company">Delete</a></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>