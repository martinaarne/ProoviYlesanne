using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProoviYlesanneClassLibrary
{
    public class EventDB
    {
        //Meetod tagastab andmebaasist kõik sündmused, mis on toimunud ja on tulemas
        public static List<Event> getFrontPageEventList()
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.Events
                             select new Event(x));

                return query.ToList<Event>();
            }
        }
        //Meetod tagastab sündmuse ID järgi
        public static Event getEventById(int eventID)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.Events
                             where x.ID == eventID
                             select new Event(x)).FirstOrDefault();
                return query;
            }
        }
        //Meetod salvestab andmebaasi uue sündmuse objekti
        public static int saveNewEvent(Event inEvent)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                DBA.EventDatabase.Event meet = new DBA.EventDatabase.Event();
                meet.Name = inEvent.Name;
                meet.Location = inEvent.Location;
                meet.Date = inEvent.Date;
                meet.Info = inEvent.Info;

                db.Events.InsertOnSubmit(meet);
                db.SubmitChanges();

                return meet.ID;
            }
        }
        //Meetod kustutab andmebaasist sündmuse ning selles osalenud/osalevad inimesed ja firmad
        public static void deleteEventById(int eventID)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.Events
                             where x.ID == eventID
                             select x).First();
                db.Events.DeleteOnSubmit(query);

                List<ParticipantCompany> companies = CompanyDB.getAllParticipatingCompaniesInEvent(query.ID);
                List<ParticipantPerson> peopleList = PersonDB.getAllParticipatingPeopleInEvent(query.ID);
                //Itereerin läbi kõik firmad, mis osalevad/osalesid sündmusel
                foreach (ParticipantCompany company in companies)
                {
                    //Kustutan firma andmebaasist
                    CompanyDB.deleteCompanyByID(company.CompanyID);
                }
                //Itereerin läbi kõik inimesed, kes osalevad/osalesid sündmusel
                foreach (ParticipantPerson person in peopleList)
                {
                    //Kustutan inimese andmebaasist
                    PersonDB.deletePersonById(person.PersonID);
                }

                db.SubmitChanges();
            }
        }

        
    }
}
