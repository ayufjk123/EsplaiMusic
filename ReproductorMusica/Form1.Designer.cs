﻿namespace ReproductorMusica
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
            this.lista = new System.Windows.Forms.ListBox();
            this.volumen = new XComponent.SliderBar.MACTrackBar();
            this.norepeat = new System.Windows.Forms.PictureBox();
            this.repeat = new System.Windows.Forms.PictureBox();
            this.duracionCancion = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.PictureBox();
            this.anterior = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.siguiente = new System.Windows.Forms.PictureBox();
            this.mute = new System.Windows.Forms.PictureBox();
            this.unmute = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.norepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmute)).BeginInit();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse.Location = new System.Drawing.Point(61, 22);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(118, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "Agregar a la Lista";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lista
            // 
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(824, 22);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(345, 472);
            this.lista.TabIndex = 6;
            // 
            // volumen
            // 
            this.volumen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumen.BackColor = System.Drawing.Color.Transparent;
            this.volumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.volumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.volumen.IndentHeight = 6;
            this.volumen.Location = new System.Drawing.Point(614, 423);
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
            this.norepeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.norepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.norepeat.Image = ((System.Drawing.Image)(resources.GetObject("norepeat.Image")));
            this.norepeat.Location = new System.Drawing.Point(195, 423);
            this.norepeat.Name = "norepeat";
            this.norepeat.Size = new System.Drawing.Size(32, 32);
            this.norepeat.TabIndex = 13;
            this.norepeat.TabStop = false;
            this.norepeat.Click += new System.EventHandler(this.unrepeat_Click);
            // 
            // repeat
            // 
            this.repeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repeat.Image = global::ReproductorMusica.Properties.Resources.Play_Mode_Repeat_All_Hot_icon;
            this.repeat.Location = new System.Drawing.Point(195, 423);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(32, 32);
            this.repeat.TabIndex = 14;
            this.repeat.TabStop = false;
            this.repeat.Visible = false;
            this.repeat.Click += new System.EventHandler(this.repeat_Click);
            // 
            // duracionCancion
            // 
            this.duracionCancion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.duracionCancion.BackColor = System.Drawing.Color.Transparent;
            this.duracionCancion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.duracionCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duracionCancion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracionCancion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.duracionCancion.IndentHeight = 6;
            this.duracionCancion.Location = new System.Drawing.Point(91, 376);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "00:00";
            // 
            // stop
            // 
            this.stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.Image = global::ReproductorMusica.Properties.Resources.Stop_icon;
            this.stop.Location = new System.Drawing.Point(260, 423);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(32, 32);
            this.stop.TabIndex = 17;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // anterior
            // 
            this.anterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior.Image = global::ReproductorMusica.Properties.Resources.Skip_backward_icon;
            this.anterior.Location = new System.Drawing.Point(327, 423);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(32, 32);
            this.anterior.TabIndex = 18;
            this.anterior.TabStop = false;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // pause
            // 
            this.pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Image = global::ReproductorMusica.Properties.Resources.Pause_icon;
            this.pause.Location = new System.Drawing.Point(365, 423);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(32, 32);
            this.pause.TabIndex = 19;
            this.pause.TabStop = false;
            this.pause.Visible = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Image = global::ReproductorMusica.Properties.Resources.Play_icon;
            this.play.Location = new System.Drawing.Point(365, 423);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(32, 32);
            this.play.TabIndex = 20;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // siguiente
            // 
            this.siguiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siguiente.Image = global::ReproductorMusica.Properties.Resources.Skip_forward_icon;
            this.siguiente.Location = new System.Drawing.Point(403, 423);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(32, 32);
            this.siguiente.TabIndex = 21;
            this.siguiente.TabStop = false;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // mute
            // 
            this.mute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mute.Image = global::ReproductorMusica.Properties.Resources.Sound_off_icon;
            this.mute.Location = new System.Drawing.Point(441, 423);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(32, 32);
            this.mute.TabIndex = 22;
            this.mute.TabStop = false;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // unmute
            // 
            this.unmute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.unmute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unmute.Image = global::ReproductorMusica.Properties.Resources.Sound_on_icon;
            this.unmute.Location = new System.Drawing.Point(441, 423);
            this.unmute.Name = "unmute";
            this.unmute.Size = new System.Drawing.Size(32, 32);
            this.unmute.TabIndex = 23;
            this.unmute.TabStop = false;
            this.unmute.Visible = false;
            this.unmute.Click += new System.EventHandler(this.unmute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 511);
            this.Controls.Add(this.unmute);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duracionCancion);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.norepeat);
            this.Controls.Add(this.volumen);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.browse);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.norepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lista;
        private XComponent.SliderBar.MACTrackBar volumen;
        private System.Windows.Forms.PictureBox norepeat;
        private System.Windows.Forms.PictureBox repeat;
        private XComponent.SliderBar.MACTrackBar duracionCancion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox anterior;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox siguiente;
        private System.Windows.Forms.PictureBox mute;
        private System.Windows.Forms.PictureBox unmute;
    }
}

