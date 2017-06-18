using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Security.Cryptography;

namespace EsplaiMusic
{
    class Escaner
    {
        private static string query;

        SqlConnection conn = null;

        public static List<String> musicFiles = new List<string>();
        public static List<string> listOfPlaylist = new List<string>();

        public static List<PlayList> ListOfPlayLists = new List<PlayList>();

        // Lista de ID's de las canciones favoritas
        public static List<int> idFavoritas = new List<int>();

        public void scanFiles(string raizDic)
        {
            string fileName, checkSum, path, year, pathNoExtension;
            //string raizDic = "C:\\CloudMusic";
            musicFiles = Directory.GetFiles(raizDic, "*.mp3").ToList();
            //listOfPlaylist.Add(raizDic.Substring(raizDic.LastIndexOf("\\") + 1));

            if (Directory.GetFiles(raizDic, "*.mp3").Count() > 0)
            {
                listOfPlaylist.Add(raizDic.Substring(raizDic.LastIndexOf("\\") + 1));
            }

            desactivateAllSongs();

            // Leemos cada archivo de la lista de archivos de las subcarpetas
            DirSearch(raizDic);

            foreach (string namePlaylist in listOfPlaylist)
            {
                int res;
                res = selectPlaylist(namePlaylist);
                // Comprobamos que la cancion exista. Si existe se actualiza y si no, se inserta
                if (res == 1)
                {
                    updatePlaylist(namePlaylist, namePlaylist);
                }
                else
                {
                    insertPlaylist(namePlaylist);
                }
                // Leemos cada archivo de la lista de todos los archivos
                foreach (string filePath in musicFiles)
                {
                    int resultado;

                    // Obtenemos el nombre de cada archivo

                    path = filePath;
                    pathNoExtension = filePath.Remove(filePath.LastIndexOf('.'));

                    fileName = pathNoExtension.Remove(0, pathNoExtension.LastIndexOf('\\') + 1);

                    // Obtenemos el codigo checksum usando encriptación MD5 de cada archivo
                    using (var md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(filePath))
                        {
                            checkSum = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                        }
                    }

                    TagLib.File tagFile = TagLib.File.Create(filePath);
                    year = tagFile.Tag.Year.ToString();

                    // Obtenemos la canción a partir de su checksum
                    resultado = selectSong(checkSum);

                    // Comprobamos que la cancion exista. Si existe se actualiza y si no, se inserta
                    if (resultado == 1)
                    {
                        updateSong(fileName, path, checkSum);
                    }
                    else
                    {
                        insertSong(fileName, path, checkSum, year);
                    }
                    int playlist_id = selectIDPlaylist(namePlaylist);
                    int cancion_id = selectIDSong(checkSum);
                    if (filePath.Remove(filePath.LastIndexOf("\\")).EndsWith(namePlaylist))
                    {
                        int relacion = selectPlaylistCancion(playlist_id, cancion_id);

                        if (relacion < 1)
                        {
                            insertPlaylistCancion(playlist_id, cancion_id);
                        }
                    }
                }
            }

            // Añadimos la lista de canciones favoritas y luego sus canciones en la tabla relacional
            string nombreFav = "Favoritos";
            int idFav = selectIDPlaylist(nombreFav);

            if (idFav < 1)
            {
                insertPlaylist(nombreFav);
            }

            // Obtenemos el ID de todas las canciones en favoritos
            selectFavoritas();

            // Comprobamos si la relación ya existe (la canción ya está añadida a la lista de favoritos) y la añadimos si no existe
            foreach (int idCancion in idFavoritas)
            {
                int relacion = selectPlaylistCancion(idFav, idCancion);

                if (relacion < 1)
                {
                    insertPlaylistCancion(idFav, idCancion);
                }
            }
        }

