using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCategoryShop
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.Show();
            this.Hide();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories();
            formCategories.Show();
            this.Hide();
        }

        private void AnaEkran_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
