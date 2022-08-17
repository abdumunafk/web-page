using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace WebApplication1
{
    public partial class FirstWebPage : System.Web.UI.Page
    {
        public object Passwrd { get; private set; }

        /// <summary>
        /// private object sda;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void Page_Load(object sender, EventArgs e)
        {
            // this.Hide();
        }
        static void Main()
        {
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Distinct * from tblUses where username='" + TxtUsername.Text + "' OR Password='" + TxtPassword.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //sda.Dispose();
                //Text box value assign to string.
                string username, password;
                username = TxtUsername.Text;
                password = TxtPassword.Text;
                //Array index of rows in datatable
                if (dt.Rows.Count > 0)
                {
                    string DTUsername = dt.Rows[0]["Username"].ToString();//using database table for username to string calling rows
                    string DTPassword = dt.Rows[0]["Password"].ToString();//using database table for Password to string calling rows

                    //if username and password is null 
                    if (username == "" && password == "")
                    {
                        lblstatus.Visible = true;
                        lblstatus.Text = "Enter the Username/Password";

                    }
                    else
                    {
                        //username is null then it output is 
                        if (username == "")
                        {
                            lblstatus.Visible = true;
                            lblstatus.Text = "Enter your username";
                        }
                        else
                        {
                            //username is not null call this else statement
                            if (username != DTUsername)
                            {
                                lblstatus.Visible = true;
                                lblstatus.Text = "User Nmae is not Valid!";
                                //
                            }
                            else
                            {
                                //password is null 
                                if (password == "")
                                {
                                    lblstatus.Visible = true;
                                    lblstatus.Text = "Enter your Password";
                                }
                                else
                                {
                                    //password is not null call this else statement
                                    if (DTPassword != password)
                                    {
                                        lblstatus.Visible = true;
                                        lblstatus.Text = "User Password is not Valid!";
                                    }
                                    else
                                    {
                                        lblstatus.Visible = true;
                                        lblstatus.Text = "Login Successfull";
                                    }
                                }
                            }


                        }
                    }
                }

                //}
                else
                {
                    lblstatus.Visible = true;
                    lblstatus.Text = "Enter the Username/Password";
                    //Response.Write("Login Failed!");

                }

            }
            catch (Exception ex)
            {
                // Response.Write(ex.Message);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Oops!! following error occured : " + ex.Message.ToString() + "');", true);
            }
            //finally
            //{
            //    DataTable dt = new DataTable();
            //    dt.Clear();
            //    dt.Dispose();
            //    //Console.Write("Login Successfull");
            //}
            Response.Redirect("Registerform.aspx");
        }

        // Response.Redirect("Registerform.aspx");
    }

}