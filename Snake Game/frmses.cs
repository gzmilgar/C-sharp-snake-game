using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class frmses : Form
    {
       
        public frmses()
        {
            InitializeComponent();

            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            trackBar1.Value = CalcVol / (ushort.MaxValue / 10);
        }


        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume
        (IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume
        (IntPtr hwo, uint dwVolume);
        
        
            

        private void frmses_Load(object sender, EventArgs e)
        {
           
                SoundPlayer player = new SoundPlayer();
                string path = "C:\\Users\\GZM\\Desktop\\icon\\Yeni klasör\\fon.wav";
                // Müzik adresi 
                player.SoundLocation = path;
                player.Play();
            
        }
    
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

            int NewVolume = ((ushort.MaxValue / 10) * trackBar1.Value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
            /*
             * Burada da öncelikle ayarlanan ses değeri hesaplanıyor, 
             * bu ses değeri sağ ve sol kanallara ayarlanıyor, 
             * sonra da bu değerler ses olarak atanıyor.
             */
        }

     


    }
}
