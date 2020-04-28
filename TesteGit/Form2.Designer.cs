namespace TesteGit
{
    partial class FrmVoto
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
            this.lblVoto = new System.Windows.Forms.Label();
            this.picPessoa = new System.Windows.Forms.PictureBox();
            this.lblNomeVoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVoto
            // 
            this.lblVoto.AutoSize = true;
            this.lblVoto.Location = new System.Drawing.Point(12, 20);
            this.lblVoto.Name = "lblVoto";
            this.lblVoto.Size = new System.Drawing.Size(81, 13);
            this.lblVoto.TabIndex = 0;
            this.lblVoto.Text = "Você escolheu ";
            // 
            // picPessoa
            // 
            this.picPessoa.Location = new System.Drawing.Point(12, 50);
            this.picPessoa.Name = "picPessoa";
            this.picPessoa.Size = new System.Drawing.Size(1201, 561);
            this.picPessoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPessoa.TabIndex = 1;
            this.picPessoa.TabStop = false;
            this.picPessoa.Click += new System.EventHandler(this.picPessoa_Click);
            // 
            // lblNomeVoto
            // 
            this.lblNomeVoto.AutoSize = true;
            this.lblNomeVoto.Location = new System.Drawing.Point(90, 20);
            this.lblNomeVoto.Name = "lblNomeVoto";
            this.lblNomeVoto.Size = new System.Drawing.Size(0, 13);
            this.lblNomeVoto.TabIndex = 2;
            // 
            // FrmVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 623);
            this.Controls.Add(this.lblNomeVoto);
            this.Controls.Add(this.picPessoa);
            this.Controls.Add(this.lblVoto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVoto";
            this.Text = "Seu voto!";
            this.Load += new System.EventHandler(this.FrmVoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoto;
        private System.Windows.Forms.PictureBox picPessoa;
        private System.Windows.Forms.Label lblNomeVoto;
    }
}