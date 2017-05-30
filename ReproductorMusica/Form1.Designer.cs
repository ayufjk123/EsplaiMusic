namespace ReproductorMusica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.siguiente = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.anterior = new System.Windows.Forms.Button();
            this.mute = new System.Windows.Forms.Button();
            this.unmute = new System.Windows.Forms.Button();
            this.volumen = new XComponent.SliderBar.MACTrackBar();
            this.norepeat = new System.Windows.Forms.PictureBox();
            this.repeat = new System.Windows.Forms.PictureBox();
            this.duracionCancion = new XComponent.SliderBar.MACTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.norepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).BeginInit();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse.Location = new System.Drawing.Point(61, 22);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(95, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "Elegir canción";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // play
            // 
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Location = new System.Drawing.Point(342, 444);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 1;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Visible = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stop
            // 
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.Location = new System.Drawing.Point(160, 444);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Location = new System.Drawing.Point(342, 443);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 3;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // siguiente
            // 
            this.siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siguiente.Location = new System.Drawing.Point(432, 444);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(75, 23);
            this.siguiente.TabIndex = 4;
            this.siguiente.Text = "Siguiente";
            this.siguiente.UseVisualStyleBackColor = true;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // lista
            // 
            this.lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(824, 22);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(345, 472);
            this.lista.TabIndex = 6;
            // 
            // anterior
            // 
            this.anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior.Location = new System.Drawing.Point(250, 444);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(75, 23);
            this.anterior.TabIndex = 7;
            this.anterior.Text = "Anterior";
            this.anterior.UseVisualStyleBackColor = true;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // mute
            // 
            this.mute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mute.Location = new System.Drawing.Point(543, 444);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(75, 23);
            this.mute.TabIndex = 8;
            this.mute.Text = "Mute";
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // unmute
            // 
            this.unmute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unmute.Location = new System.Drawing.Point(543, 443);
            this.unmute.Name = "unmute";
            this.unmute.Size = new System.Drawing.Size(75, 23);
            this.unmute.TabIndex = 9;
            this.unmute.Text = "Unmute";
            this.unmute.UseVisualStyleBackColor = true;
            this.unmute.Visible = false;
            this.unmute.Click += new System.EventHandler(this.unmute_Click);
            // 
            // volumen
            // 
            this.volumen.BackColor = System.Drawing.Color.Transparent;
            this.volumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.volumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.volumen.IndentHeight = 6;
            this.volumen.Location = new System.Drawing.Point(668, 439);
            this.volumen.Maximum = 100;
            this.volumen.Minimum = 0;
            this.volumen.Name = "volumen";
            this.volumen.Size = new System.Drawing.Size(109, 28);
            this.volumen.TabIndex = 12;
            this.volumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.volumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.volumen.TickHeight = 4;
            this.volumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.volumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.volumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.volumen.TrackLineHeight = 3;
            this.volumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.volumen.Value = 50;
            this.volumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.volumen_ValueChanged);
            // 
            // norepeat
            // 
            this.norepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.norepeat.Image = ((System.Drawing.Image)(resources.GetObject("norepeat.Image")));
            this.norepeat.Location = new System.Drawing.Point(104, 439);
            this.norepeat.Name = "norepeat";
            this.norepeat.Size = new System.Drawing.Size(32, 32);
            this.norepeat.TabIndex = 13;
            this.norepeat.TabStop = false;
            this.norepeat.Click += new System.EventHandler(this.unrepeat_Click);
            // 
            // repeat
            // 
            this.repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repeat.Image = global::ReproductorMusica.Properties.Resources.Play_Mode_Repeat_All_Hot_icon;
            this.repeat.Location = new System.Drawing.Point(104, 439);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(32, 32);
            this.repeat.TabIndex = 14;
            this.repeat.TabStop = false;
            this.repeat.Visible = false;
            this.repeat.Click += new System.EventHandler(this.repeat_Click);
            // 
            // duracionCancion
            // 
            this.duracionCancion.BackColor = System.Drawing.Color.Transparent;
            this.duracionCancion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.duracionCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duracionCancion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracionCancion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.duracionCancion.IndentHeight = 6;
            this.duracionCancion.Location = new System.Drawing.Point(104, 331);
            this.duracionCancion.Maximum = 10;
            this.duracionCancion.Minimum = 0;
            this.duracionCancion.Name = "duracionCancion";
            this.duracionCancion.Size = new System.Drawing.Size(619, 28);
            this.duracionCancion.TabIndex = 15;
            this.duracionCancion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.duracionCancion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.duracionCancion.TickHeight = 4;
            this.duracionCancion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.duracionCancion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.duracionCancion.TrackerSize = new System.Drawing.Size(16, 16);
            this.duracionCancion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.duracionCancion.TrackLineHeight = 3;
            this.duracionCancion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.duracionCancion.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 511);
            this.Controls.Add(this.duracionCancion);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.norepeat);
            this.Controls.Add(this.volumen);
            this.Controls.Add(this.unmute);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Controls.Add(this.browse);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.norepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button anterior;
        private System.Windows.Forms.Button mute;
        private System.Windows.Forms.Button unmute;
        private XComponent.SliderBar.MACTrackBar volumen;
        private System.Windows.Forms.PictureBox norepeat;
        private System.Windows.Forms.PictureBox repeat;
        private XComponent.SliderBar.MACTrackBar duracionCancion;
    }
}

