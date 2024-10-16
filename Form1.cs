using System;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using System.Net.Http;
using System.Xml;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PodApp
{
    public partial class Form1 : Form
    {
        private XmlDocument rssDoc;
        private XmlNodeList rrsItems;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void urlLänk(object sender, EventArgs e)
        {
            String rssUrl = UrlLänk.Text;
            if (string.IsNullOrEmpty(rssUrl))
            {
                MessageBox.Show("Ange en giltig URL.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Table(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KategoriNamnTextBox(object sender, EventArgs e)
        {
            // den här ska hämta vald kategori från kategoricomboboxen och sen kunna ändra vald kategori i en array
            // vi skulle även här kunna lagra användarens preferenser i en xml eller json och sen läsa in i en array enkelt
        }

        private void LäggTillPodd_Click(object sender, EventArgs e)
        {
            string rssUrl = UrlLänk.Text;
            string namn = AngeNamn.Text;

            try
            {

                XmlDocument rssDoc = new XmlDocument();

                // Läs RSS från URL
                rssDoc.Load(rssUrl);


                XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

                //// Rensa DataGridView innan vi lägger till nya data
                //dataGridView.Rows.Clear();

                foreach (XmlNode item in rssItems)
                {
                    string title = item.SelectSingleNode("title")?.InnerText;
                    string description = item.SelectSingleNode("description")?.InnerText;
                    string pubDate = item.SelectSingleNode("pubDate")?.InnerText;


                    int rowIndex = dataGridView.Rows.Add();

                    dataGridView.Rows[rowIndex].Cells[0].Value = namn;
                    dataGridView.Rows[rowIndex].Cells[1].Value = title;
                    dataGridView.Rows[rowIndex].Cells[2].Value = pubDate;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Fel vid bearbetning av RSS: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ÄndraPodd_Click(object sender, EventArgs e)
        {

        }

        private void VäljKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LäggTillKategori_Click(object sender, EventArgs e)
        {
            string namnPåKategori = NamnPåKategori.Text.Trim();



            if (!string.IsNullOrEmpty(namnPåKategori))
            {
                // Skapa en ny Label
                Label newLabel = new Label();
                newLabel.Text = namnPåKategori;
                newLabel.AutoSize = true;


                KategoriGroupBox.Controls.Add(newLabel);
                NamnPåKategori.Clear();
            }
            else
            {
                MessageBox.Show("Vänligen skriv något innan du lägger till!", "Inmatningsfel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Avsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AvsnittInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void KategoriGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FiltreringsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TaBortPodd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicka Här", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Återställa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vill du verkligen återställa sidan?", "Action-varning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void AktuellKategori_Click(object sender, EventArgs e)
        {

        }

        private void LabelNamn_Click(object sender, EventArgs e)
        {

        }

        private void LabelCategory_Click(object sender, EventArgs e)
        {

        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {

        }

        private void LabelUrl_Click(object sender, EventArgs e)
        {

        }

        private void LabelGetFeed_Click(object sender, EventArgs e)
        {

        }

        private void LabelPodcastDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
