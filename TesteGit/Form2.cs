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
            // capta o valor da string enviado pelo formulário anterior
            InitializeComponent();
            lblNomeVoto.Text = voto;          
        }

        


        private void picPessoa_Click(object sender, EventArgs e)
        {
            // fecha o form se clicarmos na foto
            this.Close();
        }

        private void FrmVoto_Load(object sender, EventArgs e)
        {
            // usando o valor da label com o nome do voto.
            string meuVoto = lblNomeVoto.Text;
            // selecionando a foto a partir do voto
            switch (meuVoto)
            {
                case "Telma":
                    // maneira 1 - independente de caminho até o arquivo *melhor*
                    picPessoa.Image = Properties.Resources.telma;
                    break;
                case "Rafa":
                    // maneira 2: pedindo para o sistema localizar o arquivo usando Path.GetFullPath
                    picPessoa.Load(Path.GetFullPath("rafa.jpg"));
                    break;
                case "Manu":
                    // maneira 3: passando o caminho completo no carregamento da imagem.
                    picPessoa.Image = Image.FromFile(@"M:\\Users\\pcgrande\\Documents\\Visual Studio 2015\\Projects\\TesteGit\\TesteGit\\Resources\\manu.jpg");
                    break;
                default:
                    break;
            }

        }

    }
}
