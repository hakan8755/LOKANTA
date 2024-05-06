using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOKANTA
{
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UrunAdmin gec = new UrunAdmin();
            gec.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MasalarForm masalarForm = new MasalarForm();
            masalarForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Mutfak gec = new Mutfak();
            gec.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Personeller gec = new Personeller();
            gec.Show();
        }
    }
}
