using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProoviYlesanneClassLibrary;

namespace ProoviYlesanne
{
    public partial class ChangePerson : System.Web.UI.Page
    {
        public int personID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Parsen queryStringist välja isiku ID
            bool result = Int32.TryParse(Request.QueryString["id"], out personID);
            if (result)
            {

                personChanger.fillWithData(PersonDB.getPersonById(personID));
            }
            
        }
    }
}