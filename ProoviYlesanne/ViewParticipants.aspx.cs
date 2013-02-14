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
    public partial class ViewParticipants : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string eventID = Request.QueryString["id"];
            int eventIDnumber;
            //Parsen queryStringist välja sündmuse ID
            bool result = Int32.TryParse(eventID, out eventIDnumber);
            if (result)
            {
                //Täidan UserControli andmetega
                List<ParticipantPerson> peopleList = PersonDB.getAllParticipatingPeopleInEvent(eventIDnumber);
                List<ParticipantCompany> companyList = CompanyDB.getAllParticipatingCompaniesInEvent(eventIDnumber);
                ParticipantListUC participantList = (ParticipantListUC)Page.LoadControl(UserControls.ControlLocations.ParticipantListUC);

                participantList.PeopleList = peopleList;
                participantList.CompanyList = companyList;
                //Lisan placeholderisse UserControli
                EventParticipantsPlaceHolder.Controls.Add(participantList);
            }
        }
    }
}