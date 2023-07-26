using System;
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
using DGVPrinterHelper;

namespace PCshop
{
    public partial class SellingForm : Form
    {
        DBConnect dBCon = new DBConnect();
        DGVPrinter printer = new DGVPrinter();
        public SellingForm()
        {
            InitializeComponent();
        }

        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CatName";
        }

        private void getTable()
        {
            string selectQuerry = "SELECT name_prod, price_prod FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }
        private void getSellTable()
        {
            string selectQuerry = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_sellList.DataSource = table;
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();
            label_seller.Text = LoginForm.sellerName;
            getTable();
            getCategory();
            getSellTable();
        }

        private void DataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_name.Text= DataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_price.Text = DataGridView_product.SelectedRows[0].Cells[1].Value.ToString();

        }
        int grandTotal = 0, n = 0;

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES(" + TextBox_id.Text + ",'" + label_seller.Text + "','" + label_date.Text + "' , '" + grandTotal.ToString()+ "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Succesfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getSellTable();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "PC Shop Sell Lists";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Matea Marian";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape= true;
            printer.PrintDataGridView(DataGridView_sellList);


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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT name_prod, price_prod from Product WHERE categ_prod='" + comboBox_category.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            if (TextBox_name.Text == "" || TextBox_qty.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int Total = Convert.ToInt32(TextBox_price.Text) * Convert.ToInt32(TextBox_qty.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(DataGridView_order);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = TextBox_name.Text;
                addRow.Cells[2].Value = TextBox_price.Text;
                addRow.Cells[3].Value = TextBox_qty.Text;
                addRow.Cells[4].Value = Total;
                DataGridView_order.Rows.Add(addRow);
                grandTotal += Total;
                label_amount.Text = grandTotal + "Ks";
            }

        }
    }
}
