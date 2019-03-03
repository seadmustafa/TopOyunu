using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace topoyunu
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
        }
        
        public string oyuncuAdi;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (textBox1.Text == "")
                MessageBox.Show("Oyuncu adi bos olamaz !!!", "Uyarii !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                oyuncuAdi = textBox1.Text;
                playground pg = new playground();
                pg.Show();
                Bitis bts = new Bitis();
                bts.strDoldur(oyuncuAdi);
                this.Hide();
            }
        }

       
    }
}
