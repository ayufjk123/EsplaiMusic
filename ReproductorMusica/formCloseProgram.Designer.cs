namespace EsplaiMusic
{
    partial class formCloseProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCloseProgram));
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qué desea hacer?";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(12, 72);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 1;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Location = new System.Drawing.Point(103, 72);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(75, 23);
            this.minimizar.TabIndex = 2;
            this.minimizar.Text = "Minimizar";
            this.minimizar.UseVisualStyleBackColor = true;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(193, 72);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // info
            // 
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(34, 23);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(32, 32);
            this.info.TabIndex = 4;
            this.info.TabStop = false;
            // 
            // formCloseProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 107);
            this.ControlBox = false;
            this.Controls.Add(this.info);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCloseProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.PictureBox info;
    }
}