<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventListUC.ascx.cs" Inherits="ProoviYlesanne.UserControls.EventListUC" %>
<div class="eventList">
    <asp:Repeater runat="server" ID="rptEventList">
        <HeaderTemplate>
            <table>
                <tr>
                    <th>Name</th>
                    <th>Date/Time</th>
                    <th>Location</th>
                    <th>Participants</th>
                    <th>Add participants</th>
                    <th>Delete event</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
                <tr>
                    <td><a href="/ViewParticipants.aspx?id=<%#((ProoviYlesanneClassLibrary.Event)Container.DataItem).ID%>"><%#((ProoviYlesanneClassLibrary.Event)Container.DataItem).Name %></a></td>
                    <td><%#((ProoviYlesanneClassLibrary.Event)Container.DataItem).Date%></td>
                    <td><%#((ProoviYlesanneClassLibrary.Event)Container.DataItem).Location%></td>
                    <td><%#((ProoviYlesanneClassLibrary.Event)Container.DataItem).Participants%></td>
                    <td><a href="/AddParticipant.aspx?id=<%#((ProoviYlesanneClassLibrary.Event)Container.DataItem).ID%>&type=start">Add</a></td>
                    <td><a href="/DeleteEvent.aspx?id=<%#((ProoviYlesanneClassLibrary.Event)Container.DataItem).ID%>">Delete</a></td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>

    </asp:Repeater>
</div>