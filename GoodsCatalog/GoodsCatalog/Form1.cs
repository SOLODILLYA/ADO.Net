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
using System.Configuration;
using GoodsCatalog.Models;

namespace GoodsCatalog
{
    public partial class Form1 : Form
    {
        private readonly string _connString;
        private readonly SqlConnection _conn;

        private readonly SqlDataAdapter _productsAdapter;
        private readonly DataTable _productsTable;
        private readonly SqlCommandBuilder _productsCommandBuilder;

        private readonly SqlDataAdapter _productsModAdapter;
        private readonly DataTable _productsModTable;
        private readonly SqlCommandBuilder _productsModCommandBuilder;
        public Form1()
        {
            InitializeComponent();
            string defaultName = "GoodsCatalog.Properties.Settings.CatalogConnectionString";
            _connString = ConfigurationManager.ConnectionStrings[defaultName].ConnectionString;
            _conn = new SqlConnection(_connString);

            string sql = "";
            sql += " select p.Id, p.ProductName, c.CategoryName, prod.ProducerName, p.Price, p.Count";
            sql += " from Products p, Categories c, Producers prod";
            sql += " where p.CategoryId = c.Id and p.ProducerId  = prod.Id";

            _productsAdapter = new SqlDataAdapter(sql, _conn);
            _productsCommandBuilder = new SqlCommandBuilder(_productsAdapter);
            _productsTable = new DataTable();

            _productsModAdapter = new SqlDataAdapter("select * from Products", _conn);
            _productsModCommandBuilder = new SqlCommandBuilder(_productsModAdapter);
            _productsModTable = new DataTable();

            _productsModAdapter.Fill(_productsModTable);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'catalogDataSet1.Producers' table. You can move, or remove it, as needed.
            this.producersTableAdapter1.Fill(this.catalogDataSet1.Producers);
            // TODO: This line of code loads data into the 'categoriesDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.categoriesDataSet.Categories);
            LoadProducts();
            LoadCategotiesForProducts();
            LoadProducersForProducts();
        }

        private void LoadCategotiesForProducts() 
        { 
            CategoriesList.Items.Clear();
            CategoriesList.Items.Add(new Category()
            {
                Id=0, CategoryName = "All Categories", CategoryInfo = "-"
            });
            foreach (DataRow row in this.categoriesDataSet.Categories.Rows)
            {
                CategoriesList.Items.Add(new Category()
                {
                    Id = (int)row["Id"],
                    CategoryName = row["CategoryName"].ToString(),
                    CategoryInfo = row["CategoryInfo"].ToString()
                });
            }
            CategoriesList.DisplayMember = "CategoryName";
            if(CategoriesList.Items.Count > 0)
            {
                CategoriesList.SelectedIndex = 0;
            }
        }

        private void LoadProducersForProducts()
        {
            ProducersList.Items.Clear();
            ProducersList.Items.Add(new Producer()
            {
                Id = 0,
                ProducerName = "All Producers",
                ProducerInfo = "-"
            });
            foreach (DataRow row in this.catalogDataSet1.Producers.Rows)
            {
                ProducersList.Items.Add(new Producer()
                {
                    Id = (int)row["Id"],
                    ProducerName = row["ProducerName"].ToString(),
                    ProducerInfo = row["ProducerInfo"].ToString()
                });
            }
            ProducersList.DisplayMember = "ProducerName";
            if (CategoriesList.Items.Count > 0)
            {
                CategoriesList.SelectedIndex = 0;
            }
            if(ProducersList.Items.Count > 0)
            {
                ProducersList.SelectedIndex = 0;
            }
        }

        private void LoadProducts()
        {
            _productsTable.Clear();
            _productsAdapter.Fill(_productsTable);
            ProductsList.Items.Clear();
            FillProductsList();
        }

        private void FillProductsList()
        {
            foreach (DataRow row in _productsTable.Rows)
            {
                var listItem = ProductsList.Items.Add(row["Id"].ToString());
                listItem.SubItems.Add(row["ProductName"].ToString());
                listItem.SubItems.Add(row["CategoryName"].ToString());
                listItem.SubItems.Add(row["ProducerName"].ToString());
                listItem.SubItems.Add(row["Price"].ToString());
                listItem.SubItems.Add(row["Count"].ToString());
            }
        }

