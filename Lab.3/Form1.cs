namespace Lab._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void dishSizeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void persentageOfSpiritTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void quatityOfDishesTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {


        }

        private void confirmButton_Click_1(object sender, EventArgs e)
        {
            double.TryParse(dishSizeTB.Text, out double size);
            double.TryParse(persentageOfSpiritTB.Text, out double percentage);
            if (percentage >= 100)
            {
                percentage = 100;
            }
            else if (percentage <= 0)
            {
                percentage = 0;
            }
            double.TryParse(quatityOfDishesTB.Text, out double quantity);
            double result = size * (percentage / 100) * quantity;

            resultTB.Clear();
            resultTB.Text = String.Format("iloœæ czystego spirytusu {0:0.00} L", result);
        }
    }
}