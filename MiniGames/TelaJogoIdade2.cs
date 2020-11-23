using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace JogoTermoHeros
{
    public partial class TelaJogoIdade2 : Form
    {
        public TelaJogoIdade2()
        {
            InitializeComponent();
            MostraCartoes(SorteiaSemRepeticao());
            picWuo.Visible = true;
        }

        public int contadorBotoes = 0;
        public int idade = 0;

        public HashSet<int> sorteados = new HashSet<int>();

        public HashSet<int> SorteiaSemRepeticao()
        {
            Random aleatorio = new Random();
            bool passa;

            if (sorteados.Count < 6)
                for (int i = 1; i <= 6; i++)
                {
                    do
                    {
                        passa = sorteados.Add(aleatorio.Next(1, 7));
                    } while (!passa);
                }

            return sorteados;
        }

        public void MostraCartoes(HashSet<int> sorteado)
        {
            int num = sorteado.ElementAt(contadorBotoes);

            if (num == 1)
            {
                cartao1.Visible = true;
                cartao2.Visible = false;
                cartao3.Visible = false;
                cartao4.Visible = false;
                cartao5.Visible = false;
                cartao6.Visible = false;
            }
            else if (num == 2)
            {
                cartao1.Visible = false;
                cartao2.Visible = true;
                cartao3.Visible = false;
                cartao4.Visible = false;
                cartao5.Visible = false;
                cartao6.Visible = false;
            }
            else if (num == 3)
            {
                cartao1.Visible = false;
                cartao2.Visible = false;
                cartao3.Visible = true;
                cartao4.Visible = false;
                cartao5.Visible = false;
                cartao6.Visible = false;
            }
            else if (num == 4)
            {
                cartao1.Visible = false;
                cartao2.Visible = false;
                cartao3.Visible = false;
                cartao4.Visible = true;
                cartao5.Visible = false;
                cartao6.Visible = false;
            }
            else if (num == 5)
            {
                cartao1.Visible = false;
                cartao2.Visible = false;
                cartao3.Visible = false;
                cartao4.Visible = false;
                cartao5.Visible = true;
                cartao6.Visible = false;
            }
            else
            {
                cartao1.Visible = false;
                cartao2.Visible = false;
                cartao3.Visible = false;
                cartao4.Visible = false;
                cartao5.Visible = false;
                cartao6.Visible = true;
            }
        }

        public void MostrarResposta()
        {
            picWuo.Visible = true;
            picBalao.Visible = true;
            cartao1.Visible = false;
            cartao2.Visible = false;
            cartao3.Visible = false;
            cartao4.Visible = false;
            cartao5.Visible = false;
            cartao6.Visible = false;
            btnNao.Enabled = false;
            btnSim.Enabled = false;
            btnNao.Visible = false;
            btnSim.Visible = false;
            btnMostrar.Visible = true;
            txtFalas.Size = new Size(315, 120);
            txtFalas.Location = new Point(171, 72);
            picBalao.Size = new Size(405, 253);
            picBalao.Location = new Point(105, 28);
            txtFalas.Text = "Booom, espere um pouquinho para eu advinhar a sua idade... pararam pam pam... pararam pampam...";
        }

        private void btnSim_Click_1(object sender, EventArgs e)
        {
            contadorBotoes++;

            if (cartao1.Visible)
            {
                idade += 1;
            }
            else if (cartao2.Visible)
            {
                idade += 2;
            }
            else if (cartao3.Visible)
            {
                idade += 4;
            }
            else if (cartao4.Visible)
            {
                idade += 8;
            }
            else if (cartao5.Visible)
            {
                idade += 16;
            }
            else
            {
                idade += 32;
            }

            if (contadorBotoes == 6)
            {
                MostrarResposta();
            }
            else
                MostraCartoes(SorteiaSemRepeticao());
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            contadorBotoes++;

            if (contadorBotoes == 6)
            {
                MostrarResposta();
            }
            else MostraCartoes(SorteiaSemRepeticao());
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            txtFalas.Size = new Size(195, 111);
            txtFalas.Location = new Point(315, 69);
            picBalao.Size = new Size(267, 228);
            picBalao.Location = new Point (274, 31);
            txtFalas.Text = $"Sua idade é: {idade}, não é mesmo? cof cof cof cof cof";
            btnMostrar.Visible = false;
            btnSair.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            OpcoesDeGame telaOpcoes = new OpcoesDeGame();
            this.Hide();
            telaOpcoes.Show();
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
        #endregion

    }
}
