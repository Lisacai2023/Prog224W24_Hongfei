namespace Prog224W24_Hongfei
{
    public partial class Form1 : Form
    {
        Inventory inventory = new Inventory();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Display inventories in the listbox1
            inventory.AddProduct(new Beverage("Coffee", 2.5, "Medium"));
            inventory.AddProduct(new Food("Croissant", 3, DateTime.Now.AddDays(10)));
            inventory.AddProduct(new Merchandise("Mug", 10, "Kitchenware"));
            string input = "Available Products:";
            listBox1.Items.Add(input);
            int index = 1;
            foreach (Product product in inventory)
            {
                listBox1.Items.Add($"{index}. {product}");
                index++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add product into inventory and display it the listbox1
            string ProductName = textBox1.Text;
            double ProductPrice = double.Parse(textBox2.Text);

        }
    }
}
