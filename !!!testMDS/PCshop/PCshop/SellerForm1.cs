﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PCshop
{
    public partial class SellerForm1 : Form
    {
        DBConnect dBCon = new DBConnect();
        public SellerForm1()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT *FROM Seller";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Seller.DataSource = table;
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();   
            TextBox_phone.Clear();
            TextBox_pass.Clear();
            TextBox_age.Clear();
        }
          
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Seller VALUES(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox_age.Text + "' ,'" + TextBox_phone.Text + "','" + TextBox_pass.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Succesfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerForm1_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_age.Text == "" || TextBox_phone.Text == "" || TextBox_pass.Text =="")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Seller SET SellerName='" + TextBox_name.Text + "',SellerAge=" + TextBox_age.Text + ",SellerPhone=" + TextBox_phone.Text + ",SellerPass='" + TextBox_pass.Text + "'";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Succesfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_Seller_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_Seller.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_Seller.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_age.Text = dataGridView_Seller.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_phone.Text = dataGridView_Seller.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_pass.Text = dataGridView_Seller.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    
                        string deleteQuery = "DELETE FROM Seller WHERE SellerId=" + TextBox_id.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Seller Deleted Succesfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        clear();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();   
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();    
            product.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm(); 
            category.Show();
            this.Hide();
        }
    }
}
