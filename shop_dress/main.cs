using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shop_dress
{
    public partial class main : Form
    {
        DataBase database = new DataBase();

        //private readonly checkUser _user;
        //public static int id_katalog;
        public static int lengthList;
        public static int itemList;
        public static string login = "Гость";
        public List<katalog> tkatalog = new List<katalog>();
        public main()
        {
            //_user = user;
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {
            TypesList();
            logLabel.Text = "Вы вошли как *" + login + "*";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        public void TypesList()
        {
            typeComboBox.Items.Clear();

            SqlCommand typesCommand = new SqlCommand($"select * from [tipe]", database.GetConnection());

            try
            {
                database.openConnection();
                SqlDataReader patients = typesCommand.ExecuteReader();
                while (patients.Read())
                {
                    typeComboBox.Items.Add(patients["tipe"]);
                }
                patients.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_tipe = 0;
            itemList = 0;
            tkatalog.Clear();
            polComboBox.Items.Clear();
            colorComboBox.Items.Clear();
            try
            {
                SqlCommand tipeCommand = new SqlCommand($"select * from [tipe] where tipe = '" + Convert.ToString(typeComboBox.SelectedItem) + "'", database.GetConnection());
                database.openConnection();
                SqlDataReader tipe = tipeCommand.ExecuteReader();
                while (tipe.Read())
                {
                    id_tipe = Convert.ToInt32(tipe[0]);
                }
                tipe.Close();
                SqlCommand katalogCommand = new SqlCommand($"select * from [katalog] where id_tipe = '" + id_tipe + "'", database.GetConnection());
                SqlDataReader katalog = katalogCommand.ExecuteReader();
                while (katalog.Read())
                {
                    katalog clothes = new katalog
                    {
                        ID = Convert.ToInt32(katalog["id_katalog"]),
                        Name = Convert.ToString(katalog["name"]),
                        Sostav = Convert.ToString(katalog["sostav"]),
                        Razmer = Convert.ToString(katalog["razmer"]),
                        Pol = Convert.ToString(katalog["pol"]),
                        Cost = Convert.ToSingle(katalog["cost"]),
                        Color = Convert.ToString(katalog["color"]),
                        Picture = Convert.ToString(katalog["picture"])
                    };
                    tkatalog.Add(clothes);
                }
                katalog.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lengthList = tkatalog.Count();
            Thing();
            if (zakazButton.Enabled == false) zakazButton.Enabled = true;
            if (prevPicBox.Enabled == false) prevPicBox.Enabled = true;
            if (nextPicBox.Enabled == false) nextPicBox.Enabled = true;
        }

        private void prevPicBox_Click(object sender, EventArgs e)
        {
            if (itemList != 0) 
            {
                itemList--;
                Thing();

            }
        }

        private void nextPicBox_Click(object sender, EventArgs e)
        {
            if (itemList != lengthList-1)
            {
                itemList++;
                Thing();
            }
        }

        public void Thing()
        {
            polComboBox.Items.Clear();
            colorComboBox.Items.Clear();
            katalog single = tkatalog[itemList];
            zakaz.id_katalog = single.ID;
            zakaz.cost = single.Cost;
            nameRichTextBox.Text = single.Name;
            sostavTextBox.Text = single.Sostav;
            razmerTextBox.Text = single.Razmer;
            costTextBox.Text = Convert.ToString(single.Cost);
            itemPictureBox.ImageLocation = single.Picture;
            try
            {
                SqlCommand polCommand = new SqlCommand($"select distinct pol from [katalog] where name = '" + single.Name + "'", database.GetConnection());
                SqlCommand colorCommand = new SqlCommand($"select distinct color from [katalog] where name = '" + single.Name + "' and pol = '" + single.Pol + "'", database.GetConnection());
                database.openConnection();
                SqlDataReader pol = polCommand.ExecuteReader();
                while (pol.Read())
                {
                    polComboBox.Items.Add(pol.GetString(0));
                }
                pol.Close();
                SqlDataReader color = colorCommand.ExecuteReader();
                while (color.Read())
                {
                    colorComboBox.Items.Add(color.GetString(0));
                }
                color.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            polComboBox.SelectedItem = single.Pol;
            colorComboBox.SelectedItem = single.Color;
        }

        private void polComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorComboBox.Items.Clear();

            try
            {
                database.openConnection();
                SqlCommand colorCommand = new SqlCommand($"select distinct color from [katalog] where name = '" + nameRichTextBox.Text + "' and pol = '" + polComboBox.SelectedItem + "'", database.GetConnection());
                SqlDataReader color = colorCommand.ExecuteReader();
                while (color.Read())
                {
                    colorComboBox.Items.Add(color.GetString(0));
                }
                color.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            colorComboBox.SelectedIndex = 0;

            colorChange();
        }

        public void colorChange()
        {
            try
            {
                database.openConnection();
            SqlCommand thingCommand = new SqlCommand($"select * from [katalog] where name = '" + nameRichTextBox.Text + "' and pol = '" + polComboBox.SelectedItem + "' and color = '" + colorComboBox.SelectedItem + "'", database.GetConnection());
            SqlDataReader thing = thingCommand.ExecuteReader();

            while (thing.Read())
            {
                zakaz.id_katalog = Convert.ToInt32(thing["id_katalog"]);
                zakaz.cost = Convert.ToInt32(thing["cost"]);
                sostavTextBox.Text = Convert.ToString(thing["sostav"]);
                razmerTextBox.Text = Convert.ToString(thing["razmer"]);
                costTextBox.Text = Convert.ToString(thing["cost"]);
                itemPictureBox.ImageLocation = Convert.ToString(thing["picture"]);
            }
            thing.Close();
            database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorChange();
        }

        private void zakazButton_Click(object sender, EventArgs e)
        {
            if (login == "Гость" || login == "admin") MessageBox.Show("Для оформления заказа вам необходимо авторизоваться в качестве клиента", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                this.Hide();
                zakaz zkz = new zakaz();
                zkz.Show();
            }
        }

        private void authPicBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorization auth = new authorization();
            auth.Show();
        }
    }

}
