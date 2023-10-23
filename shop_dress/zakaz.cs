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
using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;

namespace shop_dress
{
    public partial class zakaz : Form
    {
        DataBase database = new DataBase();
        public static int id_katalog;
        public static int id_klient = 0;
        public static float cost;
        Word._Application Word = new Word.Application();
        public zakaz()
        {
            InitializeComponent();
        }

        private void prevPicBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            main main = new main();
            main.Show();
        }

        private void zakaz_Load(object sender, EventArgs e)
        {
            dateTextBox.Text = Convert.ToString(DateTime.Now.AddDays(2)).Remove(10);
            costTextBox.Text = Convert.ToString(cost);
            try
            {
                database.openConnection();
                SqlCommand clientCommand = new SqlCommand($"select * from [klient] where id_klient = '" + id_klient + "'", database.GetConnection());
                SqlCommand thingCommand = new SqlCommand($"select * from [katalog] where id_katalog = '" + id_katalog + "'", database.GetConnection());
                SqlDataReader thing = thingCommand.ExecuteReader();
                while (thing.Read())
                {
                    thingRichTextBox.Text = Convert.ToString(thing["name"]) + " (" + Convert.ToString(thing["razmer"]) + "); " + Convert.ToString(thing["sostav"]) + "; " + Convert.ToString(thing["pol"]) + "; " + Convert.ToString(thing["color"]);
                }
                thing.Close();

                SqlDataReader client = clientCommand.ExecuteReader();
                while (client.Read())
                {
                    clientRichTextBox.Text = Convert.ToString(client["name"]) + "; " + Convert.ToString(client["date_rozh"]).Remove(10) + "; " + Convert.ToString(client["phone"]) + "; " + Convert.ToString(client["email"]);
                }
                client.Close();
                database.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так.\nДля проверки подключения обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void quanTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quanTextBox.Text == "" || quanTextBox.Text.All(char.IsDigit) == false) costTextBox.Text = "~";
            else costTextBox.Text = Convert.ToString(cost * Convert.ToSingle(quanTextBox.Text));
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (costTextBox.Text == "~" || razmerTextBox.Text == "") MessageBox.Show("Необходимо ввести требуемые параметры в корректном формате", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    SqlCommand newDoctorCommand = new SqlCommand("INSERT INTO [zakaz] (id_klient, id_katalog, colic, cost, date_vpol, razmer) Values(@id_klient, @id_katalog, @colic, @cost, @date_vpol, @razmer)", database.GetConnection());
                    newDoctorCommand.Parameters.AddWithValue("id_klient", id_klient);
                    newDoctorCommand.Parameters.AddWithValue("id_katalog", id_katalog);
                    newDoctorCommand.Parameters.AddWithValue("colic", Convert.ToInt32(quanTextBox.Text));
                    newDoctorCommand.Parameters.AddWithValue("cost", Convert.ToSingle(costTextBox.Text));
                    newDoctorCommand.Parameters.AddWithValue("date_vpol", dateTextBox.Text);
                    newDoctorCommand.Parameters.AddWithValue("razmer", Convert.ToSingle(razmerTextBox.Text));
                    database.openConnection();
                    newDoctorCommand.ExecuteNonQuery();
                    MessageBox.Show("Создана новая запись заказа", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    database.closeConnection();

                    string pathTOrder = Environment.CurrentDirectory + "\\templates\\order.docx";
                    string pathOrder = Environment.CurrentDirectory + "\\orders\\" + Convert.ToString(DateTime.Now).Remove(11) + DateTime.Now.ToString("HH") + "_" + DateTime.Now.ToString("mm") + "_" + DateTime.Now.ToString("ss") + ".docx";

                    Word._Document Doc = Word.Documents.Add(pathTOrder);
                    Doc.Bookmarks["client"].Range.Text = clientRichTextBox.Text;
                    Doc.Bookmarks["thing"].Range.Text = thingRichTextBox.Text;
                    Doc.Bookmarks["razmer"].Range.Text = razmerTextBox.Text;
                    Doc.Bookmarks["quantity"].Range.Text = quanTextBox.Text;
                    Doc.Bookmarks["cost"].Range.Text = costTextBox.Text;
                    Doc.Bookmarks["date"].Range.Text = dateTextBox.Text;
                    Doc.SaveAs(FileName: pathOrder);
                    Doc.Close();

                    Process.Start(pathOrder);

                    this.Close();
                    main main = new main();
                    main.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Что-то пошло не так.\nДля проверки подключения обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clientRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
