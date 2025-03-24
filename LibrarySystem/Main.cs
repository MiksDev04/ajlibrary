using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Library1 library1 = new Library1();



        // =================== MEMBERS ===========================
        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = library1.FetchMember();
            dataGridView2.DataSource = library1.FetchAuthor();
            dataGridView3.DataSource = library1.FetchBook();
            dataGridView4.DataSource = library1.FetchBorrowingRecord();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            if (member_name.Text != "")
            {
                library1.InsertMember(member_name.Text);
                dataGridView1.DataSource = library1.FetchMember();
                EmptyInputs();
            }
            else
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateMemberBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string memberName = member_name.Text;
                library1.UpdateMember(id, memberName);
                dataGridView1.DataSource = library1.FetchMember();
                EmptyInputs();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteMemberBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    DialogResult = MessageBox.Show("Are you sure you want to permanently delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                        library1.DeleteMember(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                        dataGridView1.DataSource = library1.FetchMember();
                        EmptyInputs();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MemberID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            member_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void EmptyInputs()
        {
            member_name.Text = "";
            MemberID.Text = "";
            AuthorID.Text = "";
            AuthorName.Text = "";
        }





        // =================== AUTHORS ===========================


        private void AddAuthorBtn_Click(object sender, EventArgs e)
        {
            if (AuthorName.Text != "")
            {
                library1.InsertAuthor(AuthorName.Text);
                dataGridView2.DataSource = library1.FetchAuthor();
                EmptyInputs();
            }
            else
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAuthorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                library1.UpdateAuthor(id, AuthorName.Text);
                dataGridView2.DataSource = library1.FetchAuthor();
                EmptyInputs();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAuthorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    DialogResult = MessageBox.Show("Are you sure you want to permanently delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                        library1.DeleteAuthor(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                        dataGridView2.DataSource = library1.FetchAuthor();
                        EmptyInputs();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AuthorID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            AuthorName.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }


        // Books Functions
        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    DialogResult = MessageBox.Show("Are you sure you want to permanently delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                        library1.DeleteBook(Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value));
                        dataGridView3.DataSource = library1.FetchBook();
                        EmptyInputs();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);
                library1.UpdateBook(id, BookTiitle.Text, BookRating.Text, AuthorIDFK.Value.ToString());
                dataGridView3.DataSource = library1.FetchBook();
                EmptyInputs();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            if (BookTiitle.Text != "" && BookRating.Text != "" && AuthorIDFK.Value != 0)
            {
                library1.InsertBook(BookTiitle.Text , BookRating.Text, AuthorIDFK.Value.ToString());
                dataGridView3.DataSource = library1.FetchBook();
                EmptyInputs();
            }
            else
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BookID.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            BookTiitle.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            AuthorIDFK.Value = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[2].Value);
            BookRating.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void DeleteRecordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView4.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    DialogResult = MessageBox.Show("Are you sure you want to permanently delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                        library1.DeleteBorrowed(Convert.ToInt32(dataGridView4.SelectedRows[0].Cells[0].Value));
                        dataGridView4.DataSource = library1.FetchBorrowingRecord();
                        EmptyInputs();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRecordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView4.SelectedRows[0].Cells[0].Value);
                library1.UpdateBorrowed(id, BookIDFK.Text, MemberIDFK.Text, TimeBorrowed.Text, TimesBorrowed.Value.ToString());
                dataGridView4.DataSource = library1.FetchBorrowingRecord();
                EmptyInputs();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            if (BookIDFK.Text != "" && MemberIDFK.Text != "" && TimesBorrowed.Value != 0)
            {
                library1.InsertBorrowed(BookIDFK.Text, MemberIDFK.Text, TimeBorrowed.Text, TimesBorrowed.Value.ToString());
                dataGridView4.DataSource = library1.FetchBorrowingRecord();
                EmptyInputs();
            }
            else
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RecordID.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            BookIDFK.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            MemberIDFK.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
            TimeBorrowed.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
            TimesBorrowed.Value = Convert.ToInt32(dataGridView4.SelectedRows[0].Cells[4].Value);
        }
    }
}

