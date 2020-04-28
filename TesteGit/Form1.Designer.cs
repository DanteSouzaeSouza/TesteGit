namespace TesteGit
{
    partial class FrmVotar
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
            this.cbxTelma = new System.Windows.Forms.CheckBox();
            this.cbxManu = new System.Windows.Forms.CheckBox();
            this.cbxRafa = new System.Windows.Forms.CheckBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTelma
            // 
            this.cbxTelma.AutoSize = true;
            this.cbxTelma.Location = new System.Drawing.Point(316, 39);
            this.cbxTelma.Name = "cbxTelma";
            this.cbxTelma.Size = new System.Drawing.Size(55, 17);
            this.cbxTelma.TabIndex = 0;
            this.cbxTelma.Text = "Telma";
            this.cbxTelma.UseVisualStyleBackColor = true;
            this.cbxTelma.CheckedChanged += new System.EventHandler(this.cbxTelma_CheckedChanged);
            // 
            // cbxManu
            // 
            this.cbxManu.AutoSize = true;
            this.cbxManu.Location = new System.Drawing.Point(316, 83);
            this.cbxManu.Name = "cbxManu";
            this.cbxManu.Size = new System.Drawing.Size(53, 17);
            this.cbxManu.TabIndex = 1;
            this.cbxManu.Text = "Manu";
            this.cbxManu.UseVisualStyleBackColor = true;
            this.cbxManu.CheckedChanged += new System.EventHandler(this.cbxManu_CheckedChanged);
            // 
            // cbxRafa
            // 
            this.cbxRafa.AutoSize = true;
            this.cbxRafa.Location = new System.Drawing.Point(316, 130);
            this.cbxRafa.Name = "cbxRafa";
            this.cbxRafa.Size = new System.Drawing.Size(49, 17);
            this.cbxRafa.TabIndex = 2;
            this.cbxRafa.Text = "Rafa";
            this.cbxRafa.UseVisualStyleBackColor = true;
            this.cbxRafa.CheckedChanged += new System.EventHandler(this.cbxRafa_CheckedChanged);
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(136, 235);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(142, 64);
            this.btnVotar.TabIndex = 4;
            this.btnVotar.Text = "VOTAR!";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TesteGit.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVotar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.cbxRafa);
            this.Controls.Add(this.cbxManu);
            this.Controls.Add(this.cbxTelma);
            this.Name = "FrmVotar";
            this.Text = "Faça sua escolha!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxTelma;
        private System.Windows.Forms.CheckBox cbxManu;
        private System.Windows.Forms.CheckBox cbxRafa;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

