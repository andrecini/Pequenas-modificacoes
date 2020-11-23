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
    public partial class TelaJogoIdadeUm : Form
    {
        public TelaJogoIdadeUm()
        {
            InitializeComponent();
        }

        public int contadorFalas = 0;

        private void btnPxm_Click(object sender, EventArgs e)
        {
            contadorFalas++;

            if (contadorFalas == 1)
                txtFalas.Text = "Meu nome é Oogway Wuo cof cof ...";
            else if (contadorFalas == 2)
                txtFalas.Text = "Nesse jogo, cof irei fazer uma super mágica!";
            else if (contadorFalas == 3)
                txtFalas.Text = "Como já sabem, eu tenho 97 anos, mas e vocês?";
            else if (contadorFalas == 4)
                txtFalas.Text = "Não me conte. Pode deixar que eu descubro!";
            else if (contadorFalas == 5)
            {
                txtFalas.Text = "Pronto para começar? cof cof cof...";
                btnPxm.Text = "Começar";
            }
            else if (contadorFalas == 6)
            {
                pictureBox2.Size = new Size(327, 218);
                txtFalas.Size = new Size(244, 126);
                txtFalas.Text = "Irei te mostrar algumas cartelas e você me dirá se ela possui sua idade ou não. Okay?";

                btnPxm.Text = "OKAY";

            }
            else
            {
                TelaJogoIdade2 screenJogo = new TelaJogoIdade2();
                screenJogo.Show();
            }

        }

     
    }
}
