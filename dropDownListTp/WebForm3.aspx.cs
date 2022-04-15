using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dropDownListTp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string FileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if(FileExtension.ToLower()!=".pdf")
                {
                    lblMessage.Text = "Seulement les fichiers avec l'extension .pdf sont autorises";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if(fileSize>2097152) // 2 M
                    {
                        lblMessage.Text = "la taille de votre fichier" + fileSize.ToString();
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Uploads/") + FileUpload1.FileName);
                        lblMessage.Text = "Fichier telecharge avec succes";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                lblMessage.Text = "Vous dezes selectionner un ficher";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}