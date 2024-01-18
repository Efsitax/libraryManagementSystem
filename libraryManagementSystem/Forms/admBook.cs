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
    public partial class admBook : Form
    {
        public admBook()
        {
            InitializeComponent();
        }

        int ID = -1;
        SqlConnection conn = new SqlConnection(
            "Data Source=KADIR;Initial Catalog=libraryManagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        private void btnBookAddOp_Click(object sender, EventArgs e)
        {
            grpBookAdd.Visible = true;
            grpBookList.Visible = false;
            grpBookUptDel.Visible = false;
            grpBookTList.Visible = false;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO books VALUES('"+ txtBookAddName.Text+"','"+ txtBookAddAuthor.Text+"','"+ txtBookAddKind.Text+"')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Insertion successful.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBookListOp_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.libraryManagementDataSet.books);
            grpBookList.Visible = true;
            grpBookAdd.Visible = false;
            grpBookUptDel.Visible = false;
            grpBookTList.Visible = false;
        }

        private void txtBookListSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM books WHERE Name LIKE '%" + txtBookListSearch.Text + "%'";
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                dt.Rows.Clear();
                dt.Columns.Clear();
                sda.Fill(dt);
                conn.Close();
                dgvBookList.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookUptDelOp_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.libraryManagementDataSet.books);
            grpBookUptDel.Visible = true;
            grpBookAdd.Visible = false;
            grpBookList.Visible = false;
            grpBookTList.Visible = false;
        }

        private void btnBookUptDelGet_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvBookUptDel.Rows
             .Cast<DataGridViewRow>()
             .Where(r => r.Cells[0].Value.ToString().Equals(txtBookUptDelID.Text))
             .First();

            txtBookUptDelName.Text = row.Cells[1].Value.ToString();
            ID = Convert.ToInt32(txtBookUptDelID.Text);
            txtBookUptDelAuthor.Text = row.Cells[2].Value.ToString();
            txtBookUptDelKind.Text = row.Cells[3].Value.ToString();
        }

        private void dgvBookUptDel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtBookUptDelID.Text = dgvBookUptDel.Rows[rowIndex].Cells[0].Value.ToString();
            ID = Convert.ToInt32(txtBookUptDelID.Text);
            txtBookUptDelName.Text = dgvBookUptDel.Rows[rowIndex].Cells[1].Value.ToString();
            txtBookUptDelAuthor.Text = dgvBookUptDel.Rows[rowIndex].Cells[2].Value.ToString();
            txtBookUptDelKind.Text = dgvBookUptDel.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void btnBookUpt_Click(object sender, EventArgs e)
        {

            if (ID > -1)
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE books SET Name = '" + txtBookUptDelName.Text + "', Author = '" + txtBookUptDelAuthor.Text + "', Kind='" + txtBookUptDelKind.Text + "' WHERE ID='" + txtBookUptDelID.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successful.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Record is not found.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
                ID = -1;
                this.booksTableAdapter.Fill(this.libraryManagementDataSet.books);
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please choose a record.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnBookDel_Click(object sender, EventArgs e)
        {
            if (ID > -1)
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM books WHERE ID = '"+ID+"'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deletion successful.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Record is not found.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                this.booksTableAdapter.Fill(this.libraryManagementDataSet.books);
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please choose a record.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnBookTListOp_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT BT.ID, B.Name AS 'Book Name', S.Name AS 'Student Name', S.Surname AS 'Student Surname', BT.BookGiven AS 'Book Given', BT.isReturned AS 'Returned' FROM booktransfer BT INNER JOIN books B ON BT.BookID = B.ID INNER JOIN students S ON BT.StudentID = S.ID";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                dt.Rows.Clear();
                dt.Columns.Clear();
                sda.Fill(dt);
                conn.Close();
                dgvBookTList.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            grpBookTList.Visible = true;   
            grpBookAdd.Visible = false;
            grpBookList.Visible = false;
            grpBookUptDel.Visible = false;
        }

        private void txtBookTListSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT BT.ID, B.Name AS 'Book Name', S.Name AS 'Student Name', S.Surname AS 'Student Surname' , BT.BookGiven AS 'Book Given', BT.isReturned AS 'Returned' FROM booktransfer BT INNER JOIN books B ON BT.BookID = B.ID INNER JOIN students S ON BT.StudentID = S.ID WHERE S.Name LIKE '%" + txtBookTListSearch.Text+"%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                dt.Rows.Clear();
                dt.Columns.Clear();
                sda.Fill(dt);
                conn.Close();
                dgvBookTList.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            admMain frm = new admMain();
            frm.Show();
            this.Dispose();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginPage frm = new loginPage();
            frm.Show();
            this.Dispose();
        }

 
    }
}
