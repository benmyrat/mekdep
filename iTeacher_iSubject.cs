using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;
namespace eSchool
{
    class iTeacher_iSubject
    {
        databaseConnection connection = new databaseConnection();
        public DataTable getTeacher_Subject(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertTeacherSubject(string fkT, string fkS)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `iteacher_has_subject`(`iTeacher_fk`, `subject_fk`) VALUES (@fkT,@fkS)", connection.getConnection);
            command.Parameters.Add("@fkT", MySqlDbType.VarChar).Value = fkT;
            command.Parameters.Add("@fkS", MySqlDbType.VarChar).Value = fkS;
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
        public bool updateTeacherSubject(int id, string fkT, string fkS)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `iteacher_has_subject` SET `id`=@ID,`iTeacher_fk`=@fkT,`subject_fk`=@fkS" +
                " WHERE `iteacher_has_subject`.`id`=@ID", connection.getConnection);
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fkT", MySqlDbType.VarChar).Value = fkT;
            command.Parameters.Add("@fkS", MySqlDbType.VarChar).Value = fkS;
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
        public bool deleteTeacherSubject(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `iteacher_has_subject` WHERE `id`=@ID", connection.getConnection);
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

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

        public DataTable fullTeacherData(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
