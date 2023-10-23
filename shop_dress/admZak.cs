using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_dress
{
    public partial class admZak : Form
    {
        public admZak()
        {
            InitializeComponent();
        }

        private void admZak_Load(object sender, EventArgs e)
        {

            this.zakazTableAdapter.Fill(this.magazinZakazDataSet.zakaz);
            zakazyBindingNavigator.BindingSource = zakazBindingSource;
        }

        private void prevPicBox_Click(object sender, EventArgs e)
        {
            this.Close();
            admin adm = new admin();
            adm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.zakazTableAdapter.Update(this.magazinZakazDataSet.zakaz);
            this.zakazTableAdapter.Fill(this.magazinZakazDataSet.zakaz);
        }
    }
}
