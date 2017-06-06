﻿using System;
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
        // Contador que se utiliza para saber en qué segundo de la canción nos encontramos
        private static int contador = 0;

        // Objeto para trabajar con el reproductor de musica y sus métodos
        private static WindowsMediaPlayer wmp = new WindowsMediaPlayer();        

        // Este objeto es la lista de reproduccion. Lo creamos para agregarle las canciones elegidas
        private static IWMPPlaylist playlist = wmp.playlistCollection.newPlaylist("listaReproduccion");
        private static IWMPPlaylist playlistAux = wmp.playlistCollection.newPlaylist("listaAuxiliar");

        // Objeto utilizado para buscar y seleccionar la musica a través del explorador de windows
        private OpenFileDialog opf = new OpenFileDialog();

        // Objeto media utilizado para referirse a la cancion actual y trabajar con ella
        private IWMPMedia media;

        // Objeto etiqueta que sirve para establecer la etiqueta de cada controlador del reproductor
        private System.Windows.Forms.ToolTip tooltip1 = new System.Windows.Forms.ToolTip();

        // flag para activar o no la repetición de la canción (aún por implementar método alternativo)
        private bool repetir = false;

        public Form1()
        {
            InitializeComponent();
            this.timer1.Interval = 1000;

            /* Configuramos el objeto para el explorador de archivos 
            para que permita seleccionar más de una canción a la vez */
            opf.Multiselect = true;

            /* Aplicamos un filtro para que el objeto del explorador de archivos 
            solo permita seleccionar archivos de tipo MP3 */
            opf.Filter = "MP3 Audio Files (*.mp3) | *.mp3;";            
            
            // Ajustamos el valor de la barra de volumen por defecto en 50 (la mitad)
            wmp.settings.volume = 50;

            toolTip(this.play, "Play");
            toolTip(this.stop, "Stop");
            toolTip(this.pause, "Pause");
            toolTip(this.mute, "Unmute");
            toolTip(this.unmute, "Mute");
            toolTip(this.anterior, "Previous");
            toolTip(this.siguiente, "Next");
            toolTip(this.volumen, "Volume");
            toolTip(this.duracionCancion, "Progress");
            toolTip(this.repeat, "Turn Off Repeat");
            toolTip(this.norepeat, "Turn On  Repeat");
            toolTip(this.randomOn, "Turn Off Random");
            toolTip(this.randomOff, "Turn On Random");

            // Coloca el label movil a la derecha del todo y le pone 1 milisegundo de intervalo a su timer
            labelMovil.Left = this.ClientSize.Width;
            this.timerLabel.Interval = 1;
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
            progress();
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

        // Evento click del botón que hace que la música no se reproduzca de forma aleatoria        
        private void randomOn_Click(object sender, EventArgs e)
        {
            desactivateRandomMusic();            
            this.randomOn.Visible = false;
            this.randomOff.Visible = true;
        }

        // Evento click del botón que hace que se reproduzca la música de forma aleatoria
        private void randomOff_Click(object sender, EventArgs e)
        {
            activateRandomMusic();
            this.randomOff.Visible = false;
            this.randomOn.Visible = true;
        }

        /* Evento del temporizador. Por cada "tick" de éste, ejecuta el método temporizador 
           que contiene el código correspondiente */
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer();
        }

        /* Evento que controla cuando el usuario elige con doble clic 
           la canción a reproducir de la lista de reproducción */
        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            playListDoubleClickSelected(e);
        }

        // Evento que controla cuando una canción termina. No está terminado
        private void wmp_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsTransitioning)
            {
                // contador = 0, reset de la barra a 0 y max value = segundos
                resetProgress();
                // selecciona la siguiente cancion
                selectSongOfList();
                // actualiza la duracion total
                updateDurationLabel();
                // resetea a 00:00 el label del progreso. el otro label está comentado
                resetLabels();
                // comprueba si está activo o no el modo repeticion
            }
        }

        /* Evento que sincroniza la cancion con la barra de progreso 
           cuando el usuario la desplaza */
        private void duracionCancion_Scroll(object sender, EventArgs e)
        {
            updateProgressBar();
        }

        // Evento que ejecuta el metodo que mueve el label con el nombre de la cancion actual
        private void timerLabel_Tick(object sender, EventArgs e)
        {
            moveLabelMovil();
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
            selectSongOfList();
        }

        // Método para reproducir la música
        private void playMusic(bool noplay=false)
        {
           if (!noplay)
            {
                wmp.controls.play();

            }
            this.play.Visible = false;
            this.pause.Visible = true;
            updateDurationLabel();
            selectSongOfList();
            labelMovil.Text = "Reproduciendo " + wmp.currentMedia.name;
            timerLabel.Start();
        }        

        // Método para parar la música
        private void stopMusic()
        {
            wmp.controls.stop();
            this.pause.Visible = false;
            this.play.Visible = true;
            resetLabels();
            this.timer1.Stop();
            resetProgress();
        }

        // Método para pausar la música
        private void pauseMusic()
        {
            wmp.controls.pause();
            this.pause.Visible = false;
            this.play.Visible = true;
            this.timer1.Stop();            
        }

        // Método para cambiar a la siguiente canción de la lista de reproducción
        private void nextMusic()
        {
            wmp.controls.next();
            updateDurationLabel();            
            selectSongOfList();
            resetProgress();
            progress();
            labelMovil.Text = "Reproduciendo " + wmp.currentMedia.name;
        }

        // Método para cambiar a la anterior canción de la lista de reproducción
        private void previousMusic()
        {
            wmp.controls.previous();
            updateDurationLabel();
            selectSongOfList();
            resetProgress();
            progress();
            labelMovil.Text = "Reproduciendo " + wmp.currentMedia.name;
        }

        // Método para silenciar el reproductor
        private void muteMusic()
        {            
            wmp.settings.volume = volumen.Value;
            this.mute.Visible = false;
            this.unmute.Visible = true;
        }

        // Método des-silenciar el reproductor
        private void unmuteMusic()
        {
            wmp.settings.volume = 0;
            this.unmute.Visible = false;
            this.mute.Visible = true;
        }

        /* Método para repetir la música de la lista una vez se termina de reproducir 
        (NOTA: música o de la canción aún no se sabe) */
        private void repeatMusic()
        {
            this.repeat.Visible = false;
            this.norepeat.Visible = true;
            //wmp.settings.setMode("loop", false);
            /*repetir = false;
            playlist = playlistAux;*/
        }

        /* Método para dejar de repetir la música de la lista una vez se termina de reproducir 
        (NOTA: música o de la canción aún no se sabe) */
        private void noRepeatMusic()
        {
            this.norepeat.Visible = false;
            this.repeat.Visible = true;
            //wmp.settings.setMode("loop", true);
            /*repetir = true;
            playlistAux = playlist;*/
        }

        // Método para activar la reproducción de música aleatoria
        private void activateRandomMusic()
        {
            wmp.settings.setMode("shuffle", true);
        }

        // Método para desactivar la reproducción de música aleatoria
        private void desactivateRandomMusic()
        {
            wmp.settings.setMode("shuffle", false);
        }

        // Método cambiar el volumen del reproductor cuando se ajusta a través de la barra de volumen
        private void changeVolume()
        {
            if (this.mute.Visible == false)
            {
                wmp.settings.volume = volumen.Value;
            }
        }

        /* Método para obtener el tiempo de duracion de la cancion en segundos 
           y darle valor Maximum a la barra de duración */
        private int getDurationInSeconds()
        {
            int duracionSegundos = Convert.ToInt32(wmp.controls.currentItem.duration);

            return duracionSegundos;
        }

        /* Método para obtener el tiempo de duracion de la cancion en formato MM:SS 
           y guardarlo en el Label de duracion */
        private void updateDurationLabel()
        {
            string duracionFormateada = wmp.controls.currentItem.durationString;
            label1.Text = duracionFormateada;
        }

        // Método para devolver el valor del label de la duracion total de la cancion a su valor por defecto
        private void resetLabels()
        {
            //label1.Text = "00:00";
            this.playedTimeLabel.Text = "00:00";
        }

        // Método para seleccionar la cancion actual en la lista ListBox
        private void selectSongOfList() {
            int index = lista.FindString(wmp.currentMedia.name);

            if (index != System.Windows.Forms.ListBox.NoMatches) {
                lista.SetSelected(index, true);
            }            
        }

        //Metodo para la barra de progreso
        private void progress()
        {
            this.timer1.Start();
            int segundos = getDurationInSeconds();
            this.duracionCancion.Maximum = segundos;

            //prueba de asignacion del evento de cambio de estado (cuando finaliza la canción)
            wmp.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wmp_PlayStateChange);
        }        

        /* Método del temporizador que aumenta el contador y guarda su valor 
           en la barra de progreso para que ésta incremente */
        private void timer()
        {
            contador++;
            this.duracionCancion.Value = contador;
            updateElapsedTimeLabel();
        }

        // Método que actualiza el label del tiempo reproducido
        private void updateElapsedTimeLabel()
        {
            StringBuilder sb = new StringBuilder();

            int min = 0;
            int sec = contador;

            while (sec >= 60)
            {
                min++;
                sec -= 60;
            }

            if (min < 10)
            {
                sb.Append("0");
            }

            sb.Append(min + ":");

            if (sec < 10)
            {
                sb.Append("0");
            }

            sb.Append(sec);

            playedTimeLabel.Text = sb.ToString();
        }

        /* Método que sincroniza la canción con la barra de progreso 
           cuando el usuario elige en qué segundo quiere reproducir */
        private void updateProgressBar()
        {
            contador = this.duracionCancion.Value;
            wmp.controls.currentPosition = contador;
        }

        // Método para resetar los valores de la barra y del contador de segundos
        private void resetProgress()
        {
            contador = 0;
            duracionCancion.Value = 0;
        }

        /* Método que reproduce la canción elegida por el usuario 
           con doble clic de la lista de reproducción */
        private void playListDoubleClickSelected(MouseEventArgs e)
        {
            int index = this.lista.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                wmp.controls.currentItem = playlist.Item[index];
                resetProgress();
                playMusic();
                progress();
                resetProgress();
            }       
        }

        // Método para actualizar / mover el label movil con el nombre de la canción actual
        private void moveLabelMovil()
        {
            if (labelMovil.Left > (0 - labelMovil.Width))
            {
                labelMovil.Left--;
            }
            else
            {
                labelMovil.Left = ClientSize.Width;
            }
        }

        // Método para asignar etiqueta a un botón/controlador del reproductor
        private void toolTip(Control boton, string etiqueta)
        {
            tooltip1.SetToolTip(boton, etiqueta);
        }
    }
}
