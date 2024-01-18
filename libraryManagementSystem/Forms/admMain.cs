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
using System.Windows.Forms.VisualStyles;

namespace libraryManagementSystem
{
    public partial class admMain : Form
    {
        public admMain()
        {
            InitializeComponent();
        }

        int ID = -1;
        SqlConnection conn = new SqlConnection(
            "Data Source=KADIR;Initial Catalog=libraryManagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        bool isLogged = false;
        //Student
        private void btnAddStuOp_Click(object sender, EventArgs e)
        {
            grpStuAdd.Visible = true;
            grpStuList.Visible = false;
            grpStuUptDel.Visible = false;
            grpAdmAdd.Visible = false;
            grpAdmUptDel.Visible = false;
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {

            if (txtStuAddPass.Text.Equals(txtStuAddConPass.Text))
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO students VALUES('"+ txtStuAddName.Text+"','"+ txtStuAddSname.Text+"','"+ dtpStuAddDOB.Value.ToString("yyyy-MM-dd")+"','"+ rdbStuAddMale.Checked+"')";
                    cmd.ExecuteNonQuery();
                    string query = "SELECT ID FROM students WHERE Name='" + txtStuAddName.Text + "' AND Surname='" + txtStuAddSname.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    sda.Fill(dt);
                    int IDadd = Convert.ToInt32(dt.Rows[0][0]);
                    dt.Rows.Clear();
                    dt.Columns.Clear();
                    cmd.CommandText = "INSERT INTO studentLogin VALUES('"+ IDadd+"','"+ txtStuAddUser.Text+"','"+ Encode_Decode.Encrypt(txtStuAddPass.Text)+"')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insertion successful.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Something went wrong.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Passwords are not match.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnStuList_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.libraryManagementDataSet.students);
            grpStuList.Visible = true;
            grpStuAdd.Visible = false;
            grpStuUptDel.Visible = false;
            grpAdmAdd.Visible = false;
            grpAdmUptDel.Visible = false;
        }

        private void txtStuListSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT * FROM students WHERE Name LIKE '%" + txtStuListSearch.Text + "%'";
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                dt.Rows.Clear();
                dt.Columns.Clear();
                sda.Fill(dt);
                conn.Close();
                dgvStuList.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Please choose a record.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnStuUptDelOp_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.libraryManagementDataSet.students);
            grpStuUptDel.Visible = true;
            grpStuAdd.Visible = false;
            grpStuList.Visible = false;
            grpAdmAdd.Visible = false;
            grpAdmUptDel.Visible = false;
        }

        private void btnStuUptGet_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvStuUptDel.Rows
              .Cast<DataGridViewRow>()
              .Where(r => r.Cells[0].Value.ToString().Equals(txtStuUptDelID.Text))
              .First();

            txtStuUptDelName.Text = row.Cells[1].Value.ToString();
            ID = Convert.ToInt32(txtStuUptDelID.Text);
            txtStuUptDelSname.Text = row.Cells[2].Value.ToString();
            dtpStuUptDelDOB.Text = row.Cells[3].Value.ToString();
            if (row.Cells[4].Value.ToString() == "True")
            {
                rdbStuUptDelMale.Checked = true;
            }
            else rdbStuUptDelFmale.Checked = true;

            string query = "SELECT Username FROM studentLogin WHERE StudentID='" + txtStuUptDelID.Text + "'";

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
                dt.Rows.Clear();
                dt.Columns.Clear();
                
