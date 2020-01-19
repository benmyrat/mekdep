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
    class iTeacherTableDB
    {
        databaseConnection connection = new databaseConnection();
        //функция добавления
        public bool insertTeacher(string surname, string name, string patronymic, string gender, DateTime birthDate,
            string address, string mail, string mobile, string login, string password, MemoryStream teacherPic)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `iteacher`(`surName`, `name`, `patronymic`, `gender`, `birthDate`, `address`, `mail`, `mobile`, `login`, `pass`, `teacherPic`) " +
                "VALUES (@sname,@name,@pname,@gender,@bdate,@address,@mail,@mobile,@login,@pass,@pic)", connection.getConnection);
            command.Parameters.Add("@sname", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@pname", MySqlDbType.VarChar).Value = patronymic;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@address", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@mobile", MySqlDbType.Int64).Value = mobile;
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
        //функиця для получение всех данных
        public DataTable getTeachers(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        //функия обновления
        public bool updateTeachers(int id, string surname, string name, string patronymic, string gender, DateTime birthDate,
            string address, string mail, string mobile, string login, string password, MemoryStream teacherPic)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `iteacher` SET `id`=@ID,`surName`=@sname,`name`=@name,`patronymic`=@pname,`" +
                "gender`=@gender,`birthDate`=@bdate,`address`=@address,`mail`=@mail,`mobile`=@mobile,`login`=@login,`pass`=@pass," +
                "`teacherPic`=@pic WHERE `iteacher`.`id`=@ID", connection.getConnection);
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@sname", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@pname", MySqlDbType.VarChar).Value = patronymic;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@address", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@mobile", MySqlDbType.Int64).Value = mobile;
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
        //Функция для удаления
        public bool deleteTeacher(int id)
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

    }
}
