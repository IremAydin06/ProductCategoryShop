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
using Microsoft.EntityFrameworkCore;

namespace ProductCategoryShop
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var db = new electronicShopDbContext();

            Product newProduct = new Product();
            newProduct.Name = textBoxProductName.Text;
            newProduct.Description = textBoxProductDescription.Text;
            Category selectedCategory = new Category();
            selectedCategory = db.Categories.ToList().Where<Category>(x => x.Name == comboBoxProductCategory.Text.Trim()).FirstOrDefault<Category>();
            //newProduct.CategoryId = selectedCategory.Id;
            newProduct.Category = selectedCategory;


            db.Products.Add(newProduct);
            int affectedRow = db.SaveChanges();
            if (affectedRow > 0)
            {
                MessageBox.Show("Ürün eklendi.");
                getProducts();
            }
            else
            {
                MessageBox.Show("Ürün ekleme başarısız.");
            }
        }

        void getProducts()
        {
            var db = new electronicShopDbContext();
            dataGridViewProducts.DataSource = db.Products.ToList();
        }
        void getCategories()
        {
            var db = new electronicShopDbContext();
            
            comboBoxProductCategory.Items.Clear();
            foreach (var item in db.Categories.ToList())
            {
                comboBoxProductCategory.Items.Add(item.Name);
            }
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            getProducts();
            getCategories();
        }

        private void buttonBacktoAnaEkranPro_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void buttonDeleceProduct_Click(object sender, EventArgs e)
        {
            {

                try

                {

                    DialogResult cevap;

                    cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)

                    {
                        var db = new electronicShopDbContext();
                        //db.Categories.Remove();
                    }

                }

                catch (Exception hata)

                {

                    MessageBox.Show(hata.Message);

                }
            }
        }

        Product selectedProduct = null;
        private void comboBoxUpdatePro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedProductId = (int)comboBoxUpdatePro.SelectedValue;

            
        }
    }
}
