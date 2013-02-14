using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProoviYlesanneClassLibrary
{
    public class Event
    {
        private int _eventID;
        private string _name;
        private DateTime _date;
        private string _location;
        private int _participants;
        private string _info;

        public int ID
        {
            get { return _eventID; }
            set { _eventID = value; }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
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
        //Konstruktor andmebaasi päringutes kasutamiseks (LINQ päringutes)
        public Event(DBA.EventDatabase.Event meet) //Kasutaksin meeleldi "event" parameetri nimena, aga kuna see on reserveeritud, kasutan "meet" selle asemel, kuna tähendus on suhteliselt sarnane
        {
            int participants = 0;
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                //Päring, mis leiab kõikide sündmusel osalevate firmade osalejate hulga
                var queryCompanies = from c in db.ParticipantCompanies
                                     join e in db.Events
                                            on c.EventID equals e.ID
                                     where e.ID == meet.ID
                                     select c.Participants;
                //Päring, mis leiab kõik sündmusel osalevad inimeste ID-d
                var queryPeople = from p in db.ParticipantPersons
                                  join e in db.Events
                                          on p.EventID equals e.ID
                                  where e.ID == meet.ID
                                  select p.ID;
                //Liidan kõikide sündmusel osalevate firmade osalejad kokku
                foreach (int i in queryCompanies)
                {
                    participants += i;
                }
                //Liidan kõik sündmusel osalevad inimesed kogu sündmusel osalevate inimeste hulgale juurde
                foreach (int j in queryPeople)
                {
                    participants++;
                }
            }
            _eventID = meet.ID;
            _name = meet.Name;
            _date = meet.Date;
            _location = meet.Location;
            _participants = participants;
            _info = meet.Info;
        }
        //Tühi konstruktor
        public Event()
        {
        }
    }
}
