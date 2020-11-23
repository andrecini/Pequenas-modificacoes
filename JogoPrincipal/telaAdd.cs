using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JogoTermoHeros
{
    public partial class telaAdd : Form
    {
        public Dictionary<string, int> Registros = new Dictionary<string, int>();
        public string[] Lines;

        public telaAdd()
        {
            InitializeComponent();
        }

        public void colocaOrdem()
        {
            List<int> record = new List<int>();

            for (int x = 0; x < Lines.Length - 1; x++)
            {
                record.Add(int.Parse(Lines[x].Split(',')[1].Trim()));
            }

            record.Sort();
            for (int x = Lines.Length - 2; x >= 0; x--)
            {
                Scores.Items.Add(record[x]);
            }

            for (int x = 0; x < record.Count; x++)
            {
                for (int i = 0; i < record.Count; i++)
                {
                    if (Lines[i].Split(',')[1] == record[x].ToString())
                    {
                        Nicks.Items.Add(Lines[i].Split(',')[0]);
                        record[x] = -1;
                    }
                }
            }
        }

        public void adicionaNoArquivo()
        {
            string colocacao = textBox1.Text.ToUpper().Trim() + "," + DadosCompartilhados.score.ToString() + Environment.NewLine;
            StreamWriter sw = new StreamWriter("record.txt");
            sw.WriteLine(colocacao);
            sw.Close();
            Lines = File.ReadAllLines("record.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionaNoArquivo();
            colocaOrdem();
            panel1.Visible = false;
            panel2.Visible = true;

        }


    }
}
