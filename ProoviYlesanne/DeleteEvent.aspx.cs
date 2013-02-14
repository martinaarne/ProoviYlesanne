using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProoviYlesanneClassLibrary;

namespace ProoviYlesanne
{
    public partial class DeleteEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int eventID;

            if (Request.QueryString["id"] != null)
            {
                //Parsen queryStringist välja sündmuse ID
                bool result = Int32.TryParse(Request.QueryString["id"], out eventID);
                if (result)
                {
                    //Kustutan sündmuse andmebaasist
                    EventDB.deleteEventById(eventID);
                }
            }
        }
    }
}