using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsplaiMusic
{
    public partial class FormSetPath : Form
    {

        // String for saveRootDirectoryName
        string fileName = "raizDic.txt";

        // String para raizDirectorio
        string raizDic = "";

        string pathAux = "";

        public string RaizDic { get => raizDic; set => raizDic = value; }

        public FormSetPath()
        {
            InitializeComponent();
        }

        private void FormSetPath_Load(object sender, EventArgs e)
        {
            // String para path of file which save the root of directory for project
            string destPath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())), fileName);
            if (File.ReadAllLines(destPath).Count() > 0)
            {
                textBox1.Text = File.ReadAllLines(destPath)[0];
                pathAux = textBox1.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox1.Text = fbd.SelectedPath;
                    raizDic = fbd.SelectedPath;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // String para path of file which save the root of directory for project
            string destPath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())), fileName);
            try
            {
                TextWriter tw = new StreamWriter(destPath, false);
                tw.WriteLine(raizDic);
                tw.Close();
            }
            catch (Exception f)
            {
                System.Diagnostics.Debug.Write(f);
            }
            finally
            {
                raizDic = textBox1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            raizDic = pathAux;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
