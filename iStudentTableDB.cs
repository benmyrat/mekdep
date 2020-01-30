using System;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;
namespace eSchool
{
    class iStudentTableDB
    {
        databaseConnection connection = new databaseConnection();
        public DataTable getCommand(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertStudent(string surname, string name, string patronymic, string gender, DateTime birthDate,
            string address, string mobile, string className, string login, string password, MemoryStream teacherPic)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `istudent`(`surName`, `name`, `patronymic`, `gender`, `birthDate`, `address`, `mobile`, `className_fk`, `login`, `pass`, `studentPic`) " +
                "VALUES (@sName,@Name,@pName,@gender,@bdate,@address,@mobile,@cName,@login,@pass,@pic)", connection.getConnection);
            command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@pName", MySqlDbType.VarChar).Value = patronymic;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@address", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = mobile;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = className;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", MySqlDbType.Blob).Value = teacherPic.ToArray();

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
        public bool updateStudents(int id, string surname, string name, string patronymic, string gender, DateTime birthDate,
            string address, string mobile, string cName, string login, string password, MemoryStream teacherPic)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `istudent` SET `id`=@ID,`surName`=@sname,`name`=@name,`patronymic`=@pname,`" +
                "gender`=@gender,`birthDate`=@bdate,`address`=@address,`mobile`=@mobile,`className_fk`=@cName,`login`=@login,`pass`=@pass," +
                "`studentPic`=@pic WHERE `istudent`.`id`=@ID", connection.getConnection);
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@sname", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@pname", MySqlDbType.VarChar).Value = patronymic;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@address", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@mobile", MySqlDbType.Int64).Value = mobile;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", MySqlDbType.Blob).Value = teacherPic.ToArray();

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
        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `iteacher` WHERE `id`=@ID", connection.getConnection);
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
        public DataTable getStudents(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
