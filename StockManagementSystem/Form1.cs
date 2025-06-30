using System.Drawing.Text;

namespace StockManagementSystem
{
    public partial class Form1 : Form
    {
        private List<StockItem> stockItems = new List<StockItem>();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxDisplayStockItems.Visible = false;
            listBoxDisplayStockItems.SelectedIndexChanged +=
                listBoxDisplayStockItems_SelectedIndexChanged;
        }


        private void listBoxDisplayStockItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDisplayStockItems.SelectedIndex != -1)
            {
                StockItem selectedItem = stockItems[listBoxDisplayStockItems.SelectedIndex];
                textBoxName.Text = selectedItem.ItemName;
                textBoxItemCode.Text = selectedItem.ItemCode;
                textBoxQuantity.Text = selectedItem.Quantity.ToString();
                textBoxPrice.Text = selectedItem.Price.ToString("F2");
            }
        }


        private bool ValidateInputs(out int quantity, out decimal price)
        {
            quantity = 0;
            price = 0;

            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxItemCode.Text) ||
                !int.TryParse(textBoxQuantity.Text, out quantity) ||
                !decimal.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Please enter valid item details.");
                return false;
            }
            return true;
        }
        //clearing inputs
        private void ClearInputs()
        {
            textBoxName.Clear();
            textBoxItemCode.Clear();
            textBoxQuantity.Clear();
            textBoxPrice.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //Validation
            if (!ValidateInputs(out int quantity, out decimal price))
                return;

            StockItem item = new StockItem()
            {
                ItemName = textBoxName.Text,
                ItemCode = textBoxItemCode.Text,
                Quantity = quantity,
                Price = price
            };

            
            stockItems.Add(item);        
            listBoxDisplayStockItems.Items.Add(item);
            listBoxDisplayStockItems.Visible = true;
            ClearInputs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxDisplayStockItems.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select an item to update.");
            }
            if (!ValidateInputs(out int quantity, out decimal price))
                return;
            StockItem selectedItem = stockItems[selectedIndex];
            selectedItem.ItemName = textBoxName.Text;
            selectedItem.ItemCode = textBoxItemCode.Text;
            selectedItem.Quantity = quantity;
            selectedItem.Price = price;


            // Refresh the item in the list
       
            listBoxDisplayStockItems.Items[selectedIndex] = selectedItem;
            ClearInputs();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxDisplayStockItems.SelectedIndex;
            if(selectedIndex == -1)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }
            stockItems.RemoveAt(selectedIndex);
            listBoxDisplayStockItems.Items.RemoveAt(selectedIndex);
            ClearInputs();
        }
    }
}
