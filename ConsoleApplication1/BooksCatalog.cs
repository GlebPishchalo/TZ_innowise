using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class BooksCatalog
    {
        public BooksCatalog()
        {

        }
        //public void LoadData()
        //{
        //    string connectString = @"Data Source=(local);Initial Catalog=BooksCatalog;Integrated Security=True";

        //    SqlConnection myConnection = new SqlConnection(connectString);

        //    myConnection.Open();
        //    {
        //        //  SqlCommand command = new SqlCommand("SELECT * FROM Authors INNER JOIn  BAConnect inner join books on BAConnect.Book_id = Books.Book_id ON Authors.Author_ID = BAConnect.Author_ID");
        //        string query = "SELECT Books.book_id,book_name,YEAR,author_name,Authors.author_id FROM Authors INNER JOIn  BAConnect inner join books on BAConnect.Book_id=Books.Book_id ON Authors.Author_ID = BAConnect.Author_ID";
        //        SqlCommand command = new SqlCommand(query, myConnection);

        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.HasRows) // если есть данные
        //        {
                    
        //            // Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4), reader.GetName(5), reader.GetName(6));



        //            while (reader.Read()) // построчно считываем данные
        //            {
        //                object Book_ID = reader.GetValue(0);
        //                object Book_name = reader.GetValue(1);
        //                object Year = reader.GetValue(2);
        //                object Author_name = reader.GetValue(3);
        //                object Author_id = reader.GetValue(4);
        //                ;

        //                Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3], reader[4]);

        //            }
        //        }


        //        reader.Close();

        //        myConnection.Close();

        //        Console.ReadKey();
        //    }
        //}
        public void LoadBooks()
        {
            string connectString = @"Data Source=(local);Initial Catalog=BooksCatalog;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();
            {
                string query = "SELECT Distinct * from Books";
                SqlCommand command = new SqlCommand(query, myConnection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object Book_ID = reader.GetValue(0);
                        object Book_name = reader.GetValue(1);
                        object Year = reader.GetValue(2);
                        Console.WriteLine("{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);

                    }
                }


                reader.Close();

                myConnection.Close();

             //   Console.ReadKey();
            }
        }
        public void LoadAuthors()
        {
            string connectString = @"Data Source=(local);Initial Catalog=BooksCatalog;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();
            {
                string query = "SELECT * from Authors";
                SqlCommand command = new SqlCommand(query, myConnection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {
                        object Book_ID = reader.GetValue(0);
                        object Book_name = reader.GetValue(1);
                        Console.WriteLine("{0}\t{1}", reader[0], reader[1]);

                    }
                }


                reader.Close();

                myConnection.Close();

//                Console.ReadKey();
            }
        }
        public int DeleteBook(int b)
        {
            string connectString = @"Data Source=(local);Initial Catalog=BooksCatalog;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();
            {
                
                    string query = "Delete from Books where Books.book_id=" + b + "";
                    SqlCommand command = new SqlCommand(query, myConnection);
                    myConnection.Close();

                Console.ReadKey();
            }
            return b;
        }

        public int FindBooks(int a)
        {
            string connectString = @"Data Source=(local);Initial Catalog=BooksCatalog;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();
            {
                string query = "SELECT Books.book_id,book_name,YEAR FROM Authors INNER JOIn  BAConnect inner join books on BAConnect.Book_id=Books.Book_id ON Authors.Author_ID = BAConnect.Author_ID where Authors.author_id =" + a + "";
                SqlCommand command = new SqlCommand(query, myConnection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object Author_ID = reader.GetValue(0);
                        object Author_name = reader.GetValue(1);

                    }
                }


                reader.Close();

                myConnection.Close();

     //           Console.ReadKey();
            }
            return a;

        }
        public int InsertBook(string b,int c)
        {
            string connectString = @"Data Source=(local);Initial Catalog=BooksCatalog;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();
            {

                string query = "insert into Books(book_name,year) values ('" + b + "'," + c + ")";
               //     + "insert into Authors(author_name) values ('" + d + "')"
              //      + "insert into BAConnect(book_id,author_id) values(SELECT TOP 1 book_id FROM Books ORDER BY book_id DESC,SELECT TOP 1 author_id FROM Authors ORDER BY book_id DESC)";
                SqlCommand command = new SqlCommand(query, myConnection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {
                        object Author_ID = reader.GetValue(0);
                        object Author_name = reader.GetValue(1);
                        Console.WriteLine("{0}\t{1}", reader[0], reader[1]);

                    }
                }
                reader.Close();
                myConnection.Close();
     //           Console.ReadKey();
            }
            return c;
        }

        public string InsertAuthors(string d)
        {
            string connectString = @"Data Source=(local);Initial Catalog=BooksCatalog;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();
            {

                string query =
                    "insert into Authors(author_name) values ('" + d + "')";
                 //   + " insert into BAConnect(book_id,author_id) values(SELECT TOP 1 book_id FROM Books ORDER BY book_id DESC,SELECT TOP 1 author_id FROM Authors ORDER BY book_id DESC)";
                SqlCommand command = new SqlCommand(query, myConnection);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object Author_ID = reader.GetValue(0);
                        object Author_name = reader.GetValue(1);

                    }
                }
                reader.Close();

                myConnection.Close();

    //            Console.ReadKey();
            }
            return d;
        }
        public string InsertBA()
        {
            string connectString = @"Data Source=(local);Initial Catalog=BooksCatalog;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();
            {
     
                string query ="insert into BAConnect(book_id,author_id) values((SELECT TOP 1 book_id FROM Books ORDER BY book_id DESC),(SELECT TOP 1 author_id FROM Authors ORDER BY author_id DESC))";
                SqlCommand command = new SqlCommand(query, myConnection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object Author_ID = reader.GetValue(0);
                        object Author_name = reader.GetValue(1);
                       // Console.WriteLine("{0}\t{1}", reader[0], reader[1]);

                    }
                }


                reader.Close();

                myConnection.Close();

   //             Console.ReadKey();
            }
            return null;
        }
    }

}