        private void UpdateCategoriesData_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriesTableAdapter.Update(this.categoriesDataSet.Categories);
                MessageBox.Show("Categories Updated Successfuly", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.categoriesTableAdapter.Fill(this.categoriesDataSet.Categories);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error Updating Categories: {ex.Message}", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateProducerButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.producersTableAdapter1.Update(this.catalogDataSet1.Producers);
                MessageBox.Show("Producers Updated Successfuly", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.producersTableAdapter1.Fill(this.catalogDataSet1.Producers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Updating Producers: {ex.Message}", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ProductsList.SelectedItems.Count > 0)
            {
                int k = ProductsList.SelectedIndices[0];
                var selecteItem = ProductsList.Items[k];
                NameField.Text = selecteItem.SubItems[1].Text;
                PriceField.Text = selecteItem.SubItems[4].Text;
                QuantityField.Text = selecteItem.SubItems[5].Text;

            }
        }

        private void CategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductsList.Items.Clear();
            var selectedCategory = CategoriesList.SelectedItem as Category;
            if(selectedCategory.Id == 0)
            {
                FillProductsList();
            }
            else
            {
                FilterProductsList(selectedCategory);
            }
            ClearFields();
        }

        private void FilterProductsList(Category category)
        {
            foreach (DataRow row in _productsTable.Rows)
            {
                if (row["CategoryName"].ToString() == category.CategoryName)
                {
                    var listItem = ProductsList.Items.Add(row["Id"].ToString());
                    listItem.SubItems.Add(row["ProductName"].ToString());
                    listItem.SubItems.Add(row["CategoryName"].ToString());
                    listItem.SubItems.Add(row["ProducerName"].ToString());
                    listItem.SubItems.Add(row["Price"].ToString());
                    listItem.SubItems.Add(row["Count"].ToString());
                }
            }
        }

        private void ClearFields()
        {
            NameField.Clear();
            PriceField.Clear();
            QuantityField.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string productName = NameField.Text;
            string price = PriceField.Text;
            string quantity = QuantityField.Text;

            var selectedCategory = CategoriesList.SelectedItem as Category;
            string categoryName = selectedCategory.CategoryName;
            int categoryId = selectedCategory.Id;

            var selectedProducer = ProducersList.SelectedItem as Producer;
            string producerName = selectedProducer.ProducerName;
            int producerId = selectedProducer.Id;

            try
            {
                if(string.IsNullOrWhiteSpace(productName)) {
                    throw new Exception("You have not entered product name");
                }
                if (string.IsNullOrWhiteSpace(price))
                {
                    throw new Exception("You have not entered product price");
                }
                if (string.IsNullOrWhiteSpace(quantity))
                {
                    throw new Exception("You have not entered product quantity");
                }
                if(categoryName == "All Categories")
                {
                    throw new Exception("You have not entered product category");
                }
                if(producerName == "All Producers")
                {
                    throw new Exception("You have not entered product producer");
                }

                DataRow newRow = _productsModTable.NewRow();
                newRow["Id"] = 0;
                newRow["ProductName"] = productName;
                newRow["CategoryId"] = Convert.ToInt32(categoryId);
                newRow["ProducerId"] = Convert.ToInt32(producerId);
                newRow["Price"] = Convert.ToDecimal(price);
                newRow["Count"] = Convert.ToInt32(quantity);

                _productsModTable.Rows.Add(newRow);
                _productsModAdapter.Update(_productsModTable);
                MessageBox.Show("Product added successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CategoriesList.SelectedIndex = 0;
                ProducersList.SelectedIndex = 0;
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProducersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductsList.Items.Clear();
            var selectedProducer = ProducersList.SelectedItem as Producer;
            if (selectedProducer.Id == 0)
            {
                FillProductsList();
            }
            else
            {
                FilterProducersList(selectedProducer);
            }
            ClearFields();
        }

        private void FilterProducersList(Producer selectedProducer)
        {
            foreach (DataRow row in _productsTable.Rows)
            {
                if (row["ProducerName"].ToString() == selectedProducer.ProducerName)
                {
                    var listItem = ProductsList.Items.Add(row["Id"].ToString());
                    listItem.SubItems.Add(row["ProductName"].ToString());
                    listItem.SubItems.Add(row["CategoryName"].ToString());
                    listItem.SubItems.Add(row["ProducerName"].ToString());
                    listItem.SubItems.Add(row["Price"].ToString());
                    listItem.SubItems.Add(row["Count"].ToString());
                }
            }
        }
    }
}
