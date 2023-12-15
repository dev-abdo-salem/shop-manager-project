using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;



namespace shopManager
{
    public partial class InventoryForm : Form
    {
        private static InventoryForm instance;

        public static InventoryForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new InventoryForm();
                }
                return instance;
            }
        }

        public static StackDataList dataList;
        private InventoryForm()
        {
            InitializeComponent();
            dataList = new StackDataList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.CellContentClick += dataGridView_CellContentClick;

            // Load existing products into dataGridView
            LoadProductsToDataGridView();

        }
        private void addProdButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProduct = new AddProductForm();
            addProduct.ShowDialog();
        }
        public void LoadProductsToDataGridView()
        {
            // Clear existing data
            dataGridView.Rows.Clear();

            // Get all products from the stack
            List<Product> products = dataList.GetAllProducts();

            // Populate dataGridView with product data
            foreach (Product product in products)
            {
                dataGridView.Rows.Add(product.Name, product.ID, product.Category, product.Quantity, product.TotalPrice(), "Edit", "Delete");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs dataGrid)
        {
            if (dataGrid.RowIndex >= 0)
            {
                int columnIndex = dataGrid.ColumnIndex;
                int rowIndex = dataGrid.RowIndex;

                // Check if the "Edit" button is clicked
                if (columnIndex == dataGridView.Columns["Column6"].Index)
                {
                    // Handle edit logic, for example, show a form for editing
                    // You can use the rowIndex to get the corresponding Product from the stack
                    // Update the product in the stack and reload data into the dataGridView
                    // Example:
                    // Product selectedProduct = dataList.GetProductAtIndex(rowIndex);
                    // ShowEditForm(selectedProduct);
                }
                // Check if the "Delete" button is clicked
                else if (columnIndex == dataGridView.Columns["Column7"].Index)
                {
                    string prodId = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                    dataList.RemovedSpesProduct(int.Parse(prodId));
                    LoadProductsToDataGridView();
                }
            }
        }

        private void UpdateDataGridViewWithProduct(Product product)
        {
            // Clear existing data
            dataGridView.Rows.Clear();

            // Update UI with the retrieved product information
            dataGridView.Rows.Add(product.Name, product.ID, product.Category, product.Quantity, product.TotalPrice(), "Edit", "Delete");
        }
        private void searchIcon_Click(object sender, EventArgs e)
        {
            string proID = searchTextBox.Text;

            if (int.TryParse(proID, out int id))
            {
                if (id >= 1111110)
                {
                    Product wantedProd = dataList.GetSpecificProductById(id);

                    if (wantedProd != null)
                    {
                        UpdateDataGridViewWithProduct(wantedProd);
                    }
                    else
                    {
                        MessageBox.Show($"Product with ID {id} not found.", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid product ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric product ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            LoadProductsToDataGridView();
        }
    }

}