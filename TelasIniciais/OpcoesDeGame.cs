using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoTermoHeros
{
    public partial class OpcoesDeGame : Form
    {
        public OpcoesDeGame()
        {
            InitializeComponent();
        }

        private void jogoWuo_click(object sender, EventArgs e)
        {
            TelaJogoIdadeUm wuoUm = new TelaJogoIdadeUm();
            wuoUm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EscolhaDePersonagens personagens = new EscolhaDePersonagens();
            personagens.ShowDialog();
        }

        private void OpcoesDeGame_Load(object sender, EventArgs e)
        {
            pictureBox1.Parent = pictureBox2;
            label1.Parent = pictureBox2;
            label2.Parent = pictureBox2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaBrMagic screen = new TelaBrMagic();
            screen.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaMa_th_gicViotti screen = new TelaMa_th_gicViotti();
            screen.ShowDialog();
        }



        #region Configurações
        private void tsFacil_Click(object sender, EventArgs e)
        {
            DadosCompartilhados.Dificuldade = 4;
        }

        private void tsMedio_Click(object sender, EventArgs e)
        {
            DadosCompartilhados.Dificuldade = 6;
        }

        private void tsDificil_Click(object sender, EventArgs e)
        {
            DadosCompartilhados.Dificuldade = 10;
        }

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
