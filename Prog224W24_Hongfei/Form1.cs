namespace Prog224W24_Hongfei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Display inventories in the listbox
            Inventory inventory = new Inventory();
            inventory.AddProduct("Coffee",2.5);
        }
    }
}
