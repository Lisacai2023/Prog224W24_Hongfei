using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace Prog224W24_Hongfei
{
    //Prog224W24_Hongfei
    //Final
    //3/19/2024
    public partial class Form1 : Form
    {
        Inventory inventory = new Inventory();
        Order order = new Order();
        Receipt receipt = new Receipt();
        static string folderPath = @"../../../JSONFolder/";
        static string AppJson = @"app.json";
        string filePath = folderPath + AppJson; 
          
        public Form1()
        {
            InitializeComponent();
            PreloadInventory();
            inventory.SaveToJson(filePath);
            //inventory.LoadFromJson(filePath);

        }

        public void PreloadInventory()
        {
            inventory.AddProduct(new Beverage("Coffee", 2.5, "Medium"));
            inventory.AddProduct(new Food("Croissant", 3, DateTime.Now.AddDays(10)));
            inventory.AddProduct(new Merchandise("Mug", 10, "Kitchenware"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateInventoryListbox();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            //Display inventories in the listbox1
            listBox1.Items.Clear();

            string input = "Available Products:";
            listBox1.Items.Add(input);
            UpdateInventoryListbox();
            //int index = 1;

            //foreach (Product product in inventory)
            //{
            //    listBox1.Items.Add($"{index}. {product}");
            //    index++;
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Add product into inventory and display it the listbox1
            string ProductName = textBox1.Text;
            double ProductPrice = double.Parse(textBox2.Text);
            string selectProductType = comboBox1.SelectedItem.ToString();

            switch (selectProductType)
            {
                case "Beverage":
                    if (checkBox1.Checked)
                    {
                        inventory.AddProduct(new Beverage(ProductName, ProductPrice, checkBox1.Text));
                    }
                    else if (checkBox2.Checked)
                    {
                        inventory.AddProduct(new Beverage(ProductName, ProductPrice, checkBox2.Text));
                    }
                    else
                    {
                        inventory.AddProduct(new Beverage(ProductName, ProductPrice, checkBox3.Text));
                    }
                    break;

                case "Food":
                    inventory.AddProduct(new Food(ProductName, ProductPrice));
                    break;
                case "Merchandise":
                    inventory.AddProduct(new Merchandise(ProductName, ProductPrice));
                    break;
            }
            MessageBox.Show($"{ProductName}: ${ProductPrice} added successfully!");
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedItem = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selet a product to add the order");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // 1. Saving a reference to the selected product from list 1
            int selectedProductIndex = listBox1.SelectedIndex;
            Product selectedProduct = inventory.Products[selectedProductIndex];

            // 2. Adding the product to our current order
            order.AddProduct(selectedProduct);

            // 3. Display list of producets in current order
            UpdateOrderListBox();
            double totalPrice = order.CalculateTotalPrice();
            MessageBox.Show("Product added to the order.");

            listBox2.Items.Add($"Total price of the order: ${totalPrice}");
            DialogResult result = MessageBox.Show($"Do you want to add more products to the order ?", " Edit your order", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Select a product to add to the order:");
            }
            else
            {
                MessageBox.Show("You clicked No or closed the dialog!");
            }
            listBox2.Items.Add($"Receipt:\n" +
                $" Order Total :${totalPrice}");

        }

        public void UpdateListBox(List<Product> products, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (Product product in products)
            {
                listbox.Items.Add(product.ToString());
            }
        }

        // Helper Method
        public void UpdateInventoryListbox()
        {
            UpdateListBox(inventory.Products, listBox1);

        }

        public void UpdateOrderListBox()
        {
            UpdateListBox(order.Products, listBox2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }//main class
}//namespace
