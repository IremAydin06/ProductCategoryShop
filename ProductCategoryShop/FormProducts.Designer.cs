
namespace ProductCategoryShop
{
    partial class FormProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxCategoryAdd = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBoxUpdatePro = new System.Windows.Forms.ComboBox();
            this.buttonUpdatePro = new System.Windows.Forms.Button();
            this.buttonDeleceProduct = new System.Windows.Forms.Button();
            this.buttonBacktoAnaEkranPro = new System.Windows.Forms.Button();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxCategoryAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCategoryAdd
            // 
            this.groupBoxCategoryAdd.Controls.Add(this.splitContainer1);
            this.groupBoxCategoryAdd.Controls.Add(this.buttonBacktoAnaEkranPro);
            this.groupBoxCategoryAdd.Location = new System.Drawing.Point(23, 21);
            this.groupBoxCategoryAdd.Name = "groupBoxCategoryAdd";
            this.groupBoxCategoryAdd.Size = new System.Drawing.Size(1244, 332);
            this.groupBoxCategoryAdd.TabIndex = 1;
            this.groupBoxCategoryAdd.TabStop = false;
            this.groupBoxCategoryAdd.Text = "Ürün";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(19, 21);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddProduct);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxProductCategory);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProductDescription);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProductName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxUpdatePro);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDeleceProduct);
            this.splitContainer1.Panel2.Controls.Add(this.buttonUpdatePro);
            this.splitContainer1.Size = new System.Drawing.Size(1199, 268);
            this.splitContainer1.SplitterDistance = 601;
            this.splitContainer1.TabIndex = 10;
            // 
            // comboBoxUpdatePro
            // 
            this.comboBoxUpdatePro.FormattingEnabled = true;
            this.comboBoxUpdatePro.Location = new System.Drawing.Point(37, 70);
            this.comboBoxUpdatePro.Name = "comboBoxUpdatePro";
            this.comboBoxUpdatePro.Size = new System.Drawing.Size(300, 24);
            this.comboBoxUpdatePro.TabIndex = 8;
            this.comboBoxUpdatePro.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdatePro_SelectedIndexChanged);
            // 
            // buttonUpdatePro
            // 
            this.buttonUpdatePro.Enabled = false;
            this.buttonUpdatePro.Location = new System.Drawing.Point(37, 181);
            this.buttonUpdatePro.Name = "buttonUpdatePro";
            this.buttonUpdatePro.Size = new System.Drawing.Size(75, 38);
            this.buttonUpdatePro.TabIndex = 5;
            this.buttonUpdatePro.Text = "Güncelle";
            this.buttonUpdatePro.UseVisualStyleBackColor = true;
            // 
            // buttonDeleceProduct
            // 
            this.buttonDeleceProduct.Location = new System.Drawing.Point(262, 163);
            this.buttonDeleceProduct.Name = "buttonDeleceProduct";
            this.buttonDeleceProduct.Size = new System.Drawing.Size(75, 38);
            this.buttonDeleceProduct.TabIndex = 9;
            this.buttonDeleceProduct.Text = "Sil";
            this.buttonDeleceProduct.UseVisualStyleBackColor = true;
            this.buttonDeleceProduct.Click += new System.EventHandler(this.buttonDeleceProduct_Click);
            // 
            // buttonBacktoAnaEkranPro
            // 
            this.buttonBacktoAnaEkranPro.Location = new System.Drawing.Point(19, 295);
            this.buttonBacktoAnaEkranPro.Name = "buttonBacktoAnaEkranPro";
            this.buttonBacktoAnaEkranPro.Size = new System.Drawing.Size(168, 33);
            this.buttonBacktoAnaEkranPro.TabIndex = 8;
            this.buttonBacktoAnaEkranPro.Text = "Ana Ekran\'a Dön";
            this.buttonBacktoAnaEkranPro.UseVisualStyleBackColor = true;
            this.buttonBacktoAnaEkranPro.Click += new System.EventHandler(this.buttonBacktoAnaEkranPro_Click);
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.FormattingEnabled = true;
            this.comboBoxProductCategory.Location = new System.Drawing.Point(122, 144);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(223, 24);
            this.comboBoxProductCategory.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategori";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(261, 204);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 38);
            this.buttonAddProduct.TabIndex = 4;
            this.buttonAddProduct.Text = "Ekle";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.Location = new System.Drawing.Point(118, 100);
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(227, 22);
            this.textBoxProductDescription.TabIndex = 1;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(118, 49);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(227, 22);
            this.textBoxProductName.TabIndex = 0;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(23, 418);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1234, 192);
            this.dataGridViewProducts.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürünler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ürün Seç:";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 673);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxCategoryAdd);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.groupBoxCategoryAdd.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCategoryAdd;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductDescription;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProductCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonBacktoAnaEkranPro;
        private System.Windows.Forms.Button buttonDeleceProduct;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBoxUpdatePro;
        private System.Windows.Forms.Button buttonUpdatePro;
        private System.Windows.Forms.Label label5;
    }
}