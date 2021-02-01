
namespace ProductCategoryShop
{
    partial class FormCategories
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
            this.groupBoxCategoryAdd = new System.Windows.Forms.GroupBox();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttoBacktoAnaEkranCat = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.groupBoxCategoryAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCategoryAdd
            // 
            this.groupBoxCategoryAdd.Controls.Add(this.comboCategory);
            this.groupBoxCategoryAdd.Controls.Add(this.buttonDeleteCategory);
            this.groupBoxCategoryAdd.Controls.Add(this.buttoBacktoAnaEkranCat);
            this.groupBoxCategoryAdd.Controls.Add(this.buttonAddCategory);
            this.groupBoxCategoryAdd.Controls.Add(this.label2);
            this.groupBoxCategoryAdd.Controls.Add(this.label1);
            this.groupBoxCategoryAdd.Controls.Add(this.textBoxCategoryDescription);
            this.groupBoxCategoryAdd.Controls.Add(this.textBoxCategoryName);
            this.groupBoxCategoryAdd.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCategoryAdd.Name = "groupBoxCategoryAdd";
            this.groupBoxCategoryAdd.Size = new System.Drawing.Size(804, 332);
            this.groupBoxCategoryAdd.TabIndex = 2;
            this.groupBoxCategoryAdd.TabStop = false;
            this.groupBoxCategoryAdd.Text = "Kategori";
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(530, 232);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(75, 27);
            this.buttonDeleteCategory.TabIndex = 6;
            this.buttonDeleteCategory.Text = "Sil";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttoBacktoAnaEkranCat
            // 
            this.buttoBacktoAnaEkranCat.Location = new System.Drawing.Point(24, 283);
            this.buttoBacktoAnaEkranCat.Name = "buttoBacktoAnaEkranCat";
            this.buttoBacktoAnaEkranCat.Size = new System.Drawing.Size(145, 27);
            this.buttoBacktoAnaEkranCat.TabIndex = 5;
            this.buttoBacktoAnaEkranCat.Text = "Ana Ekran\'a Dön";
            this.buttoBacktoAnaEkranCat.UseVisualStyleBackColor = true;
            this.buttoBacktoAnaEkranCat.Click += new System.EventHandler(this.buttoBacktoAnaEkranCat_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(530, 185);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(75, 27);
            this.buttonAddCategory.TabIndex = 4;
            this.buttonAddCategory.Text = "Ekle";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı";
            // 
            // textBoxCategoryDescription
            // 
            this.textBoxCategoryDescription.Location = new System.Drawing.Point(378, 124);
            this.textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            this.textBoxCategoryDescription.Size = new System.Drawing.Size(227, 22);
            this.textBoxCategoryDescription.TabIndex = 1;
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(378, 68);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(227, 22);
            this.textBoxCategoryName.TabIndex = 0;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(26, 392);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.Size = new System.Drawing.Size(804, 192);
            this.dataGridViewCategories.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategoriler";
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(372, 235);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(121, 24);
            this.comboCategory.TabIndex = 7;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 633);
            this.Controls.Add(this.dataGridViewCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxCategoryAdd);
            this.Name = "FormCategories";
            this.Text = "FormCategories";
            this.Load += new System.EventHandler(this.FormCategories_Load);
            this.groupBoxCategoryAdd.ResumeLayout(false);
            this.groupBoxCategoryAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCategoryAdd;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCategoryDescription;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttoBacktoAnaEkranCat;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.ComboBox comboCategory;
    }
}