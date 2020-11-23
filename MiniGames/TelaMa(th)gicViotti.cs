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
    public partial class TelaMa_th_gicViotti : Form
    {
        public int acumulador = 0;
        public string viotti = "******";

        public TelaMa_th_gicViotti()
        {
            InitializeComponent();
            txtSegredo.Focus();
        }


        private void FrMinigame3_Load(object sender, EventArgs e)
        {
            txtSegredo.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSegredo.Text.Contains("sexta"))
                {
                    viotti = "VIOTTI";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSegredo.Focus();

            if (acumulador == 0)
            {
                lblTexto.Text = $"EU SOU O MAGIC {viotti} E IREI \n(TENTAR) DESCOBRIR O RESULTADO\nDO NÚMERO QUE ESCOLHER";
                acumulador = 1;
                return;
            }
            else if (acumulador == 1)
            {
                lblTexto.Text = "PRIMEIRAMENTE, PENSE EM UM \nNÚMERO DE 1 A 1000";
                acumulador++;
                return;
            }
            else if (acumulador == 2)
            {
                lblTexto.Text = "AGORA, MULTIPLIQUE ESSE \nNÚMERO POR 9";
                acumulador++;
                return;
            }
            else if (acumulador == 3)
            {
                lblTexto.Text = "E ENTÃO, NÃO SE ESQUEÇA DE \nSOMAR OS ALGARISMOS, \nSEU CORINTHIANO LADRÃO!";
                acumulador++;
                return;
            }
            else if (acumulador == 4)
            {
                lblTexto.Text = "SOME 19";
                acumulador++;
                return;
            }
            else if (acumulador == 5)
            {
                lblTexto.Text = "MULTIPLIQUE POR 9 DE NOVO.\nTÁ ACHANDO QUE É MOLEZA?";
                acumulador++;
                return;
            }
            else if (acumulador == 6)
            {
                lblTexto.Text = "SOME OS ALGARISMOS NOVAMENTE";
                acumulador++;
                return;
            }
            else if (acumulador == 7)
            {
                lblTexto.Text = "MULTIPLIQUE POR 9...NÃÃÃOOO!\nNEM 9, NEM 11, MULTIPLIQUE POR 10";
                acumulador++;
                return;
            }
            else if (acumulador == 8)
            {
                lblTexto.Text = "ADICIONE 900 NESSE NÚMERO\nAÍ";
                acumulador++;
                return;
            }
            else if (acumulador == 9)
            {
                lblTexto.Text = "AGORA... DEIXA EU ME LEMBRAR...";
                acumulador++;
                return;
            }
            else if (acumulador == 10)
            {
                lblTexto.Text = "AH, É. DIVIDA POR 4.\n'TÔ FICANDO VELHO MESMO...'";
                acumulador++;
                return;
            }
            else if (acumulador == 11)
            {
                lblTexto.Text = "ESSA PARTE EU LEMBRO!\nMULTIPLIQUE POR 63";
                acumulador++;
                return;
            }
            else if (acumulador == 12)
            {
                lblTexto.Text = "SOME PELA ÚLTIMA VEZ OS\nALGARISMOS. ATÉ MESMO OS DEPOIS\nDA VÍRGULA, SEU PREGUIÇOSO";
                acumulador++;
                return;
            }
            else if (acumulador == 13)
            {
                lblTexto.Text = "SOME 43";
                acumulador++;
                return;
            }
            else if (acumulador == 14)
            {
                lblTexto.Text = "E... UFFA! POR ÚLTIMO, MAS NÃO\nMENOS IMPORTANTE, DIVIDA POR 17";
                acumulador++;
                return;
            }
            else if (acumulador == 15)
            {
                lblTexto.Text = "PRONTO! DEIXE-ME CHECAR\n MEUS PENSAMENTOS MÁGICOS...";
                acumulador++;
                return;
            }
            else if (acumulador == 16)
            {
                lblTexto.Font = new Font(lblTexto.Font.Name, lblTexto.Font.Size - 2,
                lblTexto.Font.Style, lblTexto.Font.Unit);
                btnPronto.Text = "SAIR";
                lblTexto.Text = "O RESULTADO DEU 3!!! HAHA!!ACHOU\nQUE EU NÃO SABIA CONTAR, NÉ? NÃO SOU\nPALMEIRENSE, NÃO! SÓ CONTO O QUE\nEU TENHO CERTEZA QUE EXISTE!";
                acumulador++;
                return;
            }
            else
            {
                acumulador = 0;
                lblTexto.Font = new Font(lblTexto.Font.Name, lblTexto.Font.Size + 2,
                lblTexto.Font.Style, lblTexto.Font.Unit);

                OpcoesDeGame tela = new OpcoesDeGame();
                Hide();
                tela.ShowDialog();
            }
        }
    }
}