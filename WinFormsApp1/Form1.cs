namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double price = 0;
            int noSingle = 10;
            int noDouble = 7;
            int noFamily = 8;
            int noSuits = 2;

            if (invalidForm()) {
                MessageBox.Show("Please fill all the fields", "Error");
            }
            else
            {
                switch (roomBox.SelectedIndex)
                {
                    case 0:
                        price = 5000.00;
                        break;
                    case 1:
                        price = 7500.00; 
                        break;
                    case 2:
                        price = 8000.00;
                        break;
                    case 3:
                        price = 12500.00;
                        break;
                }
                price *= int.Parse(roomCountBox.Text);
                totalBox.Text = price.ToString();
            }


        }
        private bool invalidForm()
        {
            return String.IsNullOrWhiteSpace(nameBox.Text) || String.IsNullOrEmpty(addressBox.Text) || String.IsNullOrEmpty(roomCountBox.Text) || String.IsNullOrEmpty(anotherBox.Text) || String.IsNullOrEmpty(roomBox.Text);
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}