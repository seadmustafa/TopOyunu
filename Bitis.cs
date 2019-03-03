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
    public partial class Bitis : Form
    {
        public Bitis()
        {
            InitializeComponent();
        }
        
        public int snc=0;
        public string ad;
        public void doldur(int a)
        { snc = a; }
        public void strDoldur(string adi)
        {
            ad = adi;
        }
        private void Bitis_Load(object sender, EventArgs e)
        {
            girisEkrani grs = new girisEkrani();
            label2.Text = snc.ToString();
            if (snc >= 1 && snc < 10)
                label4.Text = " Amatör bir oyuncusunuz !!! ";
            if (snc >= 10 && snc <= 15)
                label4.Text = " İyi bir oyuncusunuz!!! "; 
            if (snc > 15 && snc < 20 )
                label4.Text = " Yetenekli bir oyuncusunuz !!! ";
           if (snc >= 20)
           label4.Text = " Harika bir oyuncusunuz !!!"; 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
