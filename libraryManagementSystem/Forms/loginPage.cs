using SecurePassword;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }
        public static int ID;
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(
            "Data Source=KADIR;Initial Catalog=libraryManagement;Integrated Security=True");

        private void btnStuLog_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM studentLogin WHERE Username='" + txtStuUser.Text + "' AND Password='" + Encode_Decode.Encrypt(txtStuPass.Text) + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    ID = Convert.ToInt32(dt.Rows[0][0]);
                    dt.Rows.Clear();
                    dt.Columns.Clear();
                    stuMain frm = new stuMain();
                    frm.Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdmLog_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM admins WHERE Username='" + txtAdmUser.Text + "' AND Password='" + Encode_Decode.Encrypt(txtAdmPass.Text) + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    dt.Rows.Clear();
                    dt.Columns.Clear();
                    admMain frm = new admMain();
                    frm.Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