                txtStuUptDelUser.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStuUptDel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtStuUptDelID.Text = dgvStuUptDel.Rows[rowIndex].Cells[0].Value.ToString();
            ID = Convert.ToInt32(txtStuUptDelID.Text);
            txtStuUptDelName.Text = dgvStuUptDel.Rows[rowIndex].Cells[1].Value.ToString();
            txtStuUptDelSname.Text = dgvStuUptDel.Rows[rowIndex].Cells[2].Value.ToString();
            dtpStuUptDelDOB.Text = dgvStuUptDel.Rows[rowIndex].Cells[3].Value.ToString();
            if (dgvStuUptDel.Rows[rowIndex].Cells[4].Value.ToString() == "True")
            {
                rdbStuUptDelMale.Checked = true;
            }
            else rdbStuUptDelFmale.Checked = true;
            string query = "SELECT Username FROM studentLogin WHERE StudentID='" + txtStuUptDelID.Text + "'";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                dt.Rows.Clear();
                dt.Columns.Clear();
                sda.Fill(dt);
                txtStuUptDelUser.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStuUpt_Click(object sender, EventArgs e)
        {
            if (rdbStuUptDelInfGen.Checked)
            {
                if (ID > -1)
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE students SET Name = '" + txtStuUptDelName.Text + "', Surname = '" + txtStuUptDelSname.Text + "', DOB='" + dtpStuUptDelDOB.Value.ToString("yyyy-MM-dd") + "', Gender='" + rdbStuUptDelMale.Checked + "' WHERE ID='" + txtStuUptDelID.Text + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update successful.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Record is not found.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    ID = -1;
                    this.studentsTableAdapter.Fill(this.libraryManagementDataSet.students);
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Please choose a record.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (ID > -1)
                {
                    try
                    {

                        string query = "SELECT Password FROM studentLogin WHERE StudentID='" + txtStuUptDelID.Text + "'";

                        SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                        dt.Rows.Clear();
                        dt.Columns.Clear();
                        sda.Fill(dt);
                        string password = dt.Rows[0][0].ToString();

                        if (Encode_Decode.Decrypt(password).Equals(txtStuUptDelOpass.Text))
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.CommandText = "UPDATE studentLogin SET Username = '" + txtStuUptDelUser.Text + "', Password='" + Encode_Decode.Encrypt(txtStuUptDelNpass.Text) + "' WHERE StudentID='" + txtStuUptDelID.Text + "'";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Update successful.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ID = -1;
                        }
                        else MessageBox.Show("Password is incorrect.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Something went wrong.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a record.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }

        private void btnStuDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ID.ToString());
            if (ID > -1)
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM students WHERE ID = '"+ID+"'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deletion successful.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Record is not found.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                this.studentsTableAdapter.Fill(this.libraryManagementDataSet.students);
                ID = -1;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please choose a record.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void rdbStuUptDelInfGen_MouseClick(object sender, MouseEventArgs e)
        {
            grpStuUptDelGen.Visible = true;
            lblStuUptDelOpass.Visible = false;
        }

        private void rdbStuUptDelInfAut_MouseClick(object sender, MouseEventArgs e)
        {
            grpStuUptDelGen.Visible = false;
            lblStuUptDelOpass.Visible = true;
        }

        //Admin
        private void btnAdmAddOp_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.libraryManagementDataSet.students);
            grpAdmAdd.Visible = true;
            grpStuUptDel.Visible = false;
            grpStuAdd.Visible = false;
            grpStuList.Visible = false;
            grpAdmUptDel.Visible = false;
        }

        private void btnAdmAdd_Click(object sender, EventArgs e)
        {
            if (txtAdmAddPass.Text.Equals(txtAdmAddConPass.Text))
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO admins VALUES('"+ txtAdmAddUser.Text+"','"+ Encode_Decode.Encrypt(txtAdmAddPass.Text) + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Insertion successful.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Something went wrong.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Passwords are not match.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdmUptDelOp_Click(object sender, EventArgs e)
        {
            grpAdmUptDel.Visible = true;
            grpStuAdd.Visible = false;
            grpStuList.Visible = false;
            grpStuUptDel.Visible = false;
            grpAdmAdd.Visible = false;
        }

        private void btnAdmUpt_Click(object sender, EventArgs e)
        {

            if (isLogged)
            {
                try
                {

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE admins SET Username = '" + txtAdmUptDelNUser.Text + "', Password='" + Encode_Decode.Encrypt(txtStuUptDelNpass.Text) + "' WHERE Username = '" + txtAdmUptDelOUser.Text + "' AND Password='" + Encode_Decode.Encrypt(txtAdmUptDelOpass.Text) + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successful.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Record is not found.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else MessageBox.Show("Password is incorrect.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAdmDel_Click(object sender, EventArgs e)
        {

            if (isLogged)
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM admins WHERE Username='"+ txtAdmUptDelNUser.Text+"'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deletion successful.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Record is not found.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            else MessageBox.Show("Password is incorrect.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            admBook frm = new admBook();
            frm.Show();
            this.Dispose();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginPage frm = new loginPage();
            frm.Show();
            this.Dispose();
        }

        private void txtAdmUptDelNUser_Enter(object sender, EventArgs e)
        {

            toolTip1.Show("If you don't want to change your Username, rewrite the old one.", txtAdmUptDelNUser, 10000);
        }

        private void btnAdmUptDelLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM admins WHERE Username='" +txtAdmUptDelOUser.Text + "' AND Password='" + Encode_Decode.Encrypt(txtAdmUptDelOpass.Text) + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable tb = new DataTable();
                sda.Fill(tb);
                if (tb.Rows.Count == 1)
                {
                    toolTip1.Show("Log in Success.", btnAdmUptDelLogIn, 5000);
                    isLogged = true;
                    conn.Close();
                }
                else
                {
                    toolTip1.Show("Log in failed.", btnAdmUptDelLogIn, 5000);
                    conn.Close();
                }
            }
            catch (Exception)
            {

                toolTip1.Show("Something went wrong.", btnAdmUptDelLogIn, 5000);
            }
        }

        private void txtStuUptDelUser_Enter(object sender, EventArgs e)
        {
            toolTip1.Show("You can change the username, if you want", txtStuUptDelUser, 5000);
        }

        private void btnAdmDel_Enter(object sender, EventArgs e)
        {
            toolTip1.Show("After logging in, write Username which will be deleted to new Username.", btnAdmDel, 5000);
        }

        
    }
    
}
