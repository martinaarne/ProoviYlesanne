<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddParticipantStartUC.ascx.cs" Inherits="ProoviYlesanne.UserControls.AddParticipantStartUC" %>
    <h2>Adding a participant</h2>
    <p>Choose which kind of participant you want to add:</p>
    <table>
        <tr>
            <th><a href="/AddParticipant.aspx?id=<%=eventID%>&type=person">Person</a></th>
            <th><a href="/AddParticipant.aspx?id=<%=eventID%>&type=company">Company</a></th>
        </tr>
    </table>