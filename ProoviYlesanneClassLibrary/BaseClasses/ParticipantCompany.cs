using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProoviYlesanneClassLibrary
{
    public class ParticipantCompany
    {
        private int _companyID;
        private string _name;
        private string _regNumber;
        //Kui cashPayment on true, siis maksab/maksis osaline sularahaga
        //Kui cashPayment on false, siis maksab/maksis osaline ülekandega
        private bool _cashPayment;
        private int _participants;
        private string _info;
        private int _eventID;

        public int CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string RegNumber
        {
            get { return _regNumber; }
            set { _regNumber = value; }
        }

        public bool CashPayment
        {
            get { return _cashPayment; }
            set { _cashPayment = value; }
        }

        public int Participants
        {
            get { return _participants; }
            set { _participants = value; }
        }

        public string Info
        {
            get { return _info; }
            set { _info = value; }
        }

        public int EventID
        {
            get { return _eventID; }
            set { _eventID = value; }
        }
        //Konstruktor andmebaasi päringuteks (LINQ päringus kasutamiseks)
        public ParticipantCompany(DBA.EventDatabase.ParticipantCompany company)
        {
            _companyID = company.ID;
            _name = company.Name;
            _regNumber = company.RegistryNumber;
            _cashPayment = company.CashPayment;
            _participants = company.Participants;
            _info = company.Info;
        }
        //Tühi konstruktor
        public ParticipantCompany()
        {
        }
    }
}
