namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private double price = 0;
        private int noSingle = 10;
        private int noDouble = 7;
        private int noFamily = 8;
        private int noSuits = 2;
        private void calculateBtn_Click(object sender, EventArgs e)
        {

            if (invalidForm())
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int roomCount = int.Parse(roomCountBox.Text);
                    int dayCount = int.Parse(daysBox.Text);
                    switch (roomBox.SelectedIndex)
                    {
                        case 0:
                            if (dayCount > noSingle)
                            {
                                MessageBox.Show("Single rooms are not available at the moment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                            else
                            {
                                price += 5000.00 * roomCount * dayCount;
                                noSingle -= dayCount;
                                break;
                            }
                        case 1:
                            if (dayCount > noDouble)
                            {
                                MessageBox.Show("Double rooms are not available at the moment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                            else
                            {
                                price += 7500.00 * roomCount * dayCount;
                                if (dayCount > 5) price *= 0.95;
                                noDouble -= dayCount;
                                break;
                            }
                        case 2:
                            if (dayCount > noFamily)
                            {
                                MessageBox.Show("Family rooms are not available at the moment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                            else
                            {
                                price += 8000.00 * roomCount * dayCount;
                                noFamily -= dayCount;
                                break;
                            }
                        case 3:
                            if (dayCount > noSuits)
                            {
                                MessageBox.Show("Suits are not available at the moment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                            else
                            {
                                price += 12500.00 * roomCount * dayCount;
                                if (dayCount > 5) price *= 0.88;
                                noSuits -= dayCount;
                                break;
                            }
                    }
                    totalBox.Text = price.ToString();
                    if (anotherBox.SelectedIndex == 1) 
                    {
                        price = 0;
                        clearForm();
                    }
                    else
                    {
                        roomCountBox.Text = "";
                        daysBox.Text = "";
                        anotherBox.SelectedIndex = -1;
                        roomBox.SelectedIndex = -1;
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter Valid Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


        }
        private bool invalidForm()
        {
            return String.IsNullOrWhiteSpace(nameBox.Text) || String.IsNullOrWhiteSpace(addressBox.Text) || String.IsNullOrWhiteSpace(roomCountBox.Text) || String.IsNullOrWhiteSpace(anotherBox.Text) || String.IsNullOrWhiteSpace(roomBox.Text) || String.IsNullOrWhiteSpace(daysBox.Text);
        }

        private void clearForm()
        {
            nameBox.Text = "";
            addressBox.Text = "";
            roomCountBox.Text = "";
            daysBox.Text = "";
            anotherBox.SelectedIndex = -1;
            roomBox.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}