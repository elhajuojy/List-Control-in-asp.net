using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace dropDownListTp
{
    public partial class DropDownToXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("XML Country List"));
            dropdownlist1.DataSource = ds;
            dropdownlist1.DataTextField = "rank";
            dropdownlist1.DataValueField = "year";
            dropdownlist1.DataBind();

        }
    }
}