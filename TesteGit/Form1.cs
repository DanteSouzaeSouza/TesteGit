using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteGit
{
    public partial class FrmVotar : Form
    {
        public FrmVotar()
        {
            InitializeComponent();
        }

        // variáveis colocadas aqui são passáveis para outros forms.
        string voto = "";

        private void btnVotar_Click(object sender, EventArgs e)
        {

            // usando Switch para controlar opções
            switch (voto)
            {
                case "t":
                    // instanciando o form com o voto no parâmetro
                    FrmVoto meuVoto = new FrmVoto("Telma");
                    // chamando o formulário com a foto do eleito
                    meuVoto.Show();
                    // resetando estados dos componentes
                    cbxTelma.Checked = false;                             
                    voto = "";
                    break;
                case "m":
                    FrmVoto meuVoto2 = new FrmVoto("Manu");
                    meuVoto2.Show();
                    cbxManu.Checked = false;
                    voto = "";
                    break;
                case "r":
                    FrmVoto meuVoto3 = new FrmVoto("Rafa");
                    meuVoto3.Show();
                    cbxRafa.Checked = false;
                    voto = "";
                    break;
                default:
                    MessageBox.Show("Você não escolheu NINGUÉM!");
                    break;
            }

        }

        // controlando estados dos checkBoxes

        private void cbxTelma_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTelma.Checked)
            {
                voto = "t";
                cbxManu.Checked = false;
                cbxRafa.Checked = false;
            }
        }

        private void cbxManu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxManu.Checked)
            {
                voto = "m";
                cbxTelma.Checked = false;
                cbxRafa.Checked = false;
            }
        }

        private void cbxRafa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRafa.Checked)
            {
                voto = "r";
                cbxManu.Checked = false;
                cbxTelma.Checked = false;
            }
        }
    }
}
