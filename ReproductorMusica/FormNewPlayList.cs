using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsplaiMusic
{
    public partial class FormNewPlayList : Form
    {
        private string newListName;

        public FormNewPlayList()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            newListName = textBox1.Text;
            this.Close();
        }

        public string getNewListName()
        {
            return this.newListName;
        }
    }
}
