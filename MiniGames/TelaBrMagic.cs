using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace JogoTermoHeros
{
    public partial class TelaBrMagic : Form
    {
        public class Soma
        {
            public static int Pontos = 0;
        }

        public TelaBrMagic()
        {
            InitializeComponent();
            btnSim.Visible = false;
            btnNao.Visible = false;
            btnJogarNovamente.Visible = false;
        }
  
        #region Configurações
        private void tsSomLigado_Click(object sender, EventArgs e)
        {
            DadosCompartilhados.somLigado();
        }
        private void tsSomDesligado_Click(object sender, EventArgs e)
        {
            DadosCompartilhados.somDesligado();
        }
        public void PadraoFinal()
        {
            if (Soma.Pontos == 1)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Bragantino.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 2)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Ceara.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 3)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/SCCP.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 4)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Coritiba.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 5)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Flamengo.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 6)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Fluminense.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 7)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Fortaleza.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 8)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Goiais.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 9)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Gremio.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 10)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Internacional.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 11)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Palmeiras.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 12)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Santos.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 13)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/SPFC.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 14)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Sport.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
            else if (Soma.Pontos == 15)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Vasco.jpeg");
                btnJogarNovamente.Visible = true;
                btnNao.Visible = false;
                btnSim.Visible = false;
            }
        }
        #endregion

        #region Botões
        public int contPxm = 0;
        private void btnPxm_Click(object sender, EventArgs e)
        {
            contPxm++;

            if (contPxm == 1)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Tutorial2.jpeg");
            }
            else if (contPxm == 2)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Tutorial3.jpeg");
            }
            else if (contPxm == 3)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Tutorial4.jpeg");
            }
            else if (contPxm == 4)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Tutorial5.jpeg");
            }
            else if (contPxm == 5)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Times1.jpeg");
            }
            else if (contPxm == 6)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Times2.jpeg");
                btnPxm.Visible = false;
                btnSim.Visible = true;
                btnNao.Visible = true;
            }
        }

        public int contSimOuNao = 0;
        private void btnSim_Click(object sender, EventArgs e)
        {
            contSimOuNao++;

            if (contSimOuNao == 1)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Times3.jpeg");
                Soma.Pontos++;
            }
            else if (contSimOuNao == 2)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Times4.jpeg");
                Soma.Pontos = Soma.Pontos + 4;
            }
            else if (contSimOuNao == 3)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Times5.jpeg");
                Soma.Pontos = Soma.Pontos + 8;
            }
            else if (contSimOuNao == 4)
            {
                Soma.Pontos = Soma.Pontos + 2;

                PadraoFinal();
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            contSimOuNao++;

            if (contSimOuNao == 1)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Times3.jpeg");
            }
            else if (contSimOuNao == 2)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Times4.jpeg");
            }
            else if (contSimOuNao == 3)
            {
                pictureBoxPrincipal.Image = Image.FromFile("img/Times5.jpeg");

            }
            else if (contSimOuNao == 4)
            {
                PadraoFinal();

                if (Soma.Pontos == 0)
                {
                    btnNao.Visible = true;
                    btnSim.Visible = true;
                    contPxm = 5;
                    contSimOuNao = 0;
                    MessageBox.Show("Rapaz...Você esqueceu o time? Calma que vou te dar outra chance!");
                    btnPxm.PerformClick();
                }
            }

        }

        private void btnJogarNovamente_Click(object sender, EventArgs e)
        {
            Soma.Pontos = 0;
            pictureBoxPrincipal.Image = Image.FromFile("img/Times1.jpeg");
            btnPxm.Visible = true;
            contPxm = 5;
            contSimOuNao = 0;
            btnJogarNovamente.Visible = false;
        }

        #endregion

    }
}
