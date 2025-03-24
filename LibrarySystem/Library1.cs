using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection;

namespace LibrarySystem
{
    public class Library1
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ajdatabase;";



        // =============================  MEMBERS  =============================
        public DataTable FetchMember()
        {
            var result = new DataTable();
            // Select all
            string query = @"SELECT * from members";
            try
            {
               
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(result);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            
            
            return result;
        }

        public void InsertMember(string member_name)
        {
            string query = "INSERT INTO members (member_name) VALUES (@MemberName)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberName", member_name);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UpdateMember(int id, string Name)
        {
            string query = "UPDATE members SET member_name = @Name WHERE member_id = @id";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteMember(int id)
        {
            string query = "Delete From members WHERE member_id = @id;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        // =============================  AUTHORS  =============================
        public DataTable FetchAuthor()
        {
            var result = new DataTable();
            // Select all
            string query = @"SELECT * from authors";
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            return result;
        }


        public void InsertAuthor(string name)
        {
            string query = "INSERT INTO authors (author_name) VALUES (@AuthorName)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AuthorName", name);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UpdateAuthor(int id, string Name)
        {
            string query = "UPDATE authors SET author_name = @Name WHERE author_id = @id";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteAuthor(int id)
        {
            string query = "Delete From authors WHERE author_id = @id;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }   

        // =============================  BOoks  =============================
        public DataTable FetchBook()
        {
            var result = new DataTable();
            // Select all
            string query = @"SELECT * from books";
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            return result;
        }


        public void InsertBook(string bookTitle , string bookRating, string authorID)
        {
            string query = "INSERT INTO books (book_title, author_id, book_rating) VALUES (@BookTitle, @AuthorID, @BookRating)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookTitle", bookTitle);
                        command.Parameters.AddWithValue("@AuthorID", Convert.ToInt32(authorID));
                        command.Parameters.AddWithValue("@Bookrating", bookRating);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateBook(int BookId, string bookTitle, string bookRating, string authorID)
        {
            string query = "UPDATE books SET book_title = @BookTitle, author_id = @AuthorID, book_rating = @BookRating WHERE book_id = @BookID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookTitle", bookTitle);
                        command.Parameters.AddWithValue("@AuthorID", Convert.ToInt32(authorID));
                        command.Parameters.AddWithValue("@Bookrating", bookRating);
                        command.Parameters.AddWithValue("@BookID", Convert.ToInt32(BookId));
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteBook(int id)
        {
            string query = "Delete From books WHERE book_id = @id;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // =============================  BORROwing records  =============================
        public DataTable FetchBorrowingRecord()
        {
            var result = new DataTable();
            // Select all
            string query = @"SELECT * from borrowingrecords";
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            return result;
        }


        public void InsertBorrowed(string BookIDFK, string MemberIDFK, string TimeBorrowed, string TimesBorrowed)
        {
            string query = "INSERT INTO borrowingrecords (book_id, member_id, time_borrowed, times_borrowed) VALUES (@BookIDFK, @MemberIDFK, @TimeBorrowed, @TimesBorrowed)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookIDFK", Convert.ToInt32(BookIDFK));
                        command.Parameters.AddWithValue("@MemberIDFK", Convert.ToInt32(MemberIDFK));
                        command.Parameters.AddWithValue("@TimeBorrowed", Convert.ToDateTime(TimeBorrowed));
                        command.Parameters.AddWithValue("@TimesBorrowed", Convert.ToInt32(TimesBorrowed));
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateBorrowed(int id, string BookIDFK, string MemberIDFK, string TimeBorrowed, string TimesBorrowed)
        {
            string query = "UPDATE borrowingrecords SET book_id = @BookIDFK, member_id = @MemberIDFK, time_borrowed = @TimeBorrowed, times_borrowed = @TimesBorrowed WHERE record_id = @RecordID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookIDFK", Convert.ToInt32(BookIDFK));
                        command.Parameters.AddWithValue("@MemberIDFK", Convert.ToInt32(MemberIDFK));
                        command.Parameters.AddWithValue("@TimeBorrowed", Convert.ToDateTime(TimeBorrowed));
                        command.Parameters.AddWithValue("@TimesBorrowed", Convert.ToInt32(TimesBorrowed));
                        command.Parameters.AddWithValue("@RecordID", Convert.ToInt32(id));
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteBorrowed(int id)
        {
            string query = "Delete From borrowingrecords WHERE record_id = @id;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}