        // Selecciona la canción a partir de su codigo checksum
        public int selectSong(string checksum)
        {
            int resultado = 0;
            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "SELECT count(codigoArchivo) from canciones where codigoArchivo = @checksum;";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@checksum", checksum);

                    // Devuelve la cantidad de resultados, en este caso siempre es 1 o 0
                    resultado = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
            return resultado;
        }

        // Inserta la canción en la tabla de canciones
        public void insertSong(string name, string path, string checksum, string year)
        {
            conn = dbConnect.openConnection();
            bool activada = true;
            bool favourite = false;

            if (conn != null)
            {
                try
                {
                    query = "INSERT into canciones (nombre, ruta, codigoArchivo, favorita, anyo, activa) values (@nombre, @path, @codigo_archivo, @favorita, @anyo, @activa);";

                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@nombre", name);
                    comando.Parameters.AddWithValue("@path", path);
                    comando.Parameters.AddWithValue("@codigo_archivo", checksum);
                    comando.Parameters.AddWithValue("@favorita", favourite);
                    comando.Parameters.AddWithValue("@anyo", year);
                    comando.Parameters.AddWithValue("@activa", activada);

                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        // Actualiza el nombre de la canción y su codigo checksum
        public void updateSong(string name, string path, string checksum)
        {
            conn = dbConnect.openConnection();
            bool activada = true;

            if (conn != null)
            {
                try
                {
                    query = "UPDATE canciones SET nombre = @nombre, ruta = @path, activa = @activada where codigoArchivo = @checksum;";

                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@nombre", name);
                    comando.Parameters.AddWithValue("@path", path);
                    comando.Parameters.AddWithValue("@checksum", checksum);
                    comando.Parameters.AddWithValue("@activada", activada);

                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        // Selecciona la playlist a partir de un nombre
        public int selectPlaylist(string name)
        {
            int resultado = 0;
            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "SELECT COUNT(nombre) FROM playlists WHERE nombre = @name;";
                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@name", name);

                    resultado = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
            return resultado;
        }

        // Selecciona la playlist a partir de un nombre
        public PlayList selectFirstPlaylist()
        {
            int id;
            string nombre;
            conn = dbConnect.openConnection();
            PlayList playList1 = new PlayList();
            if (conn != null)
            {
                try
                {
                    query = "SELECT ID, nombre FROM playlists WHERE ID = 1;";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader myReader = comando.ExecuteReader();

                    while (myReader.Read())
                    {
                        id = (Convert.ToInt32(myReader["ID"]));
                        nombre = Convert.ToString(myReader["nombre"]);

                        playList1.setID(id);
                        playList1.setName(nombre);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
            return playList1;
        }

        // Inserta la canción en la tabla de canciones
        public void insertPlaylist(string name)
        {
            conn = dbConnect.openConnection();

            if (conn != null)
            {
                try
                {
                    query = "INSERT INTO playlists (nombre) VALUES (@nombre);";

                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@nombre", name);

                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        // Actualiza el nombre de la canción y su codigo checksum
        public void updatePlaylist(string nameOld, string nameNew)
        {
            conn = dbConnect.openConnection();

            if (conn != null)
            {
                try
                {
                    query = "UPDATE playlists SET nombre = @nameNew WHERE nombre = @nameOld;";

                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@nameNew", nameNew);
                    comando.Parameters.AddWithValue("@nameOld", nameOld);

                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        // Cuenta la cantidad de relaciones que hay entre una lista y una cancion. Si hay una ya no la vovleremos a insertar
        public int selectPlaylistCancion(int idPlaylist, int idCancion)
        {
            int resultado = 0;
            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "SELECT COUNT(*) FROM playlist_cancion pc WHERE playlist_id = @idPlaylist AND cancion_id = @idCancion;";
                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@idPlaylist", idPlaylist);
                    comando.Parameters.AddWithValue("@idCancion", idCancion);

                    resultado = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
            return resultado;
        }

        // Selecciona la canción a partir de su codigo checksum
        public int selectIDSong(string checksum)
        {
            int resultado = 0;
            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "SELECT ID from canciones where codigoArchivo = @checksum;";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@checksum", checksum);

                    resultado = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
            return resultado;
        }

        // Selecciona el ID de las canciones favoritas
        public void selectFavoritas()
        {
            int favorita = 1;
            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "SELECT ID from canciones where favorita = @favorita;";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@favorita", favorita);

                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        int pos = lector.GetInt32(0);
                        idFavoritas.Add(pos);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        // Selecciona la canción a partir de su codigo checksum
        public int selectIDPlaylist(string name)
        {
            int resultado = 0;
            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "SELECT ID FROM playlists WHERE nombre = @name;";
                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@name", name);

                    resultado = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
            return resultado;
        }

        // Inserta la canción en la tabla de canciones
        public void insertPlaylistCancion(int playList_id, int cancion_id)
        {
            conn = dbConnect.openConnection();

            if (conn != null)
            {
                try
                {
                    query = "INSERT INTO playlist_cancion (playlist_id, cancion_id) VALUES (@playlist_id, @cancion_id);";

                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@playlist_id", playList_id);
                    comando.Parameters.AddWithValue("@cancion_id", cancion_id);

                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        // Actualiza el nombre de la canción y su codigo checksum
        public void deletePlaylistCancion(int playlist_id, int cancion_id)
        {
            conn = dbConnect.openConnection();

            if (conn != null)
            {
                try
                {
                    query = "DELETE FROM playlist_cancion WHERE playlist_id = @playlist_id AND cancion_id = @cancion_id;";

                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@playlist_id", playlist_id);
                    comando.Parameters.AddWithValue("@cancion_id", cancion_id);

                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        // Desactiva todas las canciones actualizando su valor "activada" a 0 (false)
        public void desactivateAllSongs()
        {
            bool activada = false;

            conn = dbConnect.openConnection();

            if (conn != null)
            {
                try
                {
                    query = "UPDATE canciones SET activa = '" + activada + "';";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        /* Método para escanear recursivamente todos los archivos y carpetas y guardarlos en sus respectivas listas
        si la carpeta está vacía no la guardará */
        public static void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    if (Directory.GetFiles(d, "*.mp3").Count() > 0 || Directory.GetDirectories(d).Count() > 0)
                    {
                        foreach (string f in Directory.GetFiles(d, "*.mp3"))
                        {
                            /* Añadimos cada archivo a la lista de archivos genericos, 
                            para tener en una lista los archivos de la carpeta raíz y los de las subcarpetas */
                            musicFiles.Add(f);
                        }
                        if (Directory.GetFiles(d, "*.mp3").Count() > 0)
                        {
                            listOfPlaylist.Add(d.Substring(d.LastIndexOf("\\") + 1));
                        }
                        DirSearch(d);
                    }
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        static List<string> listOfSubDir = new List<string>();
        /* Método para escanear recursivamente todos los archivos y carpetas y guardarlos en sus respectivas listas
        si la carpeta está vacía no la guardará */
        public static List<string> SubDirSearch(string sDir)
        {
            try
            {
                if (!listOfSubDir.Contains(sDir))
                {
                    if (Directory.GetFiles(sDir, "*.mp3").Count() > 0 || Directory.GetDirectories(sDir).Count() > 0)
                    {
                        listOfSubDir.Add(sDir);
                    }
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    if (!listOfSubDir.Contains(sDir))
                    {
                        if (Directory.GetFiles(d, "*.mp3").Count() > 0 || Directory.GetDirectories(d).Count() > 0)
                        {
                            Console.WriteLine("2- " + d);
                            listOfSubDir.Add(d);
                        }
                    }
                    SubDirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return listOfSubDir;
        }

        // Método para rellenar la lista de listas de reproducción
        public List<PlayList> chargeListOfPlayLists()
        {
            int id;
            string nombre;

            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "SELECT ID, nombre FROM playlists;";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader myReader = comando.ExecuteReader();

                    while (myReader.Read())
                    {
                        PlayList playList1 = new PlayList();

                        id = (Convert.ToInt32(myReader["ID"]));
                        nombre = Convert.ToString(myReader["nombre"]);

                        playList1.setID(id);
                        playList1.setName(nombre);
                        ListOfPlayLists.Add(playList1);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
            return ListOfPlayLists;
        }

        // Método para rellenar la lista de listas de reproducción
        public List<PlayList> chargeListOfPlayLists(string ultWord, string raizDic)
        {
            int id;
            string nombre;

            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    if (Directory.GetDirectories(raizDic).Count() > 0)
                    {                        
                        List<string> listOfDir = SubDirSearch(raizDic);
                        foreach (string path in listOfDir)
                        {
                            query = "SELECT ID, nombre FROM playlists WHERE nombre = @nombre;";
                            SqlCommand comando = new SqlCommand(query, conn);
                            string nom = path.Substring(path.LastIndexOf("\\") + 1);
                            comando.Parameters.AddWithValue("@nombre", nom);
                            SqlDataReader myReader = comando.ExecuteReader();

                            while (myReader.Read())
                            {
                                PlayList playList1 = new PlayList();

                                id = (Convert.ToInt32(myReader["ID"]));
                                nombre = Convert.ToString(myReader["nombre"]);

                                playList1.setID(id);
                                playList1.setName(nombre);
                                ListOfPlayLists.Add(playList1);
                            }
                            myReader.Close();
                        }
                    }
                    else
                    {
                        query = "SELECT ID, nombre FROM playlists WHERE nombre = @nombre;";
                        SqlCommand comando = new SqlCommand(query, conn);
                        comando.Parameters.AddWithValue("@nombre", ultWord);
                        SqlDataReader myReader = comando.ExecuteReader();

                        while (myReader.Read())
                        {
                            PlayList playList1 = new PlayList();

                            id = (Convert.ToInt32(myReader["ID"]));
                            nombre = Convert.ToString(myReader["nombre"]);

                            playList1.setID(id);
                            playList1.setName(nombre);
                            ListOfPlayLists.Add(playList1);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
            return ListOfPlayLists;
        }

        // Método para añadir la lista de favoritos en la lista de listas
        public void chargeFavorites()
        {
            int id;
            string nombre;
            PlayList favoritos = new PlayList();

            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "SELECT ID, nombre FROM playlists WHERE nombre = 'Favoritos';";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader myReader = comando.ExecuteReader();

                    while (myReader.Read())
                    {
                        id = (Convert.ToInt32(myReader["ID"]));
                        nombre = Convert.ToString(myReader["nombre"]);

                        favoritos.setID(id);
                        favoritos.setName(nombre);
                        ListOfPlayLists.Add(favoritos);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        // Cambia el valor Favorita de la canción indicada a partir del valor pasado por parámetro
        public void updateFavoritaValue(int idCancion, bool favorita)
        {
            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "UPDATE canciones SET favorita = '" + favorita + "' WHERE ID = '" + idCancion + "';";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        /* Eliminamos todas las relaciones de la PlayList seleccionada.
        Así dejamos la lista vacía (purga) para agregar el nuevo contenido a partir de la segunda listbox */
        public void deletePlayListRelations(int playlist_id)
        {
            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "DELETE FROM playlist_cancion WHERE playlist_id = '" + playlist_id + "'";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }

        // Cambia el valor Favorita de todas las canciones que lo tengan activado. De esta forma las eliminamos todas de la lista (purgamos)
        public void updateFavoritaValueToFalse()
        {
            conn = dbConnect.openConnection();
            if (conn != null)
            {
                try
                {
                    query = "UPDATE canciones SET favorita = 'false';";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    dbConnect.closeConnection();
                }
            }
        }
    }
}
