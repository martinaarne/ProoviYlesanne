using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProoviYlesanneClassLibrary;
using ProoviYlesanne.UserControls;

namespace ProoviYlesanne
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Event> eventList = EventDB.getFrontPageEventList();
            EventListUC eventListUC = (EventListUC)Page.LoadControl(UserControls.ControlLocations.EventListUC);
            //Lisan UserControl-i kõik sündmused
            eventListUC.EventList = eventList;
            if (eventList.Count > 0)
            {
                //lisan placeHolderisse UserControli
                eventListPlaceHolder.Controls.Add(eventListUC);
            }
        }
    }
}
