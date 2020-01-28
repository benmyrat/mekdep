using System;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;

namespace eSchool
{
    class iClassTableDB
    {
        databaseConnection connection = new databaseConnection();
        //функция добавления
        public bool insertClass(string className, int classRoom, int numberPupil)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `iclass`(`className`, `classRoom`, `numberStudents`) VALUES (@cName,@cRoom,@nPupil)", connection.getConnection);
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = className;
            command.Parameters.Add("@cRoom", MySqlDbType.Int32).Value = classRoom;
            command.Parameters.Add("@nPupil", MySqlDbType.Int32).Value = numberPupil;

            connection.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }
        public DataTable getCommand(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public bool updateClass(string nName, string cName, int cRoom, int nPupil)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `iclass` SET `className`=@nName,`classRoom`=@cRoom," +
                "`numberStudents`=@nPupil WHERE `className`=@cName", connection.getConnection);
            command.Parameters.Add("@nName", MySqlDbType.VarChar).Value = nName;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@cRoom", MySqlDbType.Int32).Value = cRoom;
            command.Parameters.Add("@nPupil", MySqlDbType.Int32).Value = nPupil;
            connection.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }
        public bool deleteClass(string cName)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `iclass` WHERE `className`=@cName", connection.getConnection);
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            connection.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }
    }
}
