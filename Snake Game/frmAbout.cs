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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            label1.Text = "Gizem\'in C# Dönem Sonu Uygulaması :) \n\nOyun yön tuşları ile oynanmaktadır\nKısayol" +
    "lar\nYeni --> Y\nDuraklat --> D\nHakkında --> H\nScore Tablosu -->S ";
        }

       

    }
}
