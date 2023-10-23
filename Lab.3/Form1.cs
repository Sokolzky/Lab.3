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
            double.TryParse(quatityOfDishesTB.Text, out double quantity);
            double result;
            result = size * (percentage / 100) * quantity;

            resultTB.Clear();
            resultTB.Text = "iloœæ czystego spirytusu " + result.ToString();
        }
    }
}