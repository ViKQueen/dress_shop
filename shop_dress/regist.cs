using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_dress
{
    public partial class regist : Form
    {
        DataBase database = new DataBase();
        public regist()
        {
            InitializeComponent();
        }

        private void prevPicBox_Click(object sender, EventArgs e)
        {
            this.Close();
            authorization auth = new authorization();
            auth.Show();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (fullnameTextBox.Text == "" || phoneTextBox.Text == "" || mailTextBox.Text == "" || Convert.ToString(polComboBox.SelectedItem) == "" || loginTextBox.Text == "" || passwordTextBox.Text == "")
                MessageBox.Show("Необходимо заполнить все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    SqlCommand newUserCommand = new SqlCommand("INSERT INTO [Users] (loginn, pass, stat) Values(@loginn, @pass, @stat)", database.GetConnection());
                    newUserCommand.Parameters.AddWithValue("loginn", loginTextBox.Text);
                    newUserCommand.Parameters.AddWithValue("pass", passwordTextBox.Text);
                    newUserCommand.Parameters.AddWithValue("stat", 0);
                    database.openConnection();
                    newUserCommand.ExecuteNonQuery();
                    int id_user = 0;
                    string userString = $"select * from Users where loginn = '{loginTextBox.Text}' and pass = '{passwordTextBox.Text}'";
                    SqlCommand userCommand = new SqlCommand(userString, database.GetConnection());
                    SqlDataReader user = userCommand.ExecuteReader();
                    while (user.Read())
                    {
                        id_user = Convert.ToInt32(user["id_user"]);
                    }
                    user.Close();
                    database.closeConnection();

                    SqlCommand newClientCommand = new SqlCommand("INSERT INTO [klient] (name, phone, date_rozh, email, pol, id_user) Values(@name, @phone, @date_rozh, @email, @pol, @id_user)", database.GetConnection());
                    newClientCommand.Parameters.AddWithValue("name", fullnameTextBox.Text);
                    newClientCommand.Parameters.AddWithValue("phone", phoneTextBox.Text);
                    newClientCommand.Parameters.AddWithValue("date_rozh", Convert.ToString(dateTimePicker.Value).Remove(10));
                    newClientCommand.Parameters.AddWithValue("email", mailTextBox.Text);
                    newClientCommand.Parameters.AddWithValue("pol", polComboBox.SelectedItem);
                    newClientCommand.Parameters.AddWithValue("id_user", id_user);
                    database.openConnection();
                    newClientCommand.ExecuteNonQuery();
                    MessageBox.Show("Создана новая учётная запись клиента", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string clientString = $"select * from klient where id_user = '{id_user}'";
                    SqlCommand clientCommand = new SqlCommand(clientString, database.GetConnection());
                    SqlDataReader client = clientCommand.ExecuteReader();
                    while (client.Read())
                    {
                        zakaz.id_klient = Convert.ToInt32(client["id_klient"]);
                    }
                    client.Close();
                    database.closeConnection();

                    main.login = loginTextBox.Text;

                    this.Close();
                    main mn = new main();
                    mn.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Что-то пошло не так.\nДля проверки подключения обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void eyeButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
        }

        private void eyeButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }
    }
}
