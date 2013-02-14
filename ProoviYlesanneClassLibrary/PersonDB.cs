using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProoviYlesanneClassLibrary
{
    public class PersonDB
    {
        //Meetod tagastab inimese ID järgi
        public static ParticipantPerson getPersonById(int personID)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.ParticipantPersons
                             where x.ID == personID
                             select new ParticipantPerson(x)).First();
                return query;
            }
        }
        //Meetod tagastab kõik sündmusel osalevad inimesed
        public static List<ParticipantPerson> getAllParticipatingPeopleInEvent(int eventID)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.ParticipantPersons
                             where x.EventID == eventID
                             select new ParticipantPerson(x));

                return query.ToList<ParticipantPerson>();
            }
        }
        //Meetod salvestab uue osalise isiku andmebaasi
        public static int saveNewPerson(ParticipantPerson person, Event meet)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                DBA.EventDatabase.ParticipantPerson _person = new DBA.EventDatabase.ParticipantPerson();
                _person.Firstname = person.Firstname;
                _person.Lastname = person.Lastname;
                _person.IDcode = person.IDcode;
                _person.CashPayment = person.CashPayment;
                _person.Info = person.Info;
                _person.EventID = meet.ID;

                db.ParticipantPersons.InsertOnSubmit(_person);
                db.SubmitChanges();
                return _person.ID;
            }
        }
        //Meetod kustutab sündmusel osaleva inimese tema ID järgi
        public static void deletePersonById(int personID)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.ParticipantPersons
                             where x.ID == personID
                             select x).First();

                db.ParticipantPersons.DeleteOnSubmit(query);
                db.SubmitChanges();
            }
        }
        //Meetod uuendab inimese andmebaasis
        public static void updatePerson(ParticipantPerson person)
        {
            using(DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.ParticipantPersons
                            where x.ID == person.PersonID
                            select x).Single();

                query.Firstname = person.Firstname;
                query.Lastname = person.Lastname;
                query.IDcode = person.IDcode;
                query.CashPayment = person.CashPayment;
                query.Info = person.Info;

                db.SubmitChanges();
            }
        }
    }
}
