using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProoviYlesanneClassLibrary;

namespace ProoviYlesanneClassLibrary
{
    public class CompanyDB
    {
        //Meetod tagastab osaleva firma ID järgi
        public static ParticipantCompany getCompanyByID(int companyID)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.ParticipantCompanies
                             where x.ID == companyID
                             select new ParticipantCompany(x)).First();
                return query;
            }
        }
        //Meetod tagastab kõik sündmusel osalevad/osalenud firmad
        public static List<ParticipantCompany> getAllParticipatingCompaniesInEvent(int eventID)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.ParticipantCompanies
                             where x.EventID == eventID
                             select new ParticipantCompany(x));

                return query.ToList<ParticipantCompany>();
            }
        }
        //Meetod salvestab baasi uue osaleva firma objekti
        public static int saveNewCompany(ParticipantCompany company, Event meet)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                DBA.EventDatabase.ParticipantCompany _company = new DBA.EventDatabase.ParticipantCompany();
                _company.Name = company.Name;
                _company.RegistryNumber = company.RegNumber;
                _company.CashPayment = company.CashPayment;
                _company.Participants = company.Participants;
                _company.Info = company.Info;
                _company.EventID = meet.ID;

                db.ParticipantCompanies.InsertOnSubmit(_company);
                db.SubmitChanges();
                return _company.ID;
            }
        }
        //Meetod kustutab andmebaasist firma ID järgi
        public static void deleteCompanyByID(int companyID)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.ParticipantCompanies
                             where x.ID == companyID
                             select x).First();

                db.ParticipantCompanies.DeleteOnSubmit(query);
                db.SubmitChanges();
            }
        }
        //Meetud uuendab firma andmeid andmebaasis
        public static void updateCompany(ParticipantCompany company)
        {
            using (DBA.EventDatabase.EventDatabaseDataContext db = new DBA.EventDatabase.EventDatabaseDataContext())
            {
                var query = (from x in db.ParticipantCompanies
                             where x.ID == company.CompanyID
                             select x).Single();

                query.Name = company.Name;
                query.RegistryNumber = company.RegNumber;
                query.CashPayment = company.CashPayment;
                query.Participants = company.Participants;
                query.Info = company.Info;

                db.SubmitChanges();
            }
        }
    }
}
