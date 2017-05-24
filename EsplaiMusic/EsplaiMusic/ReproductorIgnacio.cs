using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Librerias Windows Media Player

// para archivos WAV
using System.Media;

// para archivos mp3
using WMPLib;

namespace EsplaiMusic
{
    public partial class ReproductorIgnacio : Form
    {
        //MP3
        private WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        //WAV
        private SoundPlayer sp = new SoundPlayer();

        public ReproductorIgnacio()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            browseMusic();
        }

        private void browseMusic()
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string rutaCancion = opf.FileName;
                int index = rutaCancion.IndexOf(".");
                string tipoCancion = rutaCancion.Substring(index + 1, 3);

                //ruta del archivo en el textbox de prueba
                textBox1.Text = rutaCancion;

                if (tipoCancion.Equals("mp3"))
                {
                    reproducirMP3(rutaCancion);
                }
                else if (tipoCancion.Equals("wav"))
                {
                    reproducirWAV(rutaCancion);
                }
                else
                {
                    MessageBox.Show("Archivo seleccionado con formato no válido!");
                }
            }
        }

        private void reproducirMP3(string rutaCancion)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            wplayer.URL = rutaCancion;
            wplayer.controls.play();
        }

        private void reproducirWAV(string rutaCancion)
        {
            sp.SoundLocation = rutaCancion;
            sp.Play();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stopMusic();
        }

        private void play_Click(object sender, EventArgs e)
        {
            wplayer.controls.play();
            sp.Play();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            pauseMusic();
        }

        private void stopMusic()
        {
            wplayer.controls.stop();
            sp.Stop();
        }

        private void pauseMusic()
        {
            wplayer.controls.pause();
        }
    }
}
