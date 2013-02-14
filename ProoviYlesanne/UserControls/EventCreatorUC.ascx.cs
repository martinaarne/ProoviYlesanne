using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProoviYlesanneClassLibrary;

namespace ProoviYlesanne.UserControls
{
    public partial class EventCreatorUC : System.Web.UI.UserControl
    {
        private Event _event;

        public Event Event
        {
            get { return _event; }
            set { _event = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Event newEvent = new Event();
            newEvent.Name = textBoxEventName.Text;
            newEvent.Location = textBoxEventLocation.Text;
            //Lisan toimumisajaks kalendrist saadud kuupäeva
            DateTime tempDateTime = eventDateCalendar.SelectedDate;
            //Kuupäevale lisan veel juurde toimumise tunnid ja minutid
            tempDateTime = tempDateTime.Date.AddHours(Double.Parse(eventHoursDropDown.SelectedValue));
            tempDateTime = tempDateTime.Date.AddMinutes(Double.Parse(eventMinutesDropDown.SelectedValue));
            //Kontrollin kas lisatud kuupäev ja kellaaeg on tulevikus
            if (tempDateTime > DateTime.Now)
            {
                newEvent.Date = tempDateTime;
            }
            //Kui kuupäev on minevikus, siis redirectin tagasi tühjale vormile
            else
            {
                Response.Redirect("~/AddEvent.aspx");
            }

            if (!textBoxEventInfo.Text.Trim().Length.Equals(0))
            {
                newEvent.Info = textBoxEventInfo.Text;
            }
            //Salvestan uue sündmuse andmebaasi
            int eventID = EventDB.saveNewEvent(newEvent);

            Response.Redirect("~/Default.aspx");
        }

        protected void eventDateCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}