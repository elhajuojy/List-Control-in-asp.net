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

        protected void Button3_Click(object sender, EventArgs e)
        {
            RadiobuttonList1.SelectedIndex = -1; 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (RadiobuttonList1.SelectedIndex !=-1)
            {
                Response.Write("Text " + RadiobuttonList1.SelectedItem.Text + ",");
                Response.Write("VaLue " + RadiobuttonList1.SelectedItem.Value + ",");
                Response.Write("Index " + RadiobuttonList1.SelectedIndex.ToString() + "<br/>");
            }
        }
    }
}