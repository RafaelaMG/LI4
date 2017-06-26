using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Data;
using System.Data.SqlClient;


namespace Ambrosiov3
{
    class BD
    {
        private SqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
    


        public void connect()
        {
            server = "127.0.0.1:3306";
            database = "Li4";
            uid = "root";
            password = "";
           
            string connString;
            connString = $"SERVER={server};DATABASE={database};UID{uid};PASSWORD={password};";
            connection = new SqlConnection(connString);
        }


       
        public bool Register(string user, string pass)
        {
            string query = $"INSERT INTO cliente (id, Nome, Email, Telemovel, Password) VALUES ('','{user}', '','','{pass}')";
            try
            {
                if (OpenConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    } catch (Exception ex)
                    {
                        return false;
                    }
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }catch(Exception ex)
            {
                connection.Close();
                return false;
            }
        }


        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            } catch(SqlException er)
            {
                switch (er.Number)
                {
                    case 0:
                    Console.WriteLine("Connection to server failed!");
                        break;

                    case 1045:
                        Console.WriteLine("Server user or pass incorrect!");
                        break;
                }
                return false;
            }
            

           
        }

        public bool isLogin(string user, string pass)
        {
            string query = $"SELECT * FROM cliente WHERE Nome='{user}' AND Password='{pass}';";

            try
            {
                if (OpenConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                        return false;
                    }
                }
                else
                {
                    connection.Close();
                    return false;
                }
                } catch(Exception ex)
            {
                connection.Close();
                return false;
            }
                
            }
        }


    }
    
