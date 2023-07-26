namespace PCshop
{
    partial class SellerForm1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_logout = new System.Windows.Forms.Label();
            this.button_selling = new System.Windows.Forms.Button();
            this.button_category = new System.Windows.Forms.Button();
            this.button_Product = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView_Seller = new Guna.UI2.WinForms.Guna2DataGridView();
            this.product_label = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seller)).BeginInit();
            this.SuspendLayout();
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Red;
            this.label_logout.Location = new System.Drawing.Point(14, 599);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(103, 25);
            this.label_logout.TabIndex = 27;
            this.label_logout.Text = "LOGOUT";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            // 
            // button_selling
            // 
            this.button_selling.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_selling.Location = new System.Drawing.Point(19, 255);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(153, 47);
            this.button_selling.TabIndex = 26;
            this.button_selling.Text = "SELLING";
            this.button_selling.UseVisualStyleBackColor = true;
            // 
            // button_category
            // 
            this.button_category.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_category.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_category.Location = new System.Drawing.Point(19, 158);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(153, 47);
            this.button_category.TabIndex = 25;
            this.button_category.Text = "CATEGORY";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_Product
            // 
            this.button_Product.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Product.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_Product.Location = new System.Drawing.Point(19, 47);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(153, 47);
            this.button_Product.TabIndex = 24;
            this.button_Product.Text = "PRODUCT";
            this.button_Product.UseVisualStyleBackColor = true;
            this.button_Product.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Red;
            this.label_exit.Location = new System.Drawing.Point(1048, 11);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 25);
            this.label_exit.TabIndex = 23;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TextBox_pass);
            this.panel1.Controls.Add(this.dataGridView_Seller);
            this.panel1.Controls.Add(this.product_label);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_phone);
            this.panel1.Controls.Add(this.TextBox_age);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(207, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 593);
            this.panel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // TextBox_pass
            // 
            this.TextBox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_pass.DefaultText = "";
            this.TextBox_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_pass.Location = new System.Drawing.Point(125, 352);
            this.TextBox_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_pass.Name = "TextBox_pass";
            this.TextBox_pass.PasswordChar = '●';
            this.TextBox_pass.PlaceholderText = "";
            this.TextBox_pass.SelectedText = "";
            this.TextBox_pass.Size = new System.Drawing.Size(206, 41);
            this.TextBox_pass.TabIndex = 18;
            this.TextBox_pass.UseSystemPasswordChar = true;
            // 
            // dataGridView_Seller
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dataGridView_Seller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Seller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView_Seller.ColumnHeadersHeight = 4;
            this.dataGridView_Seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Seller.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView_Seller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Seller.Location = new System.Drawing.Point(398, 81);
            this.dataGridView_Seller.Name = "dataGridView_Seller";
            this.dataGridView_Seller.RowHeadersVisible = false;
            this.dataGridView_Seller.RowHeadersWidth = 51;
            this.dataGridView_Seller.RowTemplate.Height = 24;
            this.dataGridView_Seller.Size = new System.Drawing.Size(470, 509);
            this.dataGridView_Seller.TabIndex = 17;
            this.dataGridView_Seller.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Seller.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Seller.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Seller.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Seller.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Seller.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Seller.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Seller.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Seller.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Seller.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Seller.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Seller.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Seller.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView_Seller.ThemeStyle.ReadOnly = false;
            this.dataGridView_Seller.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Seller.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Seller.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Seller.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Seller.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_Seller.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Seller.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Seller.Click += new System.EventHandler(this.dataGridView_Seller_Click);
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_label.Location = new System.Drawing.Point(297, 13);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(152, 25);
            this.product_label.TabIndex = 16;
            this.product_label.Text = "Manage Seller";
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_delete.Location = new System.Drawing.Point(258, 454);
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
            this.button_update.Location = new System.Drawing.Point(125, 454);
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
            this.button_add.Location = new System.Drawing.Point(19, 454);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(85, 47);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
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
            // TextBox_phone
            // 
            this.TextBox_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_phone.DefaultText = "";
            this.TextBox_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.Location = new System.Drawing.Point(125, 280);
            this.TextBox_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_phone.Name = "TextBox_phone";
            this.TextBox_phone.PasswordChar = '\0';
            this.TextBox_phone.PlaceholderText = "";
            this.TextBox_phone.SelectedText = "";
            this.TextBox_phone.Size = new System.Drawing.Size(206, 41);
            this.TextBox_phone.TabIndex = 4;
            // 
            // TextBox_age
            // 
            this.TextBox_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_age.DefaultText = "";
            this.TextBox_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_age.Location = new System.Drawing.Point(125, 206);
            this.TextBox_age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_age.Name = "TextBox_age";
            this.TextBox_age.PasswordChar = '\0';
            this.TextBox_age.PlaceholderText = "";
            this.TextBox_age.SelectedText = "";
            this.TextBox_age.Size = new System.Drawing.Size(206, 41);
            this.TextBox_age.TabIndex = 3;
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
            this.TextBox_name.Location = new System.Drawing.Point(125, 139);
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
            this.TextBox_id.Location = new System.Drawing.Point(125, 65);
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
            // SellerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 790);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_Product);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm1";
            this.Text = "SellerForm1";
            this.Load += new System.EventHandler(this.SellerForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Seller;
        private System.Windows.Forms.Label product_label;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_phone;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_age;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_pass;
    }
}