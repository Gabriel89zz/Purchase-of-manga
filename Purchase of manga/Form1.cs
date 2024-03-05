namespace Purchase_of_manga
{
    public partial class Form1 : Form
    {
        Manga manga1 = new Manga();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                manga1.Title = txtTitle.Text;
                manga1.Autor = txtAutor.Text;
                manga1.Genre = txtGenre.Text;
                manga1.Editorial = comboBoxEditorial.Text;
                manga1.Volume = txtVolume.Text;
                double total = manga1.CalculateTotal(Convert.ToInt16(txtQuantity.Text));

                lblTotal.Text = total.ToString() + " MXN";
            }
            catch (Exception)
            {

                MessageBox.Show("You must register the manga information to calculate the total of your purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtAutor.Text = "";
            txtGenre.Text = "";
            comboBoxEditorial.Text = "";
            txtVolume.Text = "";
            lblTotal.Text = "";
            txtQuantity.Text = "";
        }

       
    }
}
