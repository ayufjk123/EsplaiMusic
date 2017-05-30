using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Libreria Windows Media Player para archivos mp3
using WMPLib;

using System.Media;


namespace ReproductorMusica
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public Form1()
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
            opf.Multiselect = true;
            opf.Filter = "MP3 Audio Files (*.mp3) | *.mp3;";

            //Lista de reproduccion
            IWMPPlaylist playlist = wmp.playlistCollection.newPlaylist("listaReproduccion");
            wmp.settings.volume = 50;
            wmp.settings.autoStart = false;
            IWMPMedia media;

            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in opf.FileNames)
                {
                    media = wmp.newMedia(file);
                    playlist.appendItem(media);
                    lista.Items.Add(media.name);
                }
            }

            wmp.currentPlaylist = playlist;
            //reproducirMP3();

            ////Obtener el tiempo de duracion de la cancion en segundos
            //int duracionSegundos = Convert.ToInt32(wmp.controls.currentItem.duration);

            //string duracionFormateada = wmp.controls.currentItem.durationString;
            //MessageBox.Show(duracionFormateada + " segundos");
            //MessageBox.Show(duracionFormateada);

            // Calculo del tiempo  en minutos:segundos
            /*StringBuilder sb = new StringBuilder();

            int minutos = 0;
            int segundos = 0;

            while (duracionSegundos >= 60)
            {
                duracionSegundos -= 60;
                minutos++;
            }

            sb.Append(minutos + ":");

            segundos = duracionSegundos;

            if (segundos < 10)
            {
                sb.Append("0");
            }
            sb.Append(segundos);
            MessageBox.Show(sb.ToString());*/
        }

        private void reproducirMP3()
        {
            wmp.controls.play();
            this.play.Visible = false;
            this.pause.Visible = true;
            //Obtener el tiempo de duracion de la cancion en segundos
            obtenerDuracion();
        }

        private void stopMusic()
        {
            wmp.controls.stop();
            this.pause.Visible = false;
            this.play.Visible = true;
            resetDuracion();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stopMusic();
        }

        private void play_Click(object sender, EventArgs e)
        {
            reproducirMP3();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            pauseMusic();
        }

        private void pauseMusic()
        {
            wmp.controls.pause();
            this.pause.Visible = false;
            this.play.Visible = true;            
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            wmp.controls.next();
            obtenerDuracion();
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            wmp.controls.previous();
            obtenerDuracion();
        }

        private void mute_Click(object sender, EventArgs e)
        {
            wmp.settings.volume = 0;
            this.mute.Visible = false;
            this.unmute.Visible = true;
        }

        private void unmute_Click(object sender, EventArgs e)
        {
            wmp.settings.volume = volumen.Value;
            this.unmute.Visible = false;
            this.mute.Visible = true;            
        }

        private void volumen_ValueChanged(object sender, decimal value)
        {
            if (this.unmute.Visible == false)
            {
                wmp.settings.volume = volumen.Value;
            }            
        }

        private void unrepeat_Click(object sender, EventArgs e)
        {
            this.norepeat.Visible = false;
            this.repeat.Visible = true;
            wmp.settings.autoStart = true;
        }

        private void repeat_Click(object sender, EventArgs e)
        {
            this.repeat.Visible = false;
            this.norepeat.Visible = true;
            wmp.settings.autoStart = false;
        }
        private void obtenerDuracion()
        {
            int duracionSegundos = Convert.ToInt32(wmp.controls.currentItem.duration);
            duracionCancion.Maximum = duracionSegundos;

            string duracionFormateada = wmp.controls.currentItem.durationString;
            label1.Text=duracionFormateada;
        }
        private void resetDuracion()
        {
            label1.Text = "00:00";
        }
    }
}
