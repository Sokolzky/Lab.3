namespace Lab._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double.TryParse(dishSizeTB.Text, out double size); 
            double.TryParse(persentageOfSpiritTB.Text, out double percentage); 
            double.TryParse(quatityOfDishesTB.Text, out double quantity); 
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

   
    }
}