using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dropDownListTp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach(ListItem t in CheckBoxList1.Items)
            {
                if (t.Selected)
                {
                    Response.Write("Text "+ t.Text+",");
                    Response.Write("VaLue " + t.Value + ",");
                    Response.Write("Index " + CheckBoxList1.Items.IndexOf(t) + "<br/>");
                }
            }
        }
    }
}