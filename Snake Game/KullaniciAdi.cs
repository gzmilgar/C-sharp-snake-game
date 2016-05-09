using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class KullaniciAdi : Form
    {
        public static string kullanici;
      
        public KullaniciAdi()
        {
            InitializeComponent();
        }
        
 
        private void kullanıcıAdı_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici = textBox1.Text;
          if(kullanici=="")
             MessageBox.Show("Kullanıcı Adını Girmeyi Unuttunuz :)");
         else
            Close();

        }

        private void KullaniciAdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            kullanici = textBox1.Text;
                
        }

     
    }
}
