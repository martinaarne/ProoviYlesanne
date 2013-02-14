using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProoviYlesanneClassLibrary
{
    public class ParticipantPerson
    {
        private int _personID;
        private string _firstname;
        private string _lastname;
        private string _IDcode;
        //Kui cashPayment on true, siis maksab/maksis osaline sularahaga
        //Kui cashPayment on false, siis maksab/maksis osaline ülekandega
        private bool _cashPayment;
        private string _info;
        private int _eventID;

        public int PersonID
        {
            get { return _personID; }
            set { _personID = value; }
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string IDcode
        {
            get { return _IDcode; }
            set { _IDcode = value; }
        }

        public bool CashPayment
        {
            get { return _cashPayment; }
            set { _cashPayment = value; }
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
        //Konstruktor andmebaasist pärimiseks (LINQ päringus)
        public ParticipantPerson(DBA.EventDatabase.ParticipantPerson person)
        {
            _personID = person.ID;
            _firstname = person.Firstname;
            _lastname = person.Lastname;
            _IDcode = person.IDcode;
            _cashPayment = person.CashPayment;
            _info = person.Info;
        }
        //Tühi konstruktor
        public ParticipantPerson()
        { 
        }

    }
}
