using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProoviYlesanneClassLibrary;

namespace ProoviYlesanne.UserControls
{
    public partial class CompanyCreatorUC : System.Web.UI.UserControl
    {
        public int eventID;
        ParticipantCompany company;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Parsen queryStringist välja sündmuse ID;
            int number;
            bool result = Int32.TryParse(Request.QueryString["id"], out number);
            if (result)
            {
                eventID = number;
            }
        }
        //Kui vajutatakse Submit nuppu
        protected void btnCompanySubmit_Click(object sender, EventArgs e)
        {
            //Loon uue osaleva firma objekti ja täidan andmetega
            company = new ParticipantCompany();
            company.Name = textBoxCompanyName.Text;
            company.RegNumber = textBoxRegNo.Text;

            if (DropDownList1.SelectedIndex == 1)
            {
                company.CashPayment = false;
            }
            else
            {
                company.CashPayment = true;
            }
            //Parsen välja textboxist osaliste arvu
            int participants;
            bool result = Int32.TryParse(textBoxParticipants.Text, out participants);
            if (result)
            {
                company.Participants = participants;
            }
            company.Info = textBoxCompanyInfo.Text;
            //Leian sündmuse ID järgi, et selle järgi hiljem andmebaasi lisada
            Event meet = EventDB.getEventById(eventID);
            //Salvestan uue osaleva firma andmebaasi
            int companyID = CompanyDB.saveNewCompany(company, meet);
            //Redirectin lehele, kus saab valida kas lisada isik või firma sündmusele
            Response.Redirect("~/AddParticipant.aspx?id="+eventID+"&type=start");
        }
        //Kui vajutatakse Change nuppu
        protected void btnChangeCompany_Click(object sender, EventArgs e)
        {
            int companyID;
            bool result = Int32.TryParse(Request.QueryString["id"], out companyID);
            if (result)
            {
                //Loon uue osaleja objekti ja annan väärtused
                company = new ParticipantCompany();
                company.Name = textBoxCompanyName.Text;
                company.RegNumber = textBoxRegNo.Text;
                int participants;
                bool participantResult = Int32.TryParse(textBoxParticipants.Text, out participants);
                if (participantResult)
                {
                    company.Participants = participants;
                }
                company.Info = textBoxCompanyInfo.Text;
                if (DropDownList1.SelectedIndex == 1)
                {
                    company.CashPayment = false;
                }
                else
                {
                    company.CashPayment = true;
                }
                //Teen andmebaasipäringu firma muutmiseks
                CompanyDB.updateCompany(company);
            }
        }
        //Meetod täidab vormi andmetega
        public void fillWithData(ParticipantCompany company)
        {
            textBoxCompanyName.Text = company.Name;
            textBoxRegNo.Text = company.RegNumber;
            if (company.CashPayment == false)
            {
                DropDownList1.SelectedIndex = 1;
            }
            textBoxParticipants.Text = company.Participants.ToString();
            textBoxCompanyInfo.Text = company.Info;
            //Seda meetodit kasutatakse ainult "edit" funktsiooni jaoks,
            //sel puhul peidan Submit nupu ära ja teen Change nupu nähtavaks
            btnCompanySubmit.Visible = false;
            btnChangeCompany.Visible = true;
        }

    }
}