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
    public partial class playground : Form
    {
        public playground()
        {
            InitializeComponent();
        }
        public int x = 1;
        public int y = 1;
        public int snc = 0;
        public PictureBox [,]p=new PictureBox[5,5];
        public void tablo_olustur() { 
            for(int i = 0; i < 5; i++)
            { 
                for(int j=0; j<5;j++)
                {
                    p[i,j]=new PictureBox();
                    p[i,j].SetBounds(i*100+200, j*30+30, 100, 30);
                    p[i,j].Parent = pg;
                    p[i,j].Name = "picturebox" + (i+j).ToString();
                    if(i%2==1)
                        p[i, j].BackColor = Color.Blue;
                    else
                        p[i, j].BackColor = Color.Yellow;
                    pg.Controls.Add(p[i,j]);
                }
            }

        }
        public void kontrol(PictureBox p)
        {
            
            label1.Text = snc.ToString();
            
            //topun sag blogu
            if (top.Right == p.Left)
            {
                if (top.Location.Y >= p.Location.Y && top.Location.Y <= (p.Location.Y + p.Height))
                { p.Visible = false; x *= -1; p.Location = new Point(0, 0); snc++;
                Random r = new Random();
                pg.BackColor = Color.FromArgb(r.Next(10, 150), r.Next(100, 200), r.Next(150, 250));
                }
            }
            if (top.Right == p.Left)
            {
                if ((top.Location.Y + top.Height) >= p.Location.Y && (top.Location.Y + top.Height) <= (p.Location.Y + p.Height))
                {
                    {
                        p.Visible = false; x *= -1; p.Location = new Point(0, 0); snc++; 
                        Random r = new Random();
                        pg.BackColor = Color.FromArgb(r.Next(10, 150), r.Next(100, 200), r.Next(150, 250));
                    }
                }
            }
            // topun sol blogu
            if (top.Left == p.Right)
            {
                if (top.Location.Y >= p.Location.Y && top.Location.Y <= (p.Location.Y + p.Height))
                { p.Visible = false; x *= -1; p.Location = new Point(0, 0); snc++;
                Random r = new Random();
                pg.BackColor = Color.FromArgb(r.Next(10, 150), r.Next(100, 200), r.Next(150, 250));
                }
            }
            if (top.Left == p.Right)
            {
                if ((top.Location.Y + top.Height) >= p.Location.Y && (top.Location.Y + top.Height) <= (p.Location.Y + p.Height))
                {
                    {
                        p.Visible = false; x *= -1; p.Location = new Point(0, 0); snc++;
                        Random r = new Random();
                        pg.BackColor = Color.FromArgb(r.Next(10, 150), r.Next(100, 200), r.Next(150, 250));
                    }
                }
            }

            //topun alt blogu
            if (top.Bottom == p.Top)
            {
                if (top.Location.X >= p.Location.X && top.Location.X <= (p.Location.X + p.Width))
                { p.Visible = false; y *= -1; p.Location = new Point(0, 0); snc++;
                Random r = new Random();
                pg.BackColor = Color.FromArgb(r.Next(10, 150), r.Next(100, 200), r.Next(150, 250));
                }
            }
            if (top.Bottom == p.Top)
            {
                if ((top.Location.X + top.Width) >= p.Location.X && (top.Location.X + top.Width) <= (p.Location.X+ p.Width))
                {
                    { p.Visible = false; y *= -1; p.Location = new Point(0, 0); snc++;
                    Random r = new Random();
                    pg.BackColor = Color.FromArgb(r.Next(10, 150), r.Next(100, 200), r.Next(150, 250));
                    }
                }
            }

            //ust blog
            if (top.Top== p.Bottom)
            {
                if (top.Location.X >= p.Location.X && top.Location.X <= (p.Location.X + p.Width))
                { p.Visible = false; y *= -1; p.Location = new Point(0, 0); snc++;
                Random r = new Random();
                pg.BackColor = Color.FromArgb(r.Next(10, 150), r.Next(100, 200), r.Next(150, 250));
                }
            }
            if (top.Top == p.Bottom)
            {
                if ((top.Location.X + top.Width) >= p.Location.X && (top.Location.X + top.Width) <= (p.Location.X + p.Width))
                {
                    {
                        p.Visible = false; y *= -1; p.Location = new Point(0, 0); snc++;
                        Random r = new Random();
                        pg.BackColor = Color.FromArgb(r.Next(10, 150), r.Next(100, 200), r.Next(150, 250));
                    }
                }
            }
        }
        private void tophareket_Tick(object sender, EventArgs e)
        {
            
            top.Location = new Point(top.Location.X + x, top.Location.Y + y);
            
        }

        private void playground_Load(object sender, EventArgs e)
        {
            tablo_olustur();
        }

        private void playground_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                raket.Location = new Point(raket.Location.X + 5, raket.Location.Y);
            if (e.KeyCode == Keys.Left)
                raket.Location = new Point(raket.Location.X - 5, raket.Location.Y);

        }

        private void kontroltimer_Tick(object sender, EventArgs e)
        {
           
            if (top.Right == pg.Right)
                x *= -1;
            if (top.Left == pg.Left)
                x *= -1;
            if (top.Top == pg.Top)
                y *= -1;
            if (raket.Top == top.Bottom && top.Bottom <= raket.Bottom && top.Left >= raket.Left && top.Right <= raket.Right)
                y *= -1;
            if (top.Bottom >= pg.Bottom)
            {
                tophareket.Enabled = false;
                kontroltimer.Enabled = false;
                Bitis bts = new Bitis();
                bts.doldur(snc);
                bts.ShowDialog();
            }
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    kontrol(p[i, j]);
                }
            }
            
        }

        
        }
}
