namespace PCshop
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_selling = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            this.button_seller = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_category = new Guna.UI2.WinForms.Guna2DataGridView();
            this.category_label = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).BeginInit();
            this.SuspendLayout();
            // 
            // button_selling
            // 
            this.button_selling.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_selling.Location = new System.Drawing.Point(21, 255);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(153, 47);
            this.button_selling.TabIndex = 19;
            this.button_selling.Text = "SELLING";
            this.button_selling.UseVisualStyleBackColor = true;
            // 
            // button_product
            // 
            this.button_product.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_product.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_product.Location = new System.Drawing.Point(21, 158);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(153, 47);
            this.button_product.TabIndex = 18;
            this.button_product.Text = "PRODUCT";
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // button_seller
            // 
            this.button_seller.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seller.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_seller.Location = new System.Drawing.Point(21, 47);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(153, 47);
            this.button_seller.TabIndex = 17;
            this.button_seller.Text = "SELLER";
            this.button_seller.UseVisualStyleBackColor = true;
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Red;
            this.label_exit.Location = new System.Drawing.Point(1050, 11);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 25);
            this.label_exit.TabIndex = 16;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.dataGridView_category);
            this.panel1.Controls.Add(this.category_label);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_description);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(209, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 593);
            this.panel1.TabIndex = 15;
            // 
            // dataGridView_category
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_category.ColumnHeadersHeight = 4;
            this.dataGridView_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_category.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_category.Location = new System.Drawing.Point(390, 67);
            this.dataGridView_category.Name = "dataGridView_category";
            this.dataGridView_category.RowHeadersVisible = false;
            this.dataGridView_category.RowHeadersWidth = 51;
            this.dataGridView_category.RowTemplate.Height = 24;
            this.dataGridView_category.Size = new System.Drawing.Size(478, 523);
            this.dataGridView_category.TabIndex = 15;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_category.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_category.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_category.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_category.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_category.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_category.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView_category.ThemeStyle.ReadOnly = false;
            this.dataGridView_category.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_category.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_category.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_category.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_category.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_category.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_category.Click += new System.EventHandler(this.dataGridView_category_Click_1);
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.Location = new System.Drawing.Point(350, 24);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(184, 25);
            this.category_label.TabIndex = 14;
            this.category_label.Text = "Manage Cateogry";
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_delete.Location = new System.Drawing.Point(248, 292);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(134, 47);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_update.Location = new System.Drawing.Point(115, 292);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(114, 47);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_add.Location = new System.Drawing.Point(9, 292);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(85, 47);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // TextBox_description
            // 
            this.TextBox_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_description.DefaultText = "";
            this.TextBox_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_description.Location = new System.Drawing.Point(160, 206);
            this.TextBox_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_description.Name = "TextBox_description";
            this.TextBox_description.PasswordChar = '\0';
            this.TextBox_description.PlaceholderText = "";
            this.TextBox_description.SelectedText = "";
            this.TextBox_description.Size = new System.Drawing.Size(206, 41);
            this.TextBox_description.TabIndex = 3;
            // 
            // TextBox_name
            // 
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Location = new System.Drawing.Point(160, 138);
            this.TextBox_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(206, 41);
            this.TextBox_name.TabIndex = 2;
            // 
            // TextBox_id
            // 
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Location = new System.Drawing.Point(160, 67);
            this.TextBox_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(206, 41);
            this.TextBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Red;
            this.label_logout.Location = new System.Drawing.Point(12, 595);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(103, 25);
            this.label_logout.TabIndex = 20;
            this.label_logout.Text = "LOGOUT";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Button button_seller;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_description;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_logout;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_category;
    }
}