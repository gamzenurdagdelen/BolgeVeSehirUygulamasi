using System;
using System.Windows.Forms;

namespace BölgeVeŞehirUygulaması
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Ana form yüklenirken hiçbir işlem yapmıyoruz.
        }


        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BölgeleriListeleForm bölgeleriListeleForm = new BölgeleriListeleForm();
            bölgeleriListeleForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ŞehirleriListeleForm şehirleriListeleForm = new ŞehirleriListeleForm();
            şehirleriListeleForm.Show();
        }
    }
}
