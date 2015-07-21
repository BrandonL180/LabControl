using login.Account.App_Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace login.Data
{
    public class DataUser : DataBase
    {


        public List<User> readUser() {

            List<User> userList = new List<User>();
            User user = new User();

              //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            string databaseCommand = "SELECT * FROM Usuario";
            try
            {

                sqlCommand = new SqlCommand(databaseCommand, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {

                    user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    user.Name = reader.GetString(reader.GetOrdinal("nombre"));
                    user.Email = reader.GetString(reader.GetOrdinal("correo"));
                    user.StudentId = reader.GetInt32(reader.GetOrdinal("carnet"));
                    user.Password = reader.GetString(reader.GetOrdinal("clave"));
                    user.Role = reader.GetInt32(reader.GetOrdinal("idRol"));

                    userList.Add(user);                      
                }
                sqlCommand.Dispose();
                DatabaseConnection("close");        

            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());

            }
            return userList;
        }

        public User getUserData(string nombre, string clave)
        {

            User user = new User();


            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            string databaseCommand = "SELECT id, nombre, correo, carnet, clave, idRol FROM Usuario WHERE nombre = '" + nombre + "' AND clave = '" + clave + "'";
            try
            {

                sqlCommand = new SqlCommand(databaseCommand, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {

                    user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    user.Name = reader.GetString(reader.GetOrdinal("nombre"));
                    user.Email = reader.GetString(reader.GetOrdinal("correo"));
                    user.StudentId = reader.GetInt32(reader.GetOrdinal("carnet"));
                    user.Password = reader.GetString(reader.GetOrdinal("clave"));
                    user.Role = reader.GetInt32(reader.GetOrdinal("idRol"));

                }
                sqlCommand.Dispose();
                DatabaseConnection("close");


            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());

            }
            return user;
        }

        public void updatePassword(User user)
        {
            //open database connection
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            string databaseCommand = "UPDATE Usuario SET clave = '" + user.Password + "' WHERE id =" + user.Id + " AND nombre = '" + user.Name + "' AND correo = '" + user.Email + "' AND carnet = " + user.StudentId + " AND idRol = " + user.Role + "";
            try
            {

                sqlCommand = new SqlCommand(databaseCommand, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
                DatabaseConnection("close");
            }

            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }
        }

        public void insertUser(string name, string email, int studenId, string password, int role)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            string databaseCommand = "INSERT INTO Usuario(nombre,correo,carnet,clave,idRol) VALUES ('" + name + "', '" + email + "', " + studenId + ", '" + password + "' , " + role + ")";
            try
            {

                sqlCommand = new SqlCommand(databaseCommand, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
                DatabaseConnection("close");
            }

            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }
        }

        public void deleteUser(User user)
        {
            SqlConnection con = DatabaseConnection("open");
            SqlCommand sqlCommand;
            string databaseCommand = "DELETE FROM Usuario WHERE id ="+user.Id+" AND nombre = '"+user.Name+"' AND correo = '"+user.Email+"' AND carnet = "+user.StudentId+" AND clave = '"+user.Password+"' AND idRol = "+user.Role+"";
            try
            {

                sqlCommand = new SqlCommand(databaseCommand, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();
                DatabaseConnection("close");
            }

            catch (SqlException sqlException)
            {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }

        }





    }
}
