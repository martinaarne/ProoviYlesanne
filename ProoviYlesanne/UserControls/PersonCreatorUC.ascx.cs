using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProoviYlesanneClassLibrary;

namespace ProoviYlesanne.UserControls
{
    public partial class PersonCreatorUC : System.Web.UI.UserControl
    {
        ParticipantPerson person;
        //Sündmuse ID, mille hiljem parsen välja queryStringist
        public int eventID;
        protected void Page_Load(object sender, EventArgs e)
        {
            int number;
            //Parsen sündmuse ID queryStringist välja
            bool result = Int32.TryParse(Request.QueryString["id"], out number);
            if (result)
            {
                eventID = number;
            }
        }
        //Meetod rakendub, kui Submit nuppu vajutatakse
        protected void btnPersonSubmit_Click(object sender, EventArgs e)
        {
            //Loon uue osaleja objekti ja annan väärtused
            person = new ParticipantPerson();
            person.Firstname = textBoxPersonFirstName.Text.Trim();
            person.Lastname = textBoxPersonLastName.Text.Trim();
            person.IDcode = textBoxPersonIDcode.Text;
            if (DropDownList1.SelectedIndex == 1)
            {
                person.CashPayment = false;
            }
            else
            {
                person.CashPayment = true;
            }

            person.Info = textBoxPersonInfo.Text;

            Event meet = EventDB.getEventById(eventID);
            int personID = PersonDB.saveNewPerson(person, meet);
            Response.Redirect("~/AddParticipant.aspx?id=" + eventID + "&type=start");
        }
        //See meetod rakendub, kui Change nuppu vajutatakse
        //TODO see meetod ei muuda inimese andmeid andmebaasis
        protected void btnPersonChange_Click(object sender, EventArgs e)
        {
            int personID;
            bool result = Int32.TryParse(Request.QueryString["id"], out personID);
            if (result)
            {
                //Loon uue osaleja objekti ja annan väärtused
                person = new ParticipantPerson();
                person.PersonID = personID;
                person.Firstname = textBoxPersonFirstName.Text;
                person.Lastname = textBoxPersonLastName.Text;
                person.IDcode = textBoxPersonIDcode.Text;
                if (DropDownList1.SelectedIndex == 1)
                {
                    person.CashPayment = false;
                }
                else
                {
                    person.CashPayment = true;
                }
                person.Info = textBoxPersonInfo.Text;
                //Teen andmebaasipäringu inimese muutmiseks
                PersonDB.updatePerson(person);
            }
        }
        //See meetod täidab vormi osaleja andmetega
        public void fillWithData(ParticipantPerson person)
        {
            textBoxPersonFirstName.Text = person.Firstname.Trim();
            textBoxPersonLastName.Text = person.Lastname.Trim();
            textBoxPersonIDcode.Text = person.IDcode.Trim();
            if (person.CashPayment == false)
            {
                DropDownList1.SelectedIndex = 1;
            }

            textBoxPersonInfo.Text = person.Info;
            btnPersonSubmit.Visible = false;
            btnPersonChange.Visible = true;
        }
    }
}