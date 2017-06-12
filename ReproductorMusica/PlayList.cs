using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsplaiMusic
{
    class PlayList
    {
        //Propiedades
        private int ID;
        private string name;
        private List<Song> playListSongs = new List<Song>();

        SqlConnection conn = dbConnect.openConnection();

        //Constructores
        public PlayList()
        {
        }

        public PlayList(string name)
        {
            this.setID(ID);
            this.setName(name);
            this.setPlayListSongs(playListSongs);
        }

        //Getters y setters
        public int getID()
        {
            return this.ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public List<Song> getPlayListSongs()
        {
            return this.playListSongs;
        }

        public void setPlayListSongs(List<Song> playListSongs)
        {
            this.playListSongs = playListSongs;
        }

        //Metodos

        // Método para obtener las canciones de la lista de reproducción que está llamando al método
        public List<Song> getSongsOfPlayListDB()
        {
            List<Song> songs = new List<Song>();

            int id;
            string nombre;
            string ruta;
            string checksum;
            bool favorita;
            string anyo;
            bool activa;

            //int idPlayList = playList1.getID();
            string namePlayList = this.getName();

            conn.Open();

            if (conn != null)
            {
                try
                {
                    string query = "SELECT c.ID, c.nombre, c.ruta, c.codigoArchivo, c.favorita, c.anyo, c.activa FROM canciones c  where c.ID IN ";
                    query += "(SELECT plc.cancion_id FROM playlist_cancion plc WHERE plc.playlist_id IN ";
                    query += "(SELECT pl.ID from playlists pl WHERE pl.nombre = @namePlayList));";

                    SqlCommand comando = new SqlCommand(query, conn);

                    //comando.Parameters.AddWithValue("@idPlayList", idPlayList);
                    comando.Parameters.AddWithValue("@namePlayList", namePlayList);

                    SqlDataReader myReader = comando.ExecuteReader();

                    while (myReader.Read())
                    {
                        id = (Convert.ToInt32(myReader["ID"]));
                        nombre = Convert.ToString(myReader["nombre"]);
                        ruta = Convert.ToString(myReader["ruta"]);
                        checksum = Convert.ToString(myReader["codigoArchivo"]);
                        favorita = (Convert.ToBoolean(myReader["favorita"]));
                        anyo = Convert.ToString(myReader["anyo"]);
                        activa = (Convert.ToBoolean(myReader["activa"]));

                        Song song1 = new Song();
                        song1.setID(id);
                        song1.setName(nombre);
                        song1.setPath(ruta);
                        song1.setChecksum(checksum);
                        song1.setFavourite(favorita);
                        song1.setyear(anyo);
                        song1.setActive(activa);

                        songs.Add(song1);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    conn.Close();
                }
            }

            conn.Close();
            return songs;
        }

        // Método para guardar las canciones de la lista de reproducción que llama al método
        public void fillPlayListsWithSongs()
        {
            List<Song> songsList = new List<Song>();
            songsList = this.getSongsOfPlayListDB();

            this.setPlayListSongs(songsList);
        }

        // Método para obtener una canción de una lista
        public Song getSong(String songName)
        {
            Song song1 = new Song();

            foreach (Song song in this.getPlayListSongs())
            {
                if (song.getName().Equals(songName))
                {
                    song1 = song;
                    break;
                }
            }
            return song1;
        }
    }
}
