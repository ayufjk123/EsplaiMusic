using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsplaiMusic
{
    public partial class EscaneaFichero : Form
    {
        public int index = 1;
        public int listIndex;
        Dictionary<string, string> dic = new Dictionary<string, string>();
        public EscaneaFichero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName, fileExtension, fileSize, temp, Title, Artist, Album, Year, Comment, Genre = "", checkSum, Artista;
            FileInfo fi = null;
            ListViewItem lvi = null;
            string raizDic = "C:\\";
            List<String> subCarpetas = Directory.GetDirectories(raizDic + "CloudMusic").ToList();
            List<String> musicFiles = Directory.GetFiles(raizDic+"CloudMusic").ToList();
            foreach (string musicFile in subCarpetas)
            {
                List<String> musicSubFiles = Directory.GetFiles(musicFile).ToList();
                foreach (string nameSubFiles in musicSubFiles)
                {
                    musicFiles.Add(nameSubFiles);
                }
            }
            foreach (string filePath in musicFiles)
            {
                fi = new FileInfo(filePath);
                temp = filePath.Remove(filePath.LastIndexOf('.'));
                fileName = temp.Remove(0, temp.LastIndexOf('\\') + 1);
                fileExtension = filePath.Remove(0, filePath.LastIndexOf('.'));
                fileSize = (fi.Length / 1024).ToString() + "KB";

                TagLib.File tagFile = TagLib.File.Create(filePath);
                Artist = string.Join(",", tagFile.Tag.Performers);
                Album = tagFile.Tag.Album;
                Title = tagFile.Tag.Title;
                Year = tagFile.Tag.Year.ToString();
                Comment = tagFile.Tag.Comment;
                foreach (string genre in tagFile.Tag.Genres)
                {
                    Genre = Genre + genre;
                    Genre = Genre + ", ";
                }
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        checkSum = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                    }
                }
                Artist = string.Join(",", tagFile.Tag.Performers);
                lvi = new ListViewItem();
                lvi.Text = index++.ToString();
                lvi.SubItems.AddRange(new string[] { fileName, fileExtension, fileSize, filePath, Artist, Album, Title, Year, checkSum });

                if (lvDetail.Items.Count > 0)
                {
                    if (!dic.ContainsKey(filePath))
                    {
                        lvDetail.Items.Add(lvi);
                        dic.Add(filePath, fileName);
                        //media = wmp.newMedia(filePath);
                        //wmp.currentPlaylist.insertItem(listIndex++, media);
                    }
                    else
                    {
                        index--;
                        MessageBox.Show("File exsits！");
                    }
                }
                else
                {
                    lvDetail.Items.Add(lvi);
                    dic.Add(filePath, fileName);
                    //media = wmp.newMedia(filePath);
                    //wmp.currentPlaylist.insertItem(listIndex++, media);
                }
            }
        }
    }

    class MusicID3Tag

    {

        public byte[] TAGID = new byte[3];      //  3
        public byte[] Title = new byte[30];     //  30
        public byte[] Artist = new byte[30];    //  30 
        public byte[] Album = new byte[30];     //  30 
        public byte[] Year = new byte[4];       //  4 
        public byte[] Comment = new byte[30];   //  30 
        public byte[] Genre = new byte[1];      //  1

    }
}
