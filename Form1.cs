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

        public void urlL�nk(object sender, EventArgs e)
        {
            String rssUrl = UrlL�nk.Text;
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
            // den h�r ska h�mta vald kategori fr�n kategoricomboboxen och sen kunna �ndra vald kategori i en array
            // vi skulle �ven h�r kunna lagra anv�ndarens preferenser i en xml eller json och sen l�sa in i en array enkelt
        }

        private void L�ggTillPodd_Click(object sender, EventArgs e)
        {
            string rssUrl = UrlL�nk.Text;
            string namn = AngeNamn.Text;

            try
            {

                XmlDocument rssDoc = new XmlDocument();

                // L�s RSS fr�n URL
                rssDoc.Load(rssUrl);


                XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

                //// Rensa DataGridView innan vi l�gger till nya data
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

        private void �ndraPodd_Click(object sender, EventArgs e)
        {

        }

        private void V�ljKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void L�ggTillKategori_Click(object sender, EventArgs e)
        {
            string namnP�Kategori = NamnP�Kategori.Text.Trim();



            if (!string.IsNullOrEmpty(namnP�Kategori))
            {
                // Skapa en ny Label
                Label newLabel = new Label();
                newLabel.Text = namnP�Kategori;
                newLabel.AutoSize = true;


                KategoriGroupBox.Controls.Add(newLabel);
                NamnP�Kategori.Clear();
            }
            else
            {
                MessageBox.Show("V�nligen skriv n�got innan du l�gger till!", "Inmatningsfel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            MessageBox.Show("clicka H�r", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void �terst�lla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vill du verkligen �terst�lla sidan?", "Action-varning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
