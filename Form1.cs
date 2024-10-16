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

        private void urlLänk(object sender, EventArgs e)
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

        private void LäggTillPodd_Click(object sender, EventArgs e)
        {
            String rssUrl = UrlLänk.Text;
            if (string.IsNullOrEmpty(rssUrl))
            {
                MessageBox.Show("Ange en giltig URL.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
            MessageBox.Show("clicka Här", "" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
        }
    }
}
