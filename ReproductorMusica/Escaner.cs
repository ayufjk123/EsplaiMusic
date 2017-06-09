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

        SqlConnection conn = dbConnect.openConnection();

        static List<String> musicFiles = new List<string>();
        public static List<string> listOfPlaylist = new List<string>();

        public void scanFiles()
        {
            string fileName, checkSum, path;
            string raizDic = "C:\\CloudMusic";
            //List<String> subCarpetas = Directory.GetDirectories(raizDic).ToList();
            musicFiles = Directory.GetFiles(raizDic).ToList();
            listOfPlaylist.Add(raizDic.Substring(raizDic.LastIndexOf("\\") + 1));

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

                    // Obtenemos el nombre de cad aarchivo
                    path = filePath.Remove(filePath.LastIndexOf('.'));
                    fileName = path.Remove(0, path.LastIndexOf('\\') + 1);

                    // Obtenemos el codigo checksum usando encriptación MD5 de cada archivo
                    using (var md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(filePath))
                        {
                            checkSum = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                        }
                    }

                    // Obtenemos la canción a partir de su checksum
                    resultado = selectSong(checkSum);

                    // Comprobamos que la cancion exista. Si existe se actualiza y si no, se inserta
                    if (resultado == 1)
                    {
                        updateSong(fileName, path, checkSum);
                    }
                    else
                    {
                        insertSong(fileName, path, checkSum);
                    }
                    int playlist_id = selectIDPlaylist(namePlaylist);
                    int cancion_id = selectIDSong(checkSum);
                    if (filePath.Remove(filePath.LastIndexOf("\\")).EndsWith(namePlaylist))
                    {
                        insertPlaylistCancion(playlist_id.ToString(), cancion_id.ToString());
                    }

                }
            }



        }

        // Selecciona la canción a partir de su codigo checksum
        public int selectSong(string checksum)
        {
            int resultado = 0;
            conn.Open();
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
                    conn.Close();
                }
            }
            conn.Close();
            return resultado;
        }

        // Inserta la canción en la tabla de canciones
        public void insertSong(string name, string path, string checksum)
        {
            conn.Open();
            bool activada = true;

            if (conn != null)
            {
                try
                {
                    query = "INSERT into canciones (nombre, ruta, codigoArchivo, activa) values (@nombre, @path, @codigo_archivo, @activa);";

                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@nombre", name);
                    comando.Parameters.AddWithValue("@path", path);
                    comando.Parameters.AddWithValue("@codigo_archivo", checksum);
                    comando.Parameters.AddWithValue("@activa", activada);

                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    conn.Close();
                }
            }
            conn.Close();
        }

        // Actualiza el nombre de la canción y su codigo checksum
        public void updateSong(string name, string path, string checksum)
        {
            conn.Open();
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
                    conn.Close();
                }
                conn.Close();
            }
        }

        // Selecciona la canción a partir de su codigo checksum
        public int selectPlaylist(string name)
        {
            int resultado = 0;
            conn.Open();
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
                    conn.Close();
                }
            }
            conn.Close();
            return resultado;
        }

        // Inserta la canción en la tabla de canciones
        public void insertPlaylist(string name)
        {
            conn.Open();

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
                    conn.Close();
                }
            }
            conn.Close();
        }

        // Actualiza el nombre de la canción y su codigo checksum
        public void updatePlaylist(string nameOld, string nameNew)
        {
            conn.Open();

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
                    conn.Close();
                }
                conn.Close();
            }
        }

        // Selecciona la canción a partir de su codigo checksum
        public int selectPlaylistCancion(string checksum)
        {
            int resultado = 0;
            conn.Open();
            if (conn != null)
            {
                try
                {
                    query = "SELECT COUNT(*) FROM playlist_cancion pc, playlists pl, canciones ca WHERE pc.playlist_id = pl.ID AND pc.cancion_id = ca.ID AND ca.codigoArchivo = @codigoArchivo;";
                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@codigoArchivo", checksum);

                    resultado = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    conn.Close();
                }
            }
            conn.Close();
            return resultado;
        }

        // Selecciona la canción a partir de su codigo checksum
        public int selectIDSong(string checksum)
        {
            int resultado = 0;
            conn.Open();
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
                    conn.Close();
                }
            }
            conn.Close();
            return resultado;
        }

        // Selecciona la canción a partir de su codigo checksum
        public int selectIDPlaylist(string name)
        {
            int resultado = 0;
            conn.Open();
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
                    conn.Close();
                }
            }
            conn.Close();
            return resultado;
        }

        // Inserta la canción en la tabla de canciones
        public void insertPlaylistCancion(string playList_id, string cancion_id)
        {
            conn.Open();

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
                    conn.Close();
                }
            }
            conn.Close();
        }

        // Actualiza el nombre de la canción y su codigo checksum
        public void deletePlaylistCancion(string playlist_id, string cancion_id)
        {
            conn.Open();

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
                    conn.Close();
                }
                conn.Close();
            }
        }

        // Desactiva todas las canciones actualizando su valor "activada" a 0 (false)
        public void desactivateAllSongs()
        {
            bool activada = false;

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
                    conn.Close();
                }
                conn.Close();
            }
        }

        public static void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d, "*.mp3"))
                    {
                        /* Añadimos cada archivo a la lista de archivos genericos, 
                        para tener en una lista los archivos de la carpeta raíz y los de las subcarpetas */
                        musicFiles.Add(f);
                    }
                    listOfPlaylist.Add(d.Substring(d.LastIndexOf("\\") + 1));
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
        public List<string> PlaylistNombres()
        {
            List<string> resultado = new List<string>() ;
            conn.Open();
            if (conn != null)
            {
                try
                {
                    query = "SELECT nombre FROM playlists;";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader myReader = comando.ExecuteReader();

                    while (myReader.Read())
                    {
                        resultado.Add(Convert.ToString(myReader["nombre"]));
                    }
                }
                catch (Exception e)
                { 
                    Console.WriteLine(e.ToString());
                    conn.Close();
                }
            }
            conn.Close();
            return resultado;
        }
    }
}
