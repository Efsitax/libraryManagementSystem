using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementSystem
{
    public partial class stuMain : Form
    {
        public stuMain()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(
            "Data Source=KADIR;Initial Catalog=libraryManagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        static int StuID, ID = -1,count=0;
        bool isReturned=false;

        private void stuMain_Load(object sender, EventArgs e)
        {
            
            this.booksTableAdapter.Fill(this.libraryManagementDataSet.books);
            try
            {
                StuID = loginPage.ID;
                string query = "SELECT isReturned FROM booktransfer WHERE StudentID = '" + StuID + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                dt.Rows.Clear();
                dt.Columns.Clear();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    bool isReturned = Convert.ToBoolean(dt.Rows[i][0]);
                    if (!isReturned) count++;
                    else continue;
                }
                if (count > 0)
                {
                    MessageBox.Show("You have " + count.ToString() + " books to return.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count = 0;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnStuGetBook_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.libraryManagementDataSet.books);
            grpStuGetBook.Visible = true;
            grpStuReturnBook.Visible = false;
        }

        private void txtGetBookListSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM books WHERE Name LIKE '%" + txtGetBookListSearch.Text + "%'";
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                dt.Rows.Clear();
                dt.Columns.Clear();
                sda.Fill(dt);
                conn.Close();
                dgvGetBookList.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Please choose a record.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgvGetBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            ID = Convert.ToInt32(dgvGetBookList.Rows[rowIndex].Cells[0].Value);
            txtGetBookName.Text = dgvGetBookList.Rows[rowIndex].Cells[1].Value.ToString();
            txtGetBookAuthor.Text = dgvGetBookList.Rows[rowIndex].Cells[2].Value.ToString();
            txtGetBookKind.Text = dgvGetBookList.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void btnGetBook_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                DateTime dateTime = DateTime.Now;
                if (ID > -1)
                {
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO booktransfer VALUES('"+ ID + "','"+ StuID+"','"+ dateTime.ToString("yyyy-MM-dd")+"','"+0+"')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("The book has been received.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a book.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else MessageBox.Show("You can have at most 3 books.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnStuReturnBook_Click(object sender, EventArgs e)
        {
            refreshList();
            grpStuReturnBook.Visible = true;
            grpStuGetBook.Visible = false;
        }
        public void refreshList()
        {
            try
            {
                string query = "SELECT BT.ID, B.Name AS 'Book Name', B.AuthorName AS 'Author', B.Kind, BT.BookGiven AS 'Book Given', BT.isReturned 'Returned' FROM booktransfer BT INNER JOIN books B ON BT.BookID = B.ID WHERE BT.StudentID='" + StuID + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                dt.Rows.Clear();
                dt.Columns.Clear();
                sda.Fill(dt);
                conn.Close();
                dgvReturnBookList.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReturnBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            ID = Convert.ToInt32(dgvReturnBookList.Rows[rowIndex].Cells[0].Value);
            txtReturnBookName.Text = dgvReturnBookList.Rows[rowIndex].Cells[1].Value.ToString();
            txtReturnBookAuthor.Text = dgvReturnBookList.Rows[rowIndex].Cells[2].Value.ToString();
            txtReturnBookKind.Text = dgvReturnBookList.Rows[rowIndex].Cells[3].Value.ToString();
            isReturned = Convert.ToBoolean(dgvReturnBookList.Rows[rowIndex].Cells[5].Value);
        }

       

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (!isReturned)
            {
                if (ID > -1)
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Library Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.CommandText = "UPDATE booktransfer SET isReturned = '1' WHERE ID='" + ID + "'";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("The Book is Returned.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Record is not found.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                        ID = -1;
                        conn.Close();
                        refreshList();
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a book.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else MessageBox.Show("This book is already returned", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginPage.ID = -1;
            loginPage frm = new loginPage();
            frm.Show();
            this.Dispose();
        }
    }
}
