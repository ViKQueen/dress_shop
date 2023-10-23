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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            this.katalogTableAdapter1.Fill(this.magazinKatalogDataSet.katalog);
            katalogBindingNavigator.BindingSource = katalogBindingSource1;
        }

        private void prevPicBox_Click(object sender, EventArgs e)
        {
            this.Close();
            authorization auth = new authorization();
            auth.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.katalogTableAdapter1.Update(this.magazinKatalogDataSet.katalog);
            this.katalogTableAdapter1.Fill(this.magazinKatalogDataSet.katalog);
        }

        private void zakazyButton_Click(object sender, EventArgs e)
        {
            this.Close();
            admZak aZ = new admZak();
            aZ.Show();
        }
    }
}
