﻿namespace EsplaiMusic
{
    partial class Reproductor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listareproduccion = new System.Windows.Forms.ListBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.volumen = new XComponent.SliderBar.MACTrackBar();
            this.playedTimeLabel = new System.Windows.Forms.Label();
            this.labelMovil = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Timer(this.components);
            this.randomOn = new System.Windows.Forms.PictureBox();
            this.randomOff = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListboxTemaPlaylist = new System.Windows.Forms.ListBox();
            this.ListboxPlaylist = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaListaDeReproducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreNosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.norepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomOff)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.White;
            this.browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.browse.FlatAppearance.BorderSize = 0;
            this.browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.browse.ForeColor = System.Drawing.Color.Black;
            this.browse.Location = new System.Drawing.Point(440, 265);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(118, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "Agregar a la Lista";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listareproduccion
            // 
            this.listareproduccion.BackColor = System.Drawing.Color.Black;
            this.listareproduccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listareproduccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listareproduccion.ForeColor = System.Drawing.Color.White;
            this.listareproduccion.FormattingEnabled = true;
            this.listareproduccion.Location = new System.Drawing.Point(565, 51);
            this.listareproduccion.Name = "listareproduccion";
            this.listareproduccion.Size = new System.Drawing.Size(259, 208);
            this.listareproduccion.TabIndex = 6;
            this.listareproduccion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // norepeat
            // 
            this.norepeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.norepeat.BackColor = System.Drawing.Color.Transparent;
            this.norepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.norepeat.Image = ((System.Drawing.Image)(resources.GetObject("norepeat.Image")));
            this.norepeat.Location = new System.Drawing.Point(332, 52);
            this.norepeat.Name = "norepeat";
            this.norepeat.Size = new System.Drawing.Size(32, 32);
            this.norepeat.TabIndex = 13;
            this.norepeat.TabStop = false;
            this.norepeat.Click += new System.EventHandler(this.unrepeat_Click);
            // 
            // repeat
            // 
            this.repeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.repeat.BackColor = System.Drawing.Color.Transparent;
            this.repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repeat.Image = ((System.Drawing.Image)(resources.GetObject("repeat.Image")));
            this.repeat.Location = new System.Drawing.Point(332, 52);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(32, 32);
            this.repeat.TabIndex = 14;
            this.repeat.TabStop = false;
            this.repeat.Visible = false;
            this.repeat.Click += new System.EventHandler(this.repeat_Click);
            // 
            // duracionCancion
            // 
            this.duracionCancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.duracionCancion.BackColor = System.Drawing.Color.Transparent;
            this.duracionCancion.BorderColor = System.Drawing.SystemColors.WindowText;
            this.duracionCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duracionCancion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracionCancion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.duracionCancion.IndentHeight = 6;
            this.duracionCancion.Location = new System.Drawing.Point(63, 18);
            this.duracionCancion.Maximum = 10;
            this.duracionCancion.Minimum = 0;
            this.duracionCancion.Name = "duracionCancion";
            this.duracionCancion.Size = new System.Drawing.Size(720, 28);
            this.duracionCancion.TabIndex = 15;
            this.duracionCancion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.duracionCancion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.duracionCancion.TickHeight = 4;
            this.duracionCancion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.duracionCancion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.duracionCancion.TrackerSize = new System.Drawing.Size(16, 16);
            this.duracionCancion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.duracionCancion.TrackLineHeight = 3;
            this.duracionCancion.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.duracionCancion.Value = 0;
            this.duracionCancion.Scroll += new System.EventHandler(this.duracionCancion_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(789, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "00:00";
            // 
            // stop
            // 
            this.stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.Image = global::EsplaiMusic.Properties.Resources.Stop_icon;
            this.stop.Location = new System.Drawing.Point(370, 52);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(32, 32);
            this.stop.TabIndex = 17;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // anterior
            // 
            this.anterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.anterior.BackColor = System.Drawing.Color.Transparent;
            this.anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior.Image = global::EsplaiMusic.Properties.Resources.Skip_backward_icon;
            this.anterior.Location = new System.Drawing.Point(408, 52);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(32, 32);
            this.anterior.TabIndex = 18;
            this.anterior.TabStop = false;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // pause
            // 
            this.pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Image = global::EsplaiMusic.Properties.Resources.Pause_icon;
            this.pause.Location = new System.Drawing.Point(446, 52);
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
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Image = global::EsplaiMusic.Properties.Resources.Play_icon;
            this.play.Location = new System.Drawing.Point(446, 52);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(32, 32);
            this.play.TabIndex = 20;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // siguiente
            // 
            this.siguiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.siguiente.BackColor = System.Drawing.Color.Transparent;
            this.siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siguiente.Image = global::EsplaiMusic.Properties.Resources.Skip_forward_icon;
            this.siguiente.Location = new System.Drawing.Point(484, 52);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(32, 32);
            this.siguiente.TabIndex = 21;
            this.siguiente.TabStop = false;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // mute
            // 
            this.mute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mute.BackColor = System.Drawing.Color.Transparent;
            this.mute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mute.Image = global::EsplaiMusic.Properties.Resources.Sound_off_icon;
            this.mute.Location = new System.Drawing.Point(522, 52);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(32, 32);
            this.mute.TabIndex = 22;
            this.mute.TabStop = false;
            this.mute.Visible = false;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // unmute
            // 
            this.unmute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.unmute.BackColor = System.Drawing.Color.Transparent;
            this.unmute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unmute.Image = global::EsplaiMusic.Properties.Resources.Sound_on_icon;
            this.unmute.Location = new System.Drawing.Point(522, 52);
            this.unmute.Name = "unmute";
            this.unmute.Size = new System.Drawing.Size(32, 32);
            this.unmute.TabIndex = 23;
            this.unmute.TabStop = false;
            this.unmute.Click += new System.EventHandler(this.unmute_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // volumen
            // 
            this.volumen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumen.BackColor = System.Drawing.Color.Transparent;
            this.volumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.volumen.BorderColor = System.Drawing.Color.White;
            this.volumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.volumen.IndentHeight = 6;
            this.volumen.Location = new System.Drawing.Point(560, 56);
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
            this.volumen.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.volumen.Value = 50;
            this.volumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.volumen_ValueChanged);
            // 
            // playedTimeLabel
            // 
            this.playedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playedTimeLabel.AutoSize = true;
            this.playedTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.playedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playedTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.playedTimeLabel.Location = new System.Drawing.Point(21, 18);
            this.playedTimeLabel.Name = "playedTimeLabel";
            this.playedTimeLabel.Size = new System.Drawing.Size(39, 16);
            this.playedTimeLabel.TabIndex = 24;
            this.playedTimeLabel.Text = "00:00";
            // 
            // labelMovil
            // 
            this.labelMovil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMovil.AutoSize = true;
            this.labelMovil.BackColor = System.Drawing.Color.Transparent;
            this.labelMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMovil.Location = new System.Drawing.Point(425, 91);
            this.labelMovil.Name = "labelMovil";
            this.labelMovil.Size = new System.Drawing.Size(42, 20);
            this.labelMovil.TabIndex = 25;
            this.labelMovil.Text = "label";
            // 
            // timerLabel
            // 
            this.timerLabel.Tick += new System.EventHandler(this.timerLabel_Tick);
            // 
            // randomOn
            // 
            this.randomOn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.randomOn.BackColor = System.Drawing.Color.Transparent;
            this.randomOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomOn.Image = ((System.Drawing.Image)(resources.GetObject("randomOn.Image")));
            this.randomOn.Location = new System.Drawing.Point(294, 52);
            this.randomOn.Name = "randomOn";
            this.randomOn.Size = new System.Drawing.Size(32, 32);
            this.randomOn.TabIndex = 26;
            this.randomOn.TabStop = false;
            this.randomOn.Visible = false;
            this.randomOn.Click += new System.EventHandler(this.randomOn_Click);
            // 
            // randomOff
            // 
            this.randomOff.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.randomOff.BackColor = System.Drawing.Color.Transparent;
            this.randomOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomOff.Image = ((System.Drawing.Image)(resources.GetObject("randomOff.Image")));
            this.randomOff.Location = new System.Drawing.Point(294, 52);
            this.randomOff.Name = "randomOff";
            this.randomOff.Size = new System.Drawing.Size(32, 32);
            this.randomOff.TabIndex = 27;
            this.randomOff.TabStop = false;
            this.randomOff.Click += new System.EventHandler(this.randomOff_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Silver;
            this.panelButtons.Controls.Add(this.randomOff);
            this.panelButtons.Controls.Add(this.randomOn);
            this.panelButtons.Controls.Add(this.playedTimeLabel);
            this.panelButtons.Controls.Add(this.volumen);
            this.panelButtons.Controls.Add(this.unmute);
            this.panelButtons.Controls.Add(this.labelMovil);
            this.panelButtons.Controls.Add(this.mute);
            this.panelButtons.Controls.Add(this.siguiente);
            this.panelButtons.Controls.Add(this.play);
            this.panelButtons.Controls.Add(this.pause);
            this.panelButtons.Controls.Add(this.anterior);
            this.panelButtons.Controls.Add(this.stop);
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.duracionCancion);
            this.panelButtons.Controls.Add(this.repeat);
            this.panelButtons.Controls.Add(this.norepeat);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 312);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(838, 134);
            this.panelButtons.TabIndex = 28;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Esplai Music";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarVentanaToolStripMenuItem,
            this.ocultarVentanaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 76);
            // 
            // mostrarVentanaToolStripMenuItem
            // 
            this.mostrarVentanaToolStripMenuItem.Name = "mostrarVentanaToolStripMenuItem";
            this.mostrarVentanaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.mostrarVentanaToolStripMenuItem.Text = "Mostrar ventana";
            this.mostrarVentanaToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ocultarVentanaToolStripMenuItem
            // 
            this.ocultarVentanaToolStripMenuItem.Name = "ocultarVentanaToolStripMenuItem";
            this.ocultarVentanaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ocultarVentanaToolStripMenuItem.Text = "Ocultar ventana";
            this.ocultarVentanaToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // ListboxTemaPlaylist
            // 
            this.ListboxTemaPlaylist.BackColor = System.Drawing.Color.Black;
            this.ListboxTemaPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListboxTemaPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListboxTemaPlaylist.ForeColor = System.Drawing.Color.White;
            this.ListboxTemaPlaylist.FormattingEnabled = true;
            this.ListboxTemaPlaylist.Location = new System.Drawing.Point(275, 51);
            this.ListboxTemaPlaylist.Name = "ListboxTemaPlaylist";
            this.ListboxTemaPlaylist.Size = new System.Drawing.Size(284, 208);
            this.ListboxTemaPlaylist.TabIndex = 29;
            // 
            // ListboxPlaylist
            // 
            this.ListboxPlaylist.BackColor = System.Drawing.Color.Black;
            this.ListboxPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListboxPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListboxPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxPlaylist.ForeColor = System.Drawing.Color.White;
            this.ListboxPlaylist.FormattingEnabled = true;
            this.ListboxPlaylist.Location = new System.Drawing.Point(12, 51);
            this.ListboxPlaylist.Name = "ListboxPlaylist";
            this.ListboxPlaylist.Size = new System.Drawing.Size(257, 208);
            this.ListboxPlaylist.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(565, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Nueva Lista De Reproducción";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(734, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(696, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(658, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(402, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(440, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(364, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaListaDeReproducciónToolStripMenuItem,
            this.sobreNosotrosToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nuevaListaDeReproducciónToolStripMenuItem
            // 
            this.nuevaListaDeReproducciónToolStripMenuItem.Name = "nuevaListaDeReproducciónToolStripMenuItem";
            this.nuevaListaDeReproducciónToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.nuevaListaDeReproducciónToolStripMenuItem.Text = "Nueva Lista de Reproducción";
            // 
            // sobreNosotrosToolStripMenuItem
            // 
            this.sobreNosotrosToolStripMenuItem.Name = "sobreNosotrosToolStripMenuItem";
            this.sobreNosotrosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.sobreNosotrosToolStripMenuItem.Text = "Sobre Nosotros";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 446);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ListboxPlaylist);
            this.Controls.Add(this.ListboxTemaPlaylist);
            this.Controls.Add(this.listareproduccion);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.browse);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Reproductor";
            this.Text = "Esplai Music";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.norepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomOff)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listareproduccion;
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
        private System.Windows.Forms.Timer timer1;
        private XComponent.SliderBar.MACTrackBar volumen;
        private System.Windows.Forms.Label playedTimeLabel;
        private System.Windows.Forms.Label labelMovil;
        private System.Windows.Forms.Timer timerLabel;
        private System.Windows.Forms.PictureBox randomOn;
        private System.Windows.Forms.PictureBox randomOff;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarVentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarVentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ListBox ListboxTemaPlaylist;
        private System.Windows.Forms.ListBox ListboxPlaylist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaListaDeReproducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreNosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
    }
}

