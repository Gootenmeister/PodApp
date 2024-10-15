using System;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du klickade på kebabknappen =)", "Nämen!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            string resourceName = "PodApp.hamburger.wav";

            try
            {
                using (Stream stream = assembly.GetManifestResourceStream(resourceName)) //jobbigt att få med fil till build dir
                {
                    if (stream != null)
                    {
                        //soundplayer objekt
                        SoundPlayer player = new SoundPlayer(stream);

                        player.Play();
                        MessageBox.Show("hamburger", "hamburger", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        MessageBox.Show("hittade inte .wav-filen");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Något gick fel: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tryck inte på 'Yes'", "Öh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(">:(", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
