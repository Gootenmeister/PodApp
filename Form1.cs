using System;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using System.Net.Http;
using System.Xml;

namespace PodApp
{
    public partial class Form1 : Form
    {
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

        private void urlL�nk(object sender, EventArgs e)
        {
            
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

        }

        private void L�ggTillPodd_Click(object sender, EventArgs e)
        {
            String rssUrl = UrlL�nk.Text;
            if (string.IsNullOrEmpty(rssUrl))
            {
                MessageBox.Show("Ange en giltig URL.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
            MessageBox.Show("clicka H�r", "" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
        }
    }
}
