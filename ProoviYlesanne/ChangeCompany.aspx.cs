using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProoviYlesanneClassLibrary;

namespace ProoviYlesanne
{
    public partial class ChangeCompany : System.Web.UI.Page
    {
        int companyID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Parsen queryStringist välja firma ID
            bool result = Int32.TryParse(Request.QueryString["id"], out companyID);
            if (result)
            {

                companyChanger.fillWithData(CompanyDB.getCompanyByID(companyID));
            }
        }
    }
}