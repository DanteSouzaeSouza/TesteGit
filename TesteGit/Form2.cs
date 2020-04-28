using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteGit
{
    public partial class FrmVoto : Form
    {
        public FrmVoto(string voto)
        {
            InitializeComponent();
            lblNomeVoto.Text = voto;          
        }

        


        private void picPessoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVoto_Load(object sender, EventArgs e)
        {
            string meuVoto = lblNomeVoto.Text;
            switch (meuVoto)
            {
                case "telma":
                    picPessoa.Image = Properties.Resources.telma; 
                    break;
                case "rafa":
                    Console.WriteLine(Path.GetFullPath("rafa.jpg"));
                    picPessoa.Load("./Resources/rafa.jpg");
                    break;
                case "manu":
                    picPessoa.Image = Image.FromFile(@"M:\Users\pcgrande\Documents\Visual Studio 2015\Projects\TesteGit\TesteGit\Resources\manu.jpg");
                    break;
                default:
                    break;
            }

        }

    }
}
