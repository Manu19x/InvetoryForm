using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PCshop
{
    public partial class CategoryForm : Form
    {

        DBConnect dBCon = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT *FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_category.DataSource = table;
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox_description.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Succesfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Category SET CatName='" + TextBox_name.Text + "', Cat_Des='" + TextBox_description.Text + "'WHERE Cat_Id=" + TextBox_id.Text + " ";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Succesfully", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_description.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Category WHERE Cat_Id=" + TextBox_id.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Succesfully", "Delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show(); 
            this.Hide();
        }

        private void dataGridView_category_Click_1(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_description.Text = dataGridView_category.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm1 seller = new SellerForm1(); 
            seller.Show();
            this.Hide();
        }
    }
}
