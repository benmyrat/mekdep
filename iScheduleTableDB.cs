using System;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;
namespace eSchool
{
    class iScheduleTableDB
    {
        databaseConnection connection = new databaseConnection();
        public bool insertSchedule(string day, string startTime, string finishTime)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `ischedule`(`day`, `startTime`, `finishTime`) VALUES (@day,@sTime,@fTime)", connection.getConnection);
            command.Parameters.Add("@day", MySqlDbType.VarChar).Value = day;
            command.Parameters.Add("@sTime", MySqlDbType.VarChar).Value = startTime;
            command.Parameters.Add("@fTime", MySqlDbType.VarChar).Value = finishTime;

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
        public DataTable getAll()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM  `ischedule`", connection.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.openConnection();
            return table;
        }
        public bool deleteSchedule(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `iscedule` WHERE `id`=@ID", connection.getConnection);
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
        public bool updateSchedule(int id, string day, string sTime, string fTime)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `ischedule` SET `id`=@ID,`day`=@day,`startTime`=@sTime,`finishTime`=@fTime WHERE `ischedule`.`id`=@ID", connection.getConnection);
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@day", MySqlDbType.VarChar).Value = day;
            command.Parameters.Add("@sTime", MySqlDbType.VarChar).Value = sTime;
            command.Parameters.Add("@fTime", MySqlDbType.VarChar).Value = fTime;

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
