using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace JogoTermoHeros
{
    public class DadosCompartilhados
    {
        public static SoundPlayer som;


        public static int score;
        public static int Dificuldade = 6;
        public static bool Som;
        public static void somLigado()
        {           
            som = new SoundPlayer("musica.wav");
            som.PlayLooping();
        }
        public static void somDesligado()
        {
            som.Stop();
        }
        public static int Personagem;
    }
}
