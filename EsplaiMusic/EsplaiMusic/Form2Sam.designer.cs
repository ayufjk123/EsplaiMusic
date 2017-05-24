namespace EsplaiMusic
{
    partial class Form2Sam
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Sam));
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoading = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXuanXiang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWaiting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanQu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXunHuan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lvDetail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 620);
            this.wmp.Margin = new System.Windows.Forms.Padding(6);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(918, 65);
            this.wmp.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiXuanXiang,
            this.tsmiSet,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(918, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoading,
            this.tsmiClear});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(100, 36);
            this.tsmiFile.Text = "Files(&F)";
            // 
            // tsmiLoading
            // 
            this.tsmiLoading.Name = "tsmiLoading";
            this.tsmiLoading.Size = new System.Drawing.Size(310, 38);
            this.tsmiLoading.Text = "Load music files(&L)";
            this.tsmiLoading.Click += new System.EventHandler(this.tsmiLoading_Click);
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(310, 38);
            this.tsmiClear.Text = "Clear(&C)";
            this.tsmiClear.Click += new System.EventHandler(this.tsmiClear_Click);
            // 
            // tsmiXuanXiang
            // 
            this.tsmiXuanXiang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPlayer,
            this.tsmiWaiting,
            this.tsmiStop});
            this.tsmiXuanXiang.Name = "tsmiXuanXiang";
            this.tsmiXuanXiang.Size = new System.Drawing.Size(139, 36);
            this.tsmiXuanXiang.Text = "Options(&X)";
            // 
            // tsmiPlayer
            // 
            this.tsmiPlayer.Name = "tsmiPlayer";
            this.tsmiPlayer.Size = new System.Drawing.Size(212, 38);
            this.tsmiPlayer.Text = "Play(&B)";
            this.tsmiPlayer.Click += new System.EventHandler(this.tsmiPlayer_Click);
            // 
            // tsmiWaiting
            // 
            this.tsmiWaiting.Name = "tsmiWaiting";
            this.tsmiWaiting.Size = new System.Drawing.Size(212, 38);
            this.tsmiWaiting.Text = "Pause(&W)";
            this.tsmiWaiting.Click += new System.EventHandler(this.tsmiWaiting_Click);
            // 
            // tsmiStop
            // 
            this.tsmiStop.Name = "tsmiStop";
            this.tsmiStop.Size = new System.Drawing.Size(212, 38);
            this.tsmiStop.Text = "Stop(&S)";
            this.tsmiStop.Click += new System.EventHandler(this.tsmiStop_Click);
            // 
            // tsmiSet
            // 
            this.tsmiSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDanQu,
            this.tsmiXunHuan});
            this.tsmiSet.Name = "tsmiSet";
            this.tsmiSet.Size = new System.Drawing.Size(130, 36);
            this.tsmiSet.Text = "Setting(&S)";
            // 
            // tsmiDanQu
            // 
            this.tsmiDanQu.CheckOnClick = true;
            this.tsmiDanQu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiDanQu.Name = "tsmiDanQu";
            this.tsmiDanQu.Size = new System.Drawing.Size(282, 38);
            this.tsmiDanQu.Text = "Repeat Once(&D)";
            // 
            // tsmiXunHuan
            // 
            this.tsmiXunHuan.Checked = true;
            this.tsmiXunHuan.CheckOnClick = true;
            this.tsmiXunHuan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiXunHuan.Name = "tsmiXunHuan";
            this.tsmiXunHuan.Size = new System.Drawing.Size(282, 38);
            this.tsmiXunHuan.Text = "All Repeat(&X)";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(90, 36);
            this.tsmiExit.Text = "Exit(&E)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // lvDetail
            // 
            this.lvDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDetail.FullRowSelect = true;
            this.lvDetail.Location = new System.Drawing.Point(0, 44);
            this.lvDetail.Margin = new System.Windows.Forms.Padding(6);
            this.lvDetail.MultiSelect = false;
            this.lvDetail.Name = "lvDetail";
            this.lvDetail.Size = new System.Drawing.Size(918, 576);
            this.lvDetail.TabIndex = 2;
            this.lvDetail.UseCompatibleStateImageBehavior = false;
            this.lvDetail.View = System.Windows.Forms.View.Details;
            this.lvDetail.DoubleClick += new System.EventHandler(this.lvDetail_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Num.";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Path";
            this.columnHeader5.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 685);
            this.Controls.Add(this.lvDetail);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.wmp);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esplai Music";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoading;
        private System.Windows.Forms.ToolStripMenuItem tsmiClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiXuanXiang;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayer;
        private System.Windows.Forms.ToolStripMenuItem tsmiWaiting;
        private System.Windows.Forms.ToolStripMenuItem tsmiStop;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ListView lvDetail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSet;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanQu;
        private System.Windows.Forms.ToolStripMenuItem tsmiXunHuan;
    }
}

