using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;
using System.Net;

namespace Sample
{
    public partial class frmSampleApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var vresult = new { FirstName = txtFirstName.Text, LastName = txtLastName.Text };
            var jsonresult = JsonConvert.SerializeObject(vresult);
            string filePath = Server.MapPath("~/Result/SampleOutput.json");

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine(Environment.NewLine + "----------- " + DateTime.Today.ToShortDateString() + "--------------");
                sw.WriteLine(jsonresult);
            }
            var fi = new FileInfo(filePath);
            Response.Clear();
            Response.ContentType = "application/octet-stream";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + fi.Name);
            Response.WriteFile(filePath);
            Response.End();

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
           
        }
        protected void btnClearAll_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

        }
    }
}