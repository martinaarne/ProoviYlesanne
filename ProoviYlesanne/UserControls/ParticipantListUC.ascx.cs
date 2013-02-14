using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProoviYlesanneClassLibrary;

namespace ProoviYlesanne.UserControls
{
    public partial class ParticipantListUC : System.Web.UI.UserControl
    {
        private List<ParticipantPerson> _peopleList;
        private List<ParticipantCompany> _companyList;

        public List<ParticipantCompany> CompanyList
        {
            get { return _companyList; }
            set { _companyList = value; }
        }
        public List<ParticipantPerson> PeopleList
        {
            get { return _peopleList; }
            set { _peopleList = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            rptPeopleList.DataSource = _peopleList;
            rptPeopleList.DataBind();

            rptCompanyList.DataSource = _companyList;
            rptCompanyList.DataBind();
        }
    }
}