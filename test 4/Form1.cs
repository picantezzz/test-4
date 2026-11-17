using static test_4.factuur;

namespace test_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naam = txtNaamKlant.Text;
            int klantnr = Convert.ToInt32(txtKlantnummer.Text);
            string product = txtProduct.Text;
            int aantal = Convert.ToInt32(txtAantal.Text);
            double prijs = Convert.ToDouble(txtPrijs.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Factuur geselecteerdefactuur = (Factuur)listBox1.SelectedItem;
                
                label7.Text = geselecteerdefactuur.Overzicht() + "Factuurtotaal: " + geselecteerdefactuur.FactuurTotaal() + " euro.";
            }
        }
        private void btnpasaantalaan_Click(object sender, EventArgs e)
        {

        }
    }
}
