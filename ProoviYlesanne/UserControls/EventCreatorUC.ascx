<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventCreatorUC.ascx.cs" Inherits="ProoviYlesanne.UserControls.EventCreatorUC" %>
<h2>Add an event</h2>
<p>Event name:</p>
<asp:TextBox ID="textBoxEventName" runat="server" Width="600px"></asp:TextBox><br />
<asp:RequiredFieldValidator ID="eventNameValidator" runat="server" ControlToValidate="textBoxEventName" ForeColor="Red" ErrorMessage="Enter a name"></asp:RequiredFieldValidator>

<p>Event date and time:</p>
<asp:Calendar ID="eventDateCalendar" runat="server" BackColor="White" 
    BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
    Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
    onselectionchanged="eventDateCalendar_SelectionChanged" Width="200px">
    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
    <NextPrevStyle VerticalAlign="Bottom" />
    <OtherMonthDayStyle ForeColor="#808080" />
    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
    <SelectorStyle BackColor="#CCCCCC" />
    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
    <WeekendDayStyle BackColor="#FFFFCC" />
</asp:Calendar>
<table>
    <tr>
    <th>Hours</th>
    <th>Minutes</th>
    </tr>
    <tr>
        <td><asp:DropDownList ID="eventHoursDropDown" runat="server">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>21</asp:ListItem>
            <asp:ListItem>22</asp:ListItem>
            <asp:ListItem>23</asp:ListItem>
            </asp:DropDownList><b>:</b></td>
        <td><asp:DropDownList ID="eventMinutesDropDown" runat="server">
            <asp:ListItem>00</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>45</asp:ListItem>
            </asp:DropDownList></td>
    </tr>
</table>
<p>Event location:</p>
<asp:TextBox ID="textBoxEventLocation" runat="server" Width="600px"></asp:TextBox><br />
<asp:RequiredFieldValidator ID="eventLocationValidator" runat="server" ControlToValidate="textBoxEventLocation" ForeColor="Red" ErrorMessage="Enter a location"></asp:RequiredFieldValidator>
<p>Event info</p>
<asp:TextBox ID="textBoxEventInfo" runat="server" Width="600px" MaxLength="1000" TextMode="MultiLine" Height="90px"></asp:TextBox><br />
<asp:Button ID="btnSubmit" runat="server" Text="Submit" 
    onclick="btnSubmit_Click" />
<asp:Button ID="btnBack" runat="server" Text="Back" />