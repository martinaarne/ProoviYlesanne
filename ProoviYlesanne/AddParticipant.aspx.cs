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
    public partial class AddParticipant : System.Web.UI.Page
    {

        public string eventID;
        public string participantType;
        protected void Page_Load(object sender, EventArgs e)
        {
            eventID = Request.QueryString["id"];
            participantType = Request.QueryString["type"];
            //Kui klikiti sündmuse lehel osalise lisamise lingile, siis laen lisamise "esilehe"
            if (participantType.Equals("start"))
            {
                //Teen placeholderi tühjaks
                addParticipantPlaceHolder.Controls.Clear();
                //lisan placeholderile alguse UserControli
                AddParticipantStartUC startUC = (AddParticipantStartUC)Page.LoadControl(UserControls.ControlLocations.AddParticipantStartUC);
                addParticipantPlaceHolder.Controls.Add(startUC);
            }
            else if (participantType.Equals("company"))
            {
                //Teen placeholderi tühjaks
                addParticipantPlaceHolder.Controls.Clear();
                //Lisan palceholderile firma lisamise UserControli
                CompanyCreatorUC companyUC = (CompanyCreatorUC)Page.LoadControl(UserControls.ControlLocations.CompanyCreatorUC);
                addParticipantPlaceHolder.Controls.Add(companyUC);
            }
            else if (participantType.Equals("person"))
            {
                //Teen placeholderi tühjaks
                addParticipantPlaceHolder.Controls.Clear();
                //Lisan palceholderile inimese lisamise UserControli
                PersonCreatorUC personUC = (PersonCreatorUC)Page.LoadControl(UserControls.ControlLocations.PersonCreatorUC);
                addParticipantPlaceHolder.Controls.Add(personUC);
            }
        }
    }
}