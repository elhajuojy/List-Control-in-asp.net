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
            if (!IsPostBack)
            {
                AddListItem(RadiobuttonList1);
                AddListItem(BulletedList1);
                AddListItem(CheckBoxList1);
                AddListItem(dropdownList1);

            }
        }

        private void GetMultipleSelection(ListControl listControl)
        {
            foreach(ListItem li in listControl.Items)
            {
                if (li.Selected)
                {
                    Response.Write("Text = " + li.Text + " Value = " + li.Value + " Index = " + listControl.Items.IndexOf(li).ToString()+ "<br/>");
                }
            }
        }
        private void AddListItem(ListControl listControl)
        {
            ListItem i1 = new ListItem("item 1","1");
            ListItem i2 = new ListItem("item 2","2");
            ListItem i3 = new ListItem("item 3","3");

            listControl.Items.Add(i1);
            listControl.Items.Add(i2);
            listControl.Items.Add(i3);
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

        protected void bulletedList1_Click(object sender , BulletedListEventArgs e)
        {
            ListItem li = BulletedList1.Items[e.Index];
            Response.Write("Text " + li.Text + ",");
            Response.Write("VaLue " + li.Value + ",");
            Response.Write("Index " + e.Index.ToString() + "<br/>");
        }

        protected void btnDropDownList1_Click(object sender, EventArgs e)
        {
            GetMultipleSelection(dropdownList1);
        }
    }
}