using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProoviYlesanneClassLibrary;

namespace ProoviYlesanne
{
    public partial class DeleteParticipant : System.Web.UI.Page
    {
        public int participantID;
        protected void Page_Load(object sender, EventArgs e)
        {
            string temp = Request.QueryString["id"];
            //Parsen queryStringist välja osalise ID
            bool result = Int32.TryParse(temp, out participantID);
            //Kui osaline on inimene, siis kustutan inimese andmebaasist
            if(Request.QueryString["type"].Equals("person") && result)
            {
                PersonDB.deletePersonById(participantID);
            }
            //Kui osaline on firma, siis kustutan firma andmebaasist
            else if (Request.QueryString["type"].Equals("company") && result)
            {
                CompanyDB.deleteCompanyByID(participantID);
            }
            else
            {
                //Kui queryStringis on viga sees, siis hüppab tekst kasutajale näkku ka ütleb, et midagi on valesti
                Response.Write("<h2>Something's wrong</h2>");
            }
        }
    }
}