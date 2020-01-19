using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace eSchool
{
    class databaseConnection
    {
        private MySqlConnection connecton = new MySqlConnection("server=localhost;port=3306;username=root;password=21071998;database=myschool");
        public void openConnection()
        {
            if (connecton.State == System.Data.ConnectionState.Closed)
            {
                connecton.Open();
            }
        }
        public void closeConnection()
        {
            if (connecton.State == ConnectionState.Open)
            {
                connecton.Close();
            }
        }

        public MySqlConnection getConnection
        {
            get
            {
                return connecton;
            }
        }
    }
}
