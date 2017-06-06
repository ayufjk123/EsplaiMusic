namespace EsplaiMusic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lista = new System.Windows.Forms.ListBox();
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
            this.browse.Location = new System.Drawing.Point(288, 23);
            this.browse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(236, 44);
            this.browse.TabIndex = 0;
            this.browse.Text = "Agregar a la Lista";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lista
            // 
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lista.BackColor = System.Drawing.Color.Black;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista.ForeColor = System.Drawing.Color.White;
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 25;
            this.lista.Location = new System.Drawing.Point(122, 98);
            this.lista.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(480, 350);
            this.lista.TabIndex = 6;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // norepeat
            // 
            this.norepeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.norepeat.BackColor = System.Drawing.Color.Transparent;
            this.norepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.norepeat.Image = ((System.Drawing.Image)(resources.GetObject("norepeat.Image")));
            this.norepeat.Location = new System.Drawing.Point(406, 127);
            this.norepeat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.norepeat.Name = "norepeat";
            this.norepeat.Size = new System.Drawing.Size(64, 62);
            this.norepeat.TabIndex = 13;
            this.norepeat.TabStop = false;
            this.norepeat.Click += new System.EventHandler(this.unrepeat_Click);
            // 
            // repeat
            // 
            this.repeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.repeat.BackColor = System.Drawing.Color.Transparent;
            this.repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repeat.Image = EsplaiMusic.Properties.Resources.Play_Mode_Repeat_All_Hot_icon;
            this.repeat.Location = new System.Drawing.Point(406, 127);
            this.repeat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(64, 62);
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
            this.duracionCancion.Location = new System.Drawing.Point(122, 35);
            this.duracionCancion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.duracionCancion.Maximum = 10;
            this.duracionCancion.Minimum = 0;
            this.duracionCancion.Name = "duracionCancion";
            this.duracionCancion.Size = new System.Drawing.Size(1304, 28);
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1438, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "00:00";
            // 
            // stop
            // 
            this.stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.Image = EsplaiMusic.Properties.Resources.Stop_icon;
            this.stop.Location = new System.Drawing.Point(482, 127);
            this.stop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(64, 62);
            this.stop.TabIndex = 17;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // anterior
            // 
            this.anterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.anterior.BackColor = System.Drawing.Color.Transparent;
            this.anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior.Image = EsplaiMusic.Properties.Resources.Skip_backward_icon;
            this.anterior.Location = new System.Drawing.Point(558, 127);
            this.anterior.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(64, 62);
            this.anterior.TabIndex = 18;
            this.anterior.TabStop = false;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // pause
            // 
            this.pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Image = EsplaiMusic.Properties.Resources.Pause_icon;
            this.pause.Location = new System.Drawing.Point(634, 127);
            this.pause.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(64, 62);
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
            this.play.Image = EsplaiMusic.Properties.Resources.Play_icon;
            this.play.Location = new System.Drawing.Point(634, 127);
            this.play.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(64, 62);
            this.play.TabIndex = 20;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // siguiente
            // 
            this.siguiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.siguiente.BackColor = System.Drawing.Color.Transparent;
            this.siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siguiente.Image = EsplaiMusic.Properties.Resources.Skip_forward_icon;
            this.siguiente.Location = new System.Drawing.Point(710, 127);
            this.siguiente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(64, 62);
            this.siguiente.TabIndex = 21;
            this.siguiente.TabStop = false;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // mute
            // 
            this.mute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mute.BackColor = System.Drawing.Color.Transparent;
            this.mute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mute.Image = EsplaiMusic.Properties.Resources.Sound_off_icon;
            this.mute.Location = new System.Drawing.Point(786, 127);
            this.mute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(64, 62);
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
            this.unmute.Image = EsplaiMusic.Properties.Resources.Sound_on_icon;
            this.unmute.Location = new System.Drawing.Point(786, 127);
            this.unmute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.unmute.Name = "unmute";
            this.unmute.Size = new System.Drawing.Size(64, 62);
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
            this.volumen.Location = new System.Drawing.Point(862, 135);
            this.volumen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.volumen.Maximum = 100;
            this.volumen.Minimum = 0;
            this.volumen.Name = "volumen";
            this.volumen.Size = new System.Drawing.Size(218, 28);
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
            this.playedTimeLabel.ForeColor = System.Drawing.Color.White;
            this.playedTimeLabel.Location = new System.Drawing.Point(38, 35);
            this.playedTimeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playedTimeLabel.Name = "playedTimeLabel";
            this.playedTimeLabel.Size = new System.Drawing.Size(66, 25);
            this.playedTimeLabel.TabIndex = 24;
            this.playedTimeLabel.Text = "00:00";
            // 
            // labelMovil
            // 
            this.labelMovil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMovil.AutoSize = true;
            this.labelMovil.Location = new System.Drawing.Point(758, 490);
            this.labelMovil.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMovil.Name = "labelMovil";
            this.labelMovil.Size = new System.Drawing.Size(58, 25);
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
            this.randomOn.Location = new System.Drawing.Point(330, 127);
            this.randomOn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.randomOn.Name = "randomOn";
            this.randomOn.Size = new System.Drawing.Size(64, 62);
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
            this.randomOff.Location = new System.Drawing.Point(330, 127);
            this.randomOff.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.randomOff.Name = "randomOff";
            this.randomOff.Size = new System.Drawing.Size(64, 62);
            this.randomOff.TabIndex = 27;
            this.randomOff.TabStop = false;
            this.randomOff.Click += new System.EventHandler(this.randomOff_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelButtons.BackColor = System.Drawing.Color.Silver;
            this.panelButtons.Controls.Add(this.randomOff);
            this.panelButtons.Controls.Add(this.randomOn);
            this.panelButtons.Controls.Add(this.playedTimeLabel);
            this.panelButtons.Controls.Add(this.volumen);
            this.panelButtons.Controls.Add(this.unmute);
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
            this.panelButtons.Location = new System.Drawing.Point(54, 540);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1540, 215);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(290, 124);
            // 
            // mostrarVentanaToolStripMenuItem
            // 
            this.mostrarVentanaToolStripMenuItem.Name = "mostrarVentanaToolStripMenuItem";
            this.mostrarVentanaToolStripMenuItem.Size = new System.Drawing.Size(289, 38);
            this.mostrarVentanaToolStripMenuItem.Text = "Mostrar ventana";
            this.mostrarVentanaToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ocultarVentanaToolStripMenuItem
            // 
            this.ocultarVentanaToolStripMenuItem.Name = "ocultarVentanaToolStripMenuItem";
            this.ocultarVentanaToolStripMenuItem.Size = new System.Drawing.Size(289, 38);
            this.ocultarVentanaToolStripMenuItem.Text = "Ocultar ventana";
            this.ocultarVentanaToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(286, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(289, 38);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1648, 790);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.labelMovil);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.browse);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lista;
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
    }
}

