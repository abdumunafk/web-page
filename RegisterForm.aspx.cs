using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
     //       SqlConnection con = new SqlConnection("Data Source=DESKTOP-JQTO4HQ\\SQLEXPRESS;Initial Catalog=RegDB;Integrated Security=True");
     //       SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[tblReg]
     //      ([Username]
     //      ,[Password]
     //      ,[Mobile Number]
     //      ,[Mail])
     //VALUES
     //      ('"+TxtUsername+"','"+TxtPassword+"','"+TxtMobileNumber+"','"+TxtMail+"')",con);
     //       con.Open();
     //       cmd.ExecuteNonQuery();
     //       con.Close();
     //       Response.Write("<script>alert('user is register successfully')</script>");
        }
    }
}