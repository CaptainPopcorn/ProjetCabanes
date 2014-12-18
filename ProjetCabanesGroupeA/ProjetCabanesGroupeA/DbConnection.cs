using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Windows.Forms;
using System.Collections;


namespace System.ProjetCabanesGroupeA
{
    public struct TCabane
    {
        public int idCabane;
        public string nomCabane;
        public int altitude;
        public int nombreLit;
        public bool douche;
        public string tarif;
        public int idVisite;
        public string Nom()
        {
            return nomCabane;
        }
    }
    class DbConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DbConnection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";       //"cfpi-r123pc01";
            database = "cabanes";       //"cabane_a";
            uid = "root";               //"UserGroupeA";
            password = "";              //"SuperCabaneA";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }


        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string tablename, string fields, string values)
        {
            string query = "INSERT INTO " + tablename + fields + "VALUES" + values;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string query)
        {
            //string query = "UPDATE t_cabanes SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string query)
        {
            //string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
//************* Prend toute les informations des cabanes dans une liste
        //Select statement
        public TCabane[] ReadCabanes()
        {
            string query = "SELECT * FROM t_cabanes";
            int nbCabanes = Count("t_cabanes"), i = 0;

            TCabane[] cabanes = new TCabane[nbCabanes];        

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    cabanes[i].idCabane = dataReader.GetInt32(0);
                    cabanes[i].nomCabane = dataReader.GetString(1);
                    cabanes[i].altitude = dataReader.GetInt32(2);
                    cabanes[i].nombreLit = dataReader.GetInt32(3);
                    cabanes[i].douche = dataReader.GetBoolean(4);
                    cabanes[i].tarif = dataReader.GetString(5);
                    if (!dataReader.IsDBNull(6))
                    {
                        cabanes[i].idVisite = dataReader.GetInt32(6);
                    }

                    i++;
                }

                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();
                //return list to be displayed
                return cabanes;
            }
            else
            {
                return cabanes;
            }
        }

        //Count statement
        public int Count(string tablename)
        {
            string query = "SELECT Count(*) FROM " + tablename;
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }

}