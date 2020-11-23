using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace JogoTermoHeros.JogoPrincipal
{
    public partial class jogoPrincipal : Form
    {
        #region variáveis 
        //variáveis de movimentação
        public bool cima;
        public bool up;
        //variáveis de velocidade       
        public int aceleracao = 3;
        public int velocidade;
        public int v = DadosCompartilhados.Dificuldade;
        //variáveis de contagem
        public int contador = 200;
        public int contador2 = 0;
        public int contador3 = 0;
        //variável de pontuação
        public int score = -10;
        //variável para gerar obstaculos
        private string[] conteudo;
        int quant = 0;
        private PictureBox[] obstaculo = new PictureBox[100];
        string[] caracteristicas;

        #endregion

        public jogoPrincipal()
        {
            InitializeComponent();
            
            if(DadosCompartilhados.Personagem == 0)
            {
                picPersonagem.Image = imageList1.Images[0];
            }
            else if (DadosCompartilhados.Personagem == 1)
            {
                picPersonagem.Image = imageList1.Images[1];
            }
            else if (DadosCompartilhados.Personagem == 2)
            {
                picPersonagem.Image = imageList1.Images[2];
            }
        }

        /// <summary>
        /// Timer para gerar açoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTimer(object sender, EventArgs e)
        {
            VerificaExtremos();
            EncostaObstaculo();
            MovePersonagem();

            Gravidade();
            VerificaExtremos();
            EncostaObstaculo();

            if (contador == 1800 / v)
            {

                GeraObstaculo();
                Pontuacao();
                if (contador3 == 7)
                {
                    v++;
                    aceleracao = v / 2;
                    contador3 = 0;
                }

                contador = 0;
                contador3++;
            }
            MoveObstaculo();
            contador++;

        }

        /// <summary>
        /// Soma a pontuação do usuário
        /// </summary>
        public void Pontuacao()
        {
            score += 10;
            label3.Text = $"Score: {score}";
            DadosCompartilhados.score = score;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conteudo = File.ReadAllLines("obstaculos.txt");
        }

        public void AbreTelaRecord()
        {
            telaAdd screen = new telaAdd();
            screen.ShowDialog();
        }

        private void jogoPrincipal_Load(object sender, EventArgs e)
        {
            conteudo = File.ReadAllLines("obstaculos.txt");
        }

        #region Métodos Personagens
        /// <summary>
        /// método para ativar movimento
        /// </summary>
        /// <param name="cima"></param>
        /// <param name="baixo"></param>
        /// <param name="esquerda"></param>
        /// <param name="direita"></param>
        public void MovePersonagem()
        {
            if (cima && up)
            {
                picPersonagem.Top -= v + 2;
                return;
            }
            if (cima)
            {
                picPersonagem.Top -= 6;
            }

        }

        /// <summary>
        /// método para que caso vá até o final do 
        /// forms, ele apareca do outro lado.
        /// </summary>
        public void VerificaExtremos()
        {
            // Impede a pictureBox1 de ultrapassar o topo do mapa
            if (picPersonagem.Top >= 400)
            {
                picPersonagem.Location = new Point(125, 400);
                aceleracao = 0; //Para a gravidade para não causar efeito "tremer"
            }
            // Impede a pictureBox1 de ultrapassar o base do mapa
            if (picPersonagem.Top <= 14)
            {
                picPersonagem.Location = new Point(125, 14);
            }

        }

        /// <summary>
        /// Metodo para gerar gravidade
        /// </summary>
        /// <param name="cima"></param>
        public void Gravidade()
        {
            if (picPersonagem.Top > 540 - 93 || !cima)
            {
                picPersonagem.Top += aceleracao;
            }
            if (contador2 == 5)
            {
                //velocidade += aceleracao;
                aceleracao += 2;
                contador2 = 0;
            }
            if (cima)
            {
                aceleracao = 3;
                contador2 = 0;
            }

            contador2++;


        }

        /// <summary>
        /// quando o usuario aperta o space
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApertaTecla(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                cima = true;
                aceleracao = 3;
            }

            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }
        }

        /// <summary>
        /// quando o usuario solta o space
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoltaTecla(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                cima = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
        }
        #endregion 

        #region Métodos Obstáculos
        /// <summary>
        /// Lógica para mover o obstáculo no mapa
        /// </summary>
        public void MoveObstaculo()
        {
            for (int x = 0; x < quant; x++)
            {
                obstaculo[x].Left -= velocidade;

                if (obstaculo[x].Left <= 0 - obstaculo[x].Width)
                {
                    Controls.Remove(obstaculo[x]);
                }
            }
        }

        /// <summary>
        /// método para detectar colisão
        /// </summary>
        /// <param name="cima"></param>
        /// <param name="baixo"></param>
        /// <param name="esquerda"></param>
        /// <param name="direita"></param>
        public void EncostaObstaculo()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag.ToString() == "obstaculo")
                {
                    if ((picPersonagem.Bounds).IntersectsWith(((PictureBox)x).Bounds))
                    {
                        timer.Stop();
                        AbreTelaRecord();
                    }
                }
                else if (x is PictureBox && x.Tag.ToString() == "moeda")
                {
                    if ((picPersonagem.Bounds).IntersectsWith(((PictureBox)x).Bounds))
                    {
                        Controls.Remove(x);
                        Pontuacao();
                    }
                }
            }
        }

        /// <summary>
        /// Gera o obstáculo de acordo com os dados do arquivo txt
        /// </summary>
        public void GeraObstaculo()
        {
            int[] conjuntos = new int[26];
            int acumulador = 1;
            conjuntos[0] = 0;

            for (int x = 1; x < conteudo.Length; x++)
            {
                if (conteudo[x - 1].Substring(0, 1) != conteudo[x].Substring(0, 1))
                {
                    conjuntos[acumulador] = x;
                    acumulador++;
                }
            }

            Random rnd = new Random();
            int sorteado = rnd.Next(0, acumulador);

            caracteristicas = conteudo[conjuntos[sorteado]].Split(',');
            quant = int.Parse(caracteristicas[6]);


            for (int x = 0; x < quant; x++)
            {
                obstaculo[x] = new PictureBox();
                obstaculo[x].BackColor = Color.Transparent
                    ;
            }

            if (caracteristicas[5] == "R")
                velocidade = 2 * v;
            else if (caracteristicas[5] == "O")
                velocidade = v;
            else
                velocidade = v + 2;

            for (int x = 0; x < quant; x++)
            {
                caracteristicas = conteudo[conjuntos[sorteado] + x].Split(',');

                obstaculo[x].Width = int.Parse(caracteristicas[1]);
                obstaculo[x].Height = int.Parse(caracteristicas[2]);

                obstaculo[x].Left = int.Parse(caracteristicas[3]);
                obstaculo[x].Top = int.Parse(caracteristicas[4]);

                obstaculo[x].Image = Image.FromFile($"imagens/{caracteristicas[7]}");
                obstaculo[x].SizeMode = PictureBoxSizeMode.StretchImage;

                if (caracteristicas[5] == "O" || caracteristicas[5] == "R")
                    obstaculo[x].Tag = "obstaculo";
                else
                    obstaculo[x].Tag = "moeda";

                Controls.Add(obstaculo[x]);
            }
        }

        #endregion

        #region Botões Barra Menu
        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            this.ActiveControl = null;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OpcoesDeGame screen = new OpcoesDeGame();
            this.Hide();
            screen.Show();
        }
        #endregion
    }
}
