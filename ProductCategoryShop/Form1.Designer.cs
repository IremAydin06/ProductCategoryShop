
namespace ProductCategoryShop
{
    partial class Form1
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
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.textBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.groupBoxCategoryAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCategoryAdd
            // 
            this.groupBoxCategoryAdd.Controls.Add(this.buttonAddCategory);
            this.groupBoxCategoryAdd.Controls.Add(this.label2);
            this.groupBoxCategoryAdd.Controls.Add(this.label1);
            this.groupBoxCategoryAdd.Controls.Add(this.textBoxCategoryDescription);
            this.groupBoxCategoryAdd.Controls.Add(this.textBoxCategoryName);
            this.groupBoxCategoryAdd.Location = new System.Drawing.Point(27, 12);
            this.groupBoxCategoryAdd.Name = "groupBoxCategoryAdd";
            this.groupBoxCategoryAdd.Size = new System.Drawing.Size(804, 226);
            this.groupBoxCategoryAdd.TabIndex = 0;
            this.groupBoxCategoryAdd.TabStop = false;
            this.groupBoxCategoryAdd.Text = "Kategori";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(378, 68);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(227, 22);
            this.textBoxCategoryName.TabIndex = 0;
            // 
            // textBoxCategoryDescription
            // 
            this.textBoxCategoryDescription.Location = new System.Drawing.Point(378, 134);
            this.textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            this.textBoxCategoryDescription.Size = new System.Drawing.Size(227, 22);
            this.textBoxCategoryDescription.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(530, 183);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(75, 27);
            this.buttonAddCategory.TabIndex = 4;
            this.buttonAddCategory.Text = "Ekle";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategoriler";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(37, 308);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.Size = new System.Drawing.Size(804, 192);
            this.dataGridViewCategories.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 621);
            this.Controls.Add(this.dataGridViewCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxCategoryAdd);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
    }
}

