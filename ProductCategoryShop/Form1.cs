using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductCategoryShop.Models;
using ProductCategoryShop.Data;

namespace ProductCategoryShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            var db = new electronicShopDbContext();
            Category newCategory = new Category();
            newCategory.Name = textBoxCategoryName.Text;
            newCategory.Desription = textBoxCategoryDescription.Text;

            db.Categories.Add(newCategory);
            int affectedRow = db.SaveChanges();
            if (affectedRow > 0)
            {
                MessageBox.Show("Kategori eklendi.");
                getCategories();
            }
            else
            {
                MessageBox.Show("Kategori ekleme başarısız.");
            }
        }

        void getCategories()
        {
            var db = new electronicShopDbContext();
            dataGridViewCategories.DataSource = db.Categories.ToList();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getCategories();
        }
    }
}
