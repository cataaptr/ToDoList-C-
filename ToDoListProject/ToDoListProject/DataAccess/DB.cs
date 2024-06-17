using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ServiceStack.OrmLite;
using System.Data.SQLite;
using Microsoft.VisualBasic.ApplicationServices;

namespace ToDoListProject.DataAccess
{
    public class DB

    {

    }
}
        /*
       
        public static void apel(TextBox TextBox1)
        {
            SQLiteConnection sqliteConnection;
            var users = new List<User>();
            try
            {
                sqliteConnection = CreateConnection(TextBox1);
                users = ReadUserData(sqliteConnection); 

                
                foreach (var user in users)
                {
                    TextBox1.AppendText($"User ID: {user.UserId}, First Name: {user.FirstName}, Last Name: {user.LastName}, Email: {user.Email}, Phone Number: {user.PhoneNumber}\r\n");
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Eroare în timpul citirii datelor din baza de date: {ex.Message}");
            }


            foreach (var user in users)
            {
                TextBox1.AppendText($"User ID: {user.UserId}, First Name: {user.FirstName}, Last Name: {user.LastName}, Email: {user.Email}, Phone Number: {user.PhoneNumber}\r\n");
            }
        }


        static SQLiteConnection CreateConnection(TextBox textBox)
        {
            SQLiteConnection sqliteConn;
            sqliteConn = new SQLiteConnection("Data Source=sqlite.db; Version = 3; New = True; Compress = True;");
            try
            {
                sqliteConn.Open();
                if (sqliteConn.State == ConnectionState.Open)
                {
                    textBox.AppendText("Conexiunea la baza de date SQLite a fost stabilită cu succes!\r\n");
                }
                else
                {
                    textBox.AppendText("Conexiunea la baza de date SQLite nu a putut fi stabilită.\r\n");
                }
            }
            catch (Exception ex)
            {
                textBox.AppendText("Eroare la crearea conexiunii la baza de date SQLite: " + ex.Message + "\r\n");
            }
            return sqliteConn;
        }

        public static void ReadData(SQLiteConnection conn, TextBox textBox)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "SELECT * FROM taskuri"; 
            sqliteReader = sqliteCommand.ExecuteReader();
            while (sqliteReader.Read())
            {
                
                int id = sqliteReader.GetInt32(0);
                string description = sqliteReader.GetString(1);
                int categoryId = sqliteReader.GetInt32(2);
                DateTime startDate = sqliteReader.GetDateTime(3);
                DateTime endDate = sqliteReader.GetDateTime(4);
                bool done = sqliteReader.GetBoolean(5);

                string result = $"ID: {id}, Description: {description}, CategoryId: {categoryId}, StartDate: {startDate}, EndDate: {endDate}, Done: {done}\r\n";
                
                textBox.AppendText(result);
            }
            conn.Close();
        }

        public static List<User> ReadUserData(SQLiteConnection conn)
        {
            List<User> users = new List<User>();

            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "SELECT * FROM utilizator";
            sqliteReader = sqliteCommand.ExecuteReader();
            while (sqliteReader.Read())
            {
                int userId = sqliteReader.GetInt32(0);
                string firstName = sqliteReader.GetString(1);
                string lastName = sqliteReader.GetString(2);
                string email = sqliteReader.GetString(3);
                string phoneNumber = sqliteReader.GetString(4);

                User user = new User(userId, firstName, lastName, email, phoneNumber);
                users.Add(user);
            }
            conn.Close();

            return users;
        }
        public static void PullData()
        {
            string connString = "Data Source=sqlite.db;Version=3;";
            string query = "SELECT * FROM taskuri";

            SQLiteConnection conn = new SQLiteConnection(connString);
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();
        }

    }
}

    /*  private static IDbConnection _db;
      public static Exception Exception;

      public static IDbConnection GetInstance()
      {
          var dbFactory = new OrmLiteConnectionFactory(
              "Data Source=cati.db;version=3;", SqliteDialect.Provider);

          try
          {
              if(_db == null)
              {
                  _db = dbFactory.Open();
                  Migrate();
              }
              if(_db.State == ConnectionState.Broken || _db.State== ConnectionState.Closed)
                  _db = dbFactory.Open();

              return _db;
          }
          catch (Exception e)
          {
              Exception = e;
              return null;
          }
      }

      public static void Migrate()
      {
          var db=GetInstance();

          if(db.CreateTableIfNotExists<Category>())
          {
              db.Save(new Category() { CategoryName = "Personal" });
              db.Save(new Category() { CategoryName = "Shopping" });
              db.Save(new Category() { CategoryName = "Work" });
              db.Save(new Category() { CategoryName = "Projects" });

          }

          if(db.CreateTableIfNotExists<Task>())
          {
              db.Save(new Task()
              {
                  CategoryId = 1,
                  Description="Check the to do item to mark it complete"
              });
              db.Save(new Task()
              {
                  CategoryId = 1,
                  Description = "Check the to do item to mark it complete"
              });
              db.Save(new Task()
              {
                  CategoryId = 1,
                  Description = "Check the to do item to mark it complete"
              });

          }
      } 


        */