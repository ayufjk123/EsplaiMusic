using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Libreria Windows Media Player para archivos mp3
using WMPLib;

// Libreria usada para crear y guardar objetos de tipo Media (reproducibles)
using System.Media;


namespace ReproductorMusica
{
    public partial class Form1 : Form
    {
        // Objeto para trabajar con el reproductor de musica y sus métodos
        private static WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        // Este objeto es la lista de reproduccion. Lo creamos para agregarle las canciones elegidas
        private static IWMPPlaylist playlist = wmp.playlistCollection.newPlaylist("listaReproduccion");

        // Objeto utilizado para buscar y seleccionar la musica a través del explorador de windows
        private OpenFileDialog opf = new OpenFileDialog();

        // Objeto media utilizado para referirse a la cancion actual y trabajar con ella
        private IWMPMedia media;

        public Form1()
        {
            InitializeComponent();

            /* Configuramos el objeto para el explorador de archivos 
            para que permita seleccionar más de una canción a la vez */
            opf.Multiselect = true;

            /* Aplicamos un filtro para que el objeto del explorador de archivos 
            solo permita seleccionar archivos de tipo MP3 */
            opf.Filter = "MP3 Audio Files (*.mp3) | *.mp3;";            
            
            // Ajustamos el valor de la barra de volumen por defecto en 50 (la mitad)
            wmp.settings.volume = 50;
            // Configuramos que la reproducción automática (repetición) para que esté desactivada por defecto
            wmp.settings.autoStart = false;
        }

        /* #####################
           ##     Eventos     ##
           ##################### */
        
        // Evento click del boton para buscar las canciones con el explorador de archivos
        private void browse_Click(object sender, EventArgs e)
        {
            addMusic();
        }

        // Evento click del boton stop
        private void stop_Click(object sender, EventArgs e)
        {
            stopMusic();
        }

        // Evento click del boton play
        private void play_Click(object sender, EventArgs e)
        {
            playMusic();
        }

        // Evento click del boton pause
        private void pause_Click(object sender, EventArgs e)
        {
            pauseMusic();
        }

        // Evento click del boton siguiente canción
        private void siguiente_Click(object sender, EventArgs e)
        {
            nextMusic();
        }

        // Evento click del boton anterior canción
        private void anterior_Click(object sender, EventArgs e)
        {
            previousMusic();
        }

        // Evento click del boton para silenciar el reproductor
        private void mute_Click(object sender, EventArgs e)
        {
            muteMusic();
        }

        // Evento click del boton para quitar el silencio del reproductor
        private void unmute_Click(object sender, EventArgs e)
        {
            unmuteMusic();            
        }

        // Evento para gestionar el cambio de volumen de la barra de volumen
        private void volumen_ValueChanged(object sender, decimal value)
        {
            changeVolume();                       
        }

        // Evento click del boton para activar la repeticón de la canción (NOTA: de momento no funciona)
        private void unrepeat_Click(object sender, EventArgs e)
        {
            noRepeatMusic();
        }

        // Evento click del boton para desactivar la repeticón de la canción (NOTA: de momento no funciona)
        private void repeat_Click(object sender, EventArgs e)
        {
            repeatMusic();
        }

        /* #####################
           ##     Métodos     ##
           ##################### */

        /* Método para abrir el explorador de archivos y seleccionar 
        las canciones que queremos agregar a la lista de reproducción */
        private void addMusic()
        {
            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in opf.FileNames)
                {
                    /* Le decimos que por cada cancion elegida la guarde en el objeto media 
                       y luego la añada a la lista de reproduccion */
                    media = wmp.newMedia(file);
                    playlist.appendItem(media);

                    // Lista del formulario para mostrar los nombres de las canciones elegidas
                    lista.Items.Add(media.name);
                }
            }
            // Asociamos la lista de reproducción al objeto que reproduce la musica
            wmp.currentPlaylist = playlist;
        }

        // Método para reproducir la música
        private void playMusic()
        {
            wmp.controls.play();
            this.play.Visible = false;
            this.pause.Visible = true;            
            obtenerDuracion();
        }

        // Método para parar la música
        private void stopMusic()
        {
            wmp.controls.stop();
            this.pause.Visible = false;
            this.play.Visible = true;
            resetDuracion();
        }

        // Método para pausar la música
        private void pauseMusic()
        {
            wmp.controls.pause();
            this.pause.Visible = false;
            this.play.Visible = true;
        }

        // Método para cambiar a la siguiente canción de la lista de reproducción
        private void nextMusic()
        {
            wmp.controls.next();
            obtenerDuracion();
        }

        // Método para cambiar a la anterior canción de la lista de reproducción
        private void previousMusic()
        {
            wmp.controls.previous();
            obtenerDuracion();
        }

        // Método para silenciar el reproductor
        private void muteMusic()
        {
            wmp.settings.volume = 0;
            this.mute.Visible = false;
            this.unmute.Visible = true;
        }

        // Método des-silenciar el reproductor
        private void unmuteMusic()
        {
            wmp.settings.volume = volumen.Value;
            this.unmute.Visible = false;
            this.mute.Visible = true;
        }

        /* Método para repetir la música de la lista una vez se termina de reproducir 
        (NOTA: música o de la canción aún no se sabe) */
        private void repeatMusic()
        {
            wmp.settings.volume = volumen.Value;
            this.repeat.Visible = false;
            this.norepeat.Visible = true;
        }

        /* Método para dejar de repetir la música de la lista una vez se termina de reproducir 
        (NOTA: música o de la canción aún no se sabe) */
        private void noRepeatMusic()
        {
            wmp.settings.volume = volumen.Value;
            this.norepeat.Visible = false;
            this.repeat.Visible = true;
        }

        // Método cambiar el volumen del reproductor cuando se ajusta a través de la barra de volumen
        private void changeVolume()
        {
            if (this.unmute.Visible == false)
            {
                wmp.settings.volume = volumen.Value;
            }
        }

        // Método para obtener el tiempo de duracion de la cancion en formato MM:SS
        private void obtenerDuracion()
        {
            int duracionSegundos = Convert.ToInt32(wmp.controls.currentItem.duration);
            duracionCancion.Maximum = duracionSegundos;

            string duracionFormateada = wmp.controls.currentItem.durationString;
            label1.Text = duracionFormateada;
        }

        // Método para devolver el valor del label de la duracion total de la cancion a su valor por defecto
        private void resetDuracion()
        {
            label1.Text = "00:00";
        }
    }
}
