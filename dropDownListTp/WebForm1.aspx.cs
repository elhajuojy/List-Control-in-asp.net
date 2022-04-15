using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace dropDownListTp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection ctn = new SqlConnection(@"Data Source=ELHAJUOJY-LAPTO\MEHDI;Initial Catalog=dropDownList;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ddlContinents.DataSource = GetData("spGetContinents", null);
                ddlContinents.DataTextField = "ContinentsName";
                ddlContinents.DataValueField = "ContinentsId";
                ddlContinents.DataBind();

                ListItem listContinents = new ListItem("Select Continentes", "-1");
                ddlContinents.Items.Insert(0, listContinents);

                ListItem listCountry = new ListItem("Select Country", "-1");
                ddlCountry.Items.Insert(0, listCountry);

                ListItem listCity = new ListItem("Select City", "-1");
                ddlCity.Items.Insert(0, listCity);

                ddlCountry.Enabled = false;
                ddlCity.Enabled = false;


            }

        }

        private DataSet GetData (string SpName ,SqlParameter sppparameter)
        {
            SqlDataAdapter da = new SqlDataAdapter(SpName, ctn);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if(sppparameter != null)
            {
                da.SelectCommand.Parameters.Add(sppparameter);
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        protected void ddlContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(ddlContinents.SelectedIndex == 0)
            {
                ddlCountry.SelectedIndex = 0;
                ddlCountry.Enabled = false;
            }
            else
            {
               
                ddlCountry.Enabled = true;
                SqlParameter pr = new SqlParameter("@ContinentsId", ddlContinents.SelectedValue);
                DataSet ds = GetData("spGetCountrybyContinentsID", pr);
                ddlCountry.DataSource = ds;
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryId";
                ddlCountry.DataBind();
                ListItem listCity = new ListItem("Select country ", "-1");
                ddlCountry.Items.Insert(0, listCity);
            }
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCountry.SelectedIndex == 0)
            {
                ddlCity.SelectedIndex = 0;
                ddlCity.Enabled = false;
            }
            else
            {
                ddlCity.Enabled = true;
                SqlParameter pr = new SqlParameter("@CountryId", ddlCountry.SelectedValue);
                DataSet ds = GetData("spGetCitybyCountryID", pr);
                ddlCity.DataSource = ds;
                ddlCity.DataTextField = "CityName";
                ddlCity.DataValueField = "CityId";
                ddlCity.DataBind();
                //ListItem listCity = new ListItem("Select City ", "-1");
                //ddlCity.Items.Insert(0, listCity);
            }
        }
    }
}