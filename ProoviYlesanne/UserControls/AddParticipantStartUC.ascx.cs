using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProoviYlesanne.UserControls
{
    public partial class AddParticipantStartUC : System.Web.UI.UserControl
    {

        public string eventID;
        protected void Page_Load(object sender, EventArgs e)
        {
            eventID = Request.QueryString["id"];
            DataBind();
        }
    }
}