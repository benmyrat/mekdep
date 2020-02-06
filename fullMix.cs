using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace eSchool
{
    class fullMix
    {
        databaseConnection connection = new databaseConnection();
        public DataTable getFullMixCommand(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllFullMix()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM  `class_has_iteacher_has_subject_has_schedule`", connection.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.openConnection();
            return table;
        }
        //INSERT INTO `class_has_iteacher_has_subject_has_schedule` (`id`, `iTeacher_has_subject_fk`, `iclass_fk`, `ischedule_fk`) VALUES (NULL, '28', '1-А', '2');
        public bool insertFULL(int tSubject, string cName, int Schedule)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `class_has_iteacher_has_subject_has_schedule`(`iTeacher_has_subject_fk`, `iclass_fk`, `ischedule_fk`) VALUES (@Tsubject,@cName,@schedule)", connection.getConnection);
            command.Parameters.Add("@Tsubject", MySqlDbType.Int32).Value = tSubject;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@schedule", MySqlDbType.Int32).Value = Schedule;
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
