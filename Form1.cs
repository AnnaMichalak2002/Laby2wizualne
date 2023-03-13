namespace Laby2wizualne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double computerPrice = 0;
        public void SaveComputerPrice(double newComputerPrice)
        {
            computerPrice = newComputerPrice;
            CalculateTotalPrice();
        }
        private double monitorPrice = 0;
        public void SaveMonitorPrice(double newMonitorPrice)
        {
            monitorPrice = newMonitorPrice;
            CalculateTotalPrice();
        }

        private double totalPrice = 0;
        private void CalculateTotalPrice()
        {
            totalPrice = monitorPrice + computerPrice;
            label2.Text = totalPrice.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                form2.SaveComputerPrice += SaveComputerPrice;
                form2.ShowDialog(this);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                form3.SaveMonitorPrice += SaveMonitorPrice;
                form3.ShowDialog(this);
            }
        }
    }
}