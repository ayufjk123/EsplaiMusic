namespace EsplaiMusic
{
    partial class EscaneaFichero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvDetail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lvDetail
            // 
            this.lvDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader10,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader11});
            this.lvDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvDetail.Location = new System.Drawing.Point(0, 0);
            this.lvDetail.Name = "lvDetail";
            this.lvDetail.Size = new System.Drawing.Size(973, 730);
            this.lvDetail.TabIndex = 0;
            this.lvDetail.UseCompatibleStateImageBehavior = false;
            this.lvDetail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Num.";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Path";
            this.columnHeader5.Width = 472;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 9;
            this.columnHeader10.Text = "Artist";
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 5;
            this.columnHeader7.Text = "Album";
            this.columnHeader7.Width = 131;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 6;
            this.columnHeader8.Text = "Title";
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 7;
            this.columnHeader9.Text = "Year";
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 8;
            this.columnHeader6.Text = "CheckSum";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Picture";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 736);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(973, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EscaneaFichero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 774);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvDetail);
            this.Name = "EscaneaFichero";
            this.Text = "EscaneaFichero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDetail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}