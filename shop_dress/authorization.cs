using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_dress
{
    public partial class authorization : Form
    {
        DataBase database = new DataBase();
        public authorization()
        {
            InitializeComponent();
        }

        private void prevPicBox_Click(object sender, EventArgs e)
        {
            this.Close();
            main main = new main();
            main.Show();
        }

        private void authButton_Click(object sender, EventArgs e)
        {

            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;

            SqlDataAdapter adapterLog = new SqlDataAdapter();
            DataTable tableLog = new DataTable();

            string loginString = $"select * from Users where loginn = '{login}' and pass = '{password}'";

            SqlCommand commandLog = new SqlCommand(loginString, database.GetConnection());
            try
            {
                adapterLog.SelectCommand = commandLog;
                adapterLog.Fill(tableLog);

                if (tableLog.Rows.Count == 1)
                {
                    if (Convert.ToInt32(tableLog.Rows[0].ItemArray[3]) == 1)
                    {
                        this.Close();
                        admin adm = new admin();
                        adm.Show();
                    }
                    else if (Convert.ToInt32(tableLog.Rows[0].ItemArray[3]) == 0)
                    {
                    database.openConnection();
                    string clientString = $"select * from klient where id_user = '{tableLog.Rows[0].ItemArray[0]}'";
                    SqlCommand clientCommand = new SqlCommand(clientString, database.GetConnection());
                    SqlDataReader client = clientCommand.ExecuteReader();
                    while (client.Read())
                    {
                        zakaz.id_klient = Convert.ToInt32(client["id_klient"]);
                    }
                    client.Close();
                    database.closeConnection();
                    main.login = Convert.ToString(tableLog.Rows[0].ItemArray[1]);
                        this.Close();
                        main mn = new main();
                        mn.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения к базе данных обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void labelReg_Click(object sender, EventArgs e)
        {
            this.Close();
            regist regist = new regist();
            regist.Show();
        }

        private void eyeButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
        }

        private void eyeButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
