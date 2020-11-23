using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace JogoTermoHeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DadosCompartilhados.somLigado();
        }

        private void iniciar_click(object sender, EventArgs e)
        {
            OpcoesDeGame screenOpcoes = new OpcoesDeGame();
            this.Hide();
            screenOpcoes.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
        }

        #region Configurações
        private void tsFacil_Click(object sender, EventArgs e)
        {
            DadosCompartilhados.Dificuldade = 8;
        }

        private void tsMedio_Click(object sender, EventArgs e)
        {
            DadosCompartilhados.Dificuldade = 6;
        }

        private void tsDificil_Click(object sender, EventArgs e)
        {
            DadosCompartilhados.Dificuldade = 4;
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

        private void btnSobre_Click(object sender, EventArgs e)
        {
            TelaSobre screen = new TelaSobre();
            this.Hide();
            screen.ShowDialog();

        }
    }
}
