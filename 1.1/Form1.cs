namespace _1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPloegAanmaken_Click(object sender, EventArgs e)
        {
            if (txtNaamPloeg.Text != "")
            {
                Ploeg objPloeg = new Ploeg(txtNaamPloeg.Text);
                lstPloegen.Items.Add(objPloeg);
                txtNaamPloeg.Text = "";
            }
            else
            {
                MessageBox.Show("Fout! Geen naam ingevuld voor de ploeg.", "Foutmelding", MessageBoxButtons.OK);
            }
        }

        private void lstPloegen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPloegen.Items != null)
            {
                Ploeg objPloeg = (Ploeg)lstPloegen.SelectedItem;
                lstSpelers.Items.Clear();

                if (lstSpelers.Items != null)
                {
                    foreach (Speler item in objPloeg.Spelers)
                    {
                        lstSpelers.Items.Add(item.ToString());
                    }
                    lblTopSchutter.Text = $"Topschutter: {objPloeg.GeefTopschutter()}";
                    lblTotaalDoelpunten.Text = $"Totaal doelpunten: {objPloeg.BerekenTotaalDoelpunten()}";
                }
            }
        }

        private void btnSpelerToevoegen_Click(object sender, EventArgs e)
        {
            if (txtNaamSpeler.Text != "" && txtRugnummer.Text != "" && lstPloegen.Items != null)
            {
                
            }
            else
            {
                MessageBox.Show("Fout! Geen naam voor de speler of rugnummer ingevuld of ploeg geselecteerd.", "Foutmelding", MessageBoxButtons.OK);
            }
        }








    }
}
