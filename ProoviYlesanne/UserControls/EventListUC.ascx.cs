using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProoviYlesanneClassLibrary;

namespace ProoviYlesanne.UserControls
{
    public partial class EventListUC : System.Web.UI.UserControl
    {
        private List<Event> _eventList;

        public List<Event> EventList
        {
            get { return _eventList; }
            set { _eventList = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            rptEventList.DataSource = _eventList;
            rptEventList.DataBind();
        }
    }
}