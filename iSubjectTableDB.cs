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
    class iSubjectTableDB
    {
        databaseConnection connection = new databaseConnection();
        //добавить дисциплину
        public bool insertSubject(string subjectName, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `isubject`(`subjectName`, `description`) VALUES (@sName,@description)", connection.getConnection);
            command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = subjectName;
            command.Parameters.Add("@description", MySqlDbType.Text).Value = description;
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
        //проверка навсякой случае
        public bool checkSubjectName(string subjcetName)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `isubject` WHERE `subjectName`=@sName", connection.getConnection);
            command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = subjcetName;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                connection.closeConnection();
                return false;
            }
            else
            {
                connection.closeConnection();
                return true;
            }
        }

        ////получаем все название курсов на Combobox
        public DataTable getAllSubjects()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM  `isubject`", connection.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            connection.openConnection();
            return table;
        }
        //Возвращать все данные по выбранным дисциплинам
        public DataTable getSubjectByName(string sName)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM  `isubject` WHERE `subjectName`=@sName", connection.getConnection);
            command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = sName;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.openConnection();
            return table;
        }//удаление
        public bool deleteSubject(string sName)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `isubject` WHERE `subjectName`=@sName", connection.getConnection);
            command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = sName;
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
        }//обновление
        public bool updateSubjects(string name, string sName, string sDescription)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `isubject` SET `subjectName`=@sName,`description`=@sDescription WHERE `subjectName`=@name", connection.getConnection);
            //переменные заглушки для безопасности! @sName, @sDescription
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = sName;
            command.Parameters.Add("@sDescription", MySqlDbType.Text).Value = sDescription;
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
        public string execCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connection.getConnection);
            connection.openConnection();
            string count = command.ExecuteScalar().ToString();
            connection.closeConnection();
            return count;
        }

        public string totalSubject()
        {
            return execCount("SELECT COUNT(*) FROM `isubject`");
        }

        public DataTable getSs(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
