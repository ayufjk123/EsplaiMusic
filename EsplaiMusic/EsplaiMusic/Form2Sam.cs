using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace EsplaiMusic
{
    public partial class Form2Sam : Form
    {
        public int index = 1;
        public int listIndex;
        SoundPlayer player = new SoundPlayer();
        Dictionary<string, string> dic = new Dictionary<string, string>();
        IWMPMedia media;
        public Form2Sam()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load files
        /// </summary>
        private void tsmiLoading_Click(object sender, EventArgs e)
        {
            string fileName, fileExtension, fileSize, temp;
            FileInfo fi = null;
            ListViewItem lvi = null;

            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "mp3 Files(*.mp3)|*.mp3|wav Files(*.wav)|*.wav|wma Files(*.wma)|*.wma";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog1.FileNames)
                {
                    fi = new FileInfo(filePath);
                    temp = filePath.Remove(filePath.LastIndexOf('.'));
                    fileName = temp.Remove(0, temp.LastIndexOf('\\') + 1);
                    fileExtension = filePath.Remove(0, filePath.LastIndexOf('.'));
                    fileSize = (fi.Length / 1024).ToString() + "KB";

                    lvi = new ListViewItem();
                    lvi.Text = index++.ToString();
                    lvi.SubItems.AddRange(new string[] { fileName, fileExtension, fileSize, filePath });

                    if (lvDetail.Items.Count > 0)
                    {
                        if (!dic.ContainsKey(filePath))
                        {
                            lvDetail.Items.Add(lvi);
                            dic.Add(filePath, fileName);
                            media = wmp.newMedia(filePath);
                            wmp.currentPlaylist.insertItem(listIndex++, media);
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
                        media = wmp.newMedia(filePath);
                        wmp.currentPlaylist.insertItem(listIndex++, media);
                    }
                }
            }
        }

        /// <summary>
        /// Clear list
        /// </summary>
        private void tsmiClear_Click(object sender, EventArgs e)
        {
            lvDetail.Items.Clear();
        }

        /// <summary>
        /// Play
        /// </summary>
        private void tsmiPlayer_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.play();
        }

        /// <summary>
        /// Pause
        /// </summary>
        private void tsmiWaiting_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.pause();
        }

        /// <summary>
        /// Stop
        /// </summary>
        private void tsmiStop_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.stop();
        }

        /// <summary>
        /// Exit
        /// </summary>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Double click for play
        /// </summary>
        private void lvDetail_DoubleClick(object sender, EventArgs e)
        {
            if (lvDetail.SelectedItems.Count > 0)
            {
                wmp.currentMedia = wmp.currentPlaylist.Item[int.Parse(lvDetail.SelectedItems[0].Text) - 1];
            }
        }
    }
}
