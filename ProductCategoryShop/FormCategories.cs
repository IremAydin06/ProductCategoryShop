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
    public partial class FormCategories : Form
    {
        public FormCategories()
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
            comboCategory.Items.Clear();
            foreach (var item in db.Categories.ToList())
            {
                comboCategory.Items.Add(item.Name);
            }
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            getCategories();
        }

        private void buttoBacktoAnaEkranCat_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            {

                try

                {

                    DialogResult cevap;

                    cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)

                    {
                        var db = new electronicShopDbContext();

                        Category newCategory = new Category();
                        newCategory = db.Categories.ToList().Where<Category>(x => x.Name == comboCategory.Text.Trim()).FirstOrDefault<Category>();
                        db.Categories.Remove(newCategory);
                        db.SaveChanges();
                        comboCategory.Text = "";
                        getCategories();
                    }

                }

                catch (Exception hata)

                {

                    MessageBox.Show(hata.Message);

                }
            }
        }
    }
}
