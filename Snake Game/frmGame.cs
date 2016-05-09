using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Media;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Snake_Game
{
    public partial class frmGame : Form
    {
        public SqlConnection Bag = new SqlConnection("Data Source=.;Initial Catalog=c#yilan;Integrated Security=True");
       
        public frmGame()
        {
            InitializeComponent();

        }

        #region Yılan Ayar
        PictureBox[] yilanbolme = new PictureBox[4]; 
        int SonParca = 0; 
        int IlkParca = 0; 
        bool durum = false; 
        bool carpma = false;

        private void yilanOlustur() 
        {
            yilanbolme = new PictureBox[4];
            for (int i = 0; i < yilanbolme.Length; i++)
            {
                yilanbolme[i] = new PictureBox();
                yilanbolme[i].Width = 15;
                yilanbolme[i].Height = 15;
                yilanbolme[i].Top = 0;
                yilanbolme[i].Left = i * (yilanbolme[i].Width + 1);
                yilanbolme[i].BackColor = Color.Green;
                pbGame.Controls.Add(yilanbolme[i]);
            }
            IlkParca = yilanbolme.Length - 1;
        }

        private void YilanSil()
        {//remove silme işlemini yapar
            for (int i = 0; i < yilanbolme.Length; i++)
            {
                pbGame.Controls.Remove(yilanbolme[i]);
            }
        }

        private void YilanBolmeEkle()
        {
            //Array.Resize(ref dizi, yeniboyut);
            Array.Resize(ref yilanbolme, yilanbolme.Length + 1);
            yilanbolme[yilanbolme.Length - 1] = new PictureBox();
            yilanbolme[yilanbolme.Length - 1].Width = 15;
            yilanbolme[yilanbolme.Length - 1].Height = 15;
            yilanbolme[yilanbolme.Length - 1].Top = -20;
            yilanbolme[yilanbolme.Length - 1].Left = -20;
            yilanbolme[yilanbolme.Length - 1].BackColor = Color.Green;
            pbGame.Controls.Add(yilanbolme[yilanbolme.Length - 1]);
        }

        public void kayitEkle()
        {
            try
            {
                Bag.Open();
                string ekle = string.Format("insert into highscore (score , kullaniciAdi) values('{0}','{1}')", Score, KullaniciAdi.kullanici);
                SqlCommand kmt = new SqlCommand(ekle, Bag);
                kmt.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata:" + hata.Message);
            }
            finally
            {
                Bag.Close();
            }
        }


        #region highscore
        private void highscore_karsilastirma()
        {
           
            
            Bag.Open();
            string kayit = "select Max(score) as MaxScore  from highscore";
            SqlCommand kmt = new SqlCommand(kayit, Bag);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                lblHighScore.Text = dr["MaxScore"].ToString();
            }
            else MessageBox.Show("hata");

            int highscore = Convert.ToInt32(dr["MaxScore"]);

            if (Score > highscore)
            {
                highscore = Score;
                lblHighScore.Text = highscore.ToString();
          
             
            }

            
          
            Bag.Close();

        }

        #endregion

        private void carpmaKontrol() 
        {
            for (int i = 0; i < yilanbolme.Length; i++) 
            {
                //Math.Abs değeri mutlak değer yapar
                float mutlakX = Math.Abs((yilanbolme[IlkParca].Left + (yilanbolme[IlkParca].Width / 2)) - (yilanbolme[i].Left + (yilanbolme[i].Width / 2)));
                float mutlakY = Math.Abs((yilanbolme[IlkParca].Top + (yilanbolme[IlkParca].Height / 2)) - (yilanbolme[i].Top + (yilanbolme[i].Height / 2)));
                float farkGenislik = (yilanbolme[IlkParca].Width / 2) + (yilanbolme[i].Width / 2);
                float farkYukselik = (yilanbolme[IlkParca].Height / 2) + (yilanbolme[i].Height / 2);
                if ((farkGenislik > mutlakX) && (farkYukselik > mutlakY) && i != IlkParca)
                {
                    carpma = true;
                    break;
                }
            }

            if (yilanbolme[IlkParca].Left >= pbGame.Width - yilanbolme[IlkParca].Width)
            {
                carpma = true;
            }
            else if (yilanbolme[IlkParca].Top >= pbGame.Height - yilanbolme[IlkParca].Height)
            {
                carpma = true;
            }
            else if (yilanbolme[IlkParca].Top <= -1)
            {
                carpma = true;
            }
            else if (yilanbolme[IlkParca].Left <= -1)
            {
                carpma = true;
            }

            if (carpma)
            {
                frmHighScore frm = new frmHighScore();
                durum = false;
                tmrGoSnake.Enabled = false;
                baslabutton.Visible = true;
                highschorebutton.Visible = true;
                ayarbutton.Visible = true;
                hakkındabutton.Visible = true;
                kayitEkle();
                highscore_karsilastirma();
                frm.Show();
               //kullanıcı oyundan çıkmadan devam etmek isterse aynı kullanıcı adıyla devamm edebilmesi için
                KullaniciAdi.kullanici = KullaniciAdi.kullanici;
        
            }
        }

        int GoLeft = 0, GoTop = 0; 
        private void YilanHareket(int top, int left)
        {
            yilanbolme[SonParca].Left = yilanbolme[IlkParca].Left + left;
            yilanbolme[SonParca].Top = yilanbolme[IlkParca].Top + top;

            if (SonParca == yilanbolme.Length - 1)
            {
                SonParca = 0;
                IlkParca = yilanbolme.Length - 1;
            }
            else
            {
                SonParca++;
                IlkParca = SonParca - 1;
            }
        }

        #endregion

        #region Yem Ayarları
        Random r = new Random();
        PictureBox Yem;
      public  int Score = 0;

        private void YemOlustur()
        {
            int YemUst = 16 * r.Next(1, 30);
            int YemSol = 16 * r.Next(1, 30);
            Yem = new PictureBox();
            Yem.Width = 15;
            Yem.Height = 15;
            Yem.Left = YemSol;
            Yem.Top = YemUst;
            Yem.BackColor = Color.Red;
            pbGame.Controls.Add(Yem);
        }

        bool YemYe = false;
        private void YemYemeKontrol()
        {
            float mutlakX = Math.Abs((yilanbolme[IlkParca].Left + (yilanbolme[IlkParca].Width / 2)) - (Yem.Left + (Yem.Width / 2)));
            float mutlakY = Math.Abs((yilanbolme[IlkParca].Top + (yilanbolme[IlkParca].Height / 2)) - (Yem.Top + (Yem.Height / 2)));
            float farkGenislik = (yilanbolme[IlkParca].Width / 2) + (Yem.Width / 2);
            float farkYukselik = (yilanbolme[IlkParca].Height / 2) + (Yem.Height / 2);
            if ((farkGenislik > mutlakX) && (farkYukselik > mutlakY))
            {
                YemYe = true;
            }

            if (YemYe)
            {

                YilanBolmeEkle();
                Score += 10;
                lblScore.Text = "Score : " + Score.ToString();
                YemSil();
                YemOlustur();
                YemYe = false;
            }
        }

        private void YemSil()
        {
            pbGame.Controls.Remove(Yem);
        }

        #endregion   

        #region Form Events && Kısayollar
        private void frmGame_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.S)
            {
                frmHighScore frm = new frmHighScore();
                frm.Show();
            }

           
            if (e.KeyCode == Keys.Y)
            {
                yeniOyunToolStripMenuItem.PerformClick();
                baslabutton.Visible = false;
                highschorebutton.Visible = false;
                ayarbutton.Visible = false;
                hakkındabutton.Visible = false;
            }

            if (e.KeyCode == Keys.D)
            {
                if (durum || duraklatToolStripMenuItem.Text == "Devam Et")
                {
                    if (duraklatToolStripMenuItem.Text == "Duraklat")
                    {
                        tmrGoSnake.Enabled = false;
                        durum = false;
                        duraklatToolStripMenuItem.Text = "Devam Et";
                    }
                    else
                    {
                        tmrGoSnake.Enabled = true;
                        durum = true;
                        duraklatToolStripMenuItem.Text = "Duraklat";
                    }
                }   
            }
            if (e.KeyCode == Keys.H)
            {
                frmAbout frmA = new frmAbout();
                frmA.ShowDialog();
            }

            if (durum) 
            {
                if (e.KeyCode == Keys.Right)
                {
                    GoTop = 0;
                    GoLeft = 16;
                   
                }
                else if (e.KeyCode == Keys.Left )
                {
                    GoTop = 0;
                    GoLeft = -16;
                    
                }
                else if (e.KeyCode == Keys.Up )
                {
                    GoLeft = 0; 
                    GoTop = -16;
                    
                }
                else if (e.KeyCode == Keys.Down )
                {
                    GoLeft = 0; 
                    GoTop = 16;
                    
                }  
            }                  
        }

        private void tmrGoSnake_Tick(object sender, EventArgs e)
        {
            if (durum)
            {
                YilanHareket(GoTop, GoLeft);
                carpmaKontrol();
                YemYemeKontrol();
            }                  
        }

        #endregion

        #region MenuStrip Events
        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            baslabutton.Visible = false;
            highschorebutton.Visible = false;
            ayarbutton.Visible = false;
            hakkındabutton.Visible = false;
            duraklatToolStripMenuItem.Text = "Duraklat";
            lblScore.Text = "Score : 0";
            Score = 0;
            YemYe = false;
            GoLeft = 16; GoTop = 0;

            carpma = false;
            durum = true;
            SonParca = 0;

            YilanSil();
            yilanOlustur();

            YemSil();
            YemOlustur();

            tmrGoSnake.Enabled = true;   
           
                
        }

        private void duraklatToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (durum || duraklatToolStripMenuItem.Text == "Devam Et") 
            {
                if (duraklatToolStripMenuItem.Text == "Duraklat")
                {
                    tmrGoSnake.Enabled = false;
                    durum = false;
                    duraklatToolStripMenuItem.Text = "Devam Et";
                }
                else
                {
                    tmrGoSnake.Enabled = true;
                    durum = true;
                    duraklatToolStripMenuItem.Text = "Duraklat";
                }  
            }                       
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmAbout frmA = new frmAbout();
            frmA.ShowDialog();
        }

        #endregion 

        #region form Load 
        private void frmGame_Load(object sender, EventArgs e)
        {
            KullaniciAdi frmkul = new KullaniciAdi();

            frmses frm = new frmses(); 
            frmkul.Show();
          //frmGame arka tarafta frmkul onde olsun diye        
            frmkul.Owner = this;
            frm.Show();
            frm.Visible = false;
            sesAyarıToolStripMenuItem.Visible = false;
            highscore_karsilastirma();


        }
        #endregion

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void sesAyarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmses frm = new frmses();
            frm.Show();
            frm.Visible = true;
           
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeniOyunToolStripMenuItem.PerformClick();
            baslabutton.Visible = false;
            highschorebutton.Visible = false;
            ayarbutton.Visible = false;
            hakkındabutton.Visible = false;
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmses frms = new frmses();
            frms.ShowDialog();
        }

        private void hakkındabutton_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void highschorebutton_Click(object sender, EventArgs e)
        {
            frmHighScore frm = new frmHighScore();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            
    }
}
