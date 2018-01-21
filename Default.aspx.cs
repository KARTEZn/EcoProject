using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string DefaultFileName = "Upload/";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void UploadButton_Click(object sender, EventArgs e)
    {
        if (FileUploader.HasFile)
            try
            {
                FileUploader.SaveAs(Server.MapPath(DefaultFileName) +
                     FileUploader.FileName);
                Label1.Text = "File name: " +
                     FileUploader.PostedFile.FileName + "<br>" +
                     FileUploader.PostedFile.ContentLength + " kb<br>" +
                     "Content type: " +
                     FileUploader.PostedFile.ContentType + "<br><b>Uploaded Successfully";
            }
            catch (Exception ex)
            {
                Label1.Text = "ERROR: " + ex.Message.ToString();
            }
        else
        {
            Label1.Text = "You have not specified a file.";
        }
    }
}