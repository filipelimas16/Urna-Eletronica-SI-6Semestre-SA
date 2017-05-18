using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        string num ; //armazena o número do candidato
         
        int candidato10, candidato20, candidato30, branco, nulo;
        int contUm;
        int min, seg;
        int contClick;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero(object sender, EventArgs e) //leitura dos numeros clicados
        {
            Button bt = (Button)sender;
            textBox1.Text = textBox1.Text + bt.Text;
            contClick++;
            if (contClick > 2)
            {
                MessageBox.Show("Desculpe! Apenas 2 digitos");
                textBox1.ResetText();
                contClick = 0;
                pictureBox1.Image = Properties.Resources.vote;
            }

        }

        private void btn_branco_Click(object sender, EventArgs e) //botao branco
        {
            pictureBox1.Image = Properties.Resources.Branco;
            lblNomeCandidato.ResetText();
            textBox1.Text = "--";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempo.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void temp(object sender, EventArgs e)
        {
            contUm--;
            min = (contUm / 3600);
            seg = (contUm % 3600) / 60 + 59;
            if (min == 0 && seg == 0)
            {
                tempo.Stop();
                var resultado = new Form2(candidato10, candidato20, candidato30, nulo, branco);
                resultado.ShowDialog();


            }


            lbltempo.Text = String.Format("{0:#,0#}:{1:#,0#}", min, seg);


        }

        private void btn_corrige_Click(object sender, EventArgs e) //botao corrige não funciona
        {
            textBox1.Clear();
            contClick = 0;
            lblNomeCandidato.ResetText();
            pictureBox1.Image = Properties.Resources.vote;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//identifica o candidato
        {
            num = textBox1.Text;

            if (num == "10")
            {
                pictureBox1.Image = Properties.Resources.jon;
                lblNomeCandidato.Text = "Jon Snow";

            }

            else if (num == "20")
            {
                pictureBox1.Image = Properties.Resources.daenarys;
                lblNomeCandidato.Text = "Daenarys Targaryen";
            }

            else if (num == "30")
            {
                pictureBox1.Image = Properties.Resources.cersei;
                lblNomeCandidato.Text = "Cersei Lannister";
            }
            else if (num != "1" && num != "2" && num != "3" && num != "4" && num != "5" && num != "6" &&
                  num != "7" && num != "8" && num != "9" && num != "0" && num != "--")
             {
                 pictureBox1.Image = Properties.Resources.invalido;
             }
           
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            if (contClick < 2 && num != "--")
            {
                MessageBox.Show("Entre com 2 numeros!");

            }
            else
            {
                contClick = 0;

                System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/SomConfirma.wav");
                Player.Play();

                if (num == "10")
                {
                    candidato10 += 1;
                    textBox1.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.vote;
                }
                else if (num == "20")
                {
                    candidato20 += 1;
                    textBox1.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.vote;
                }
                else if (num == "30")
                {
                    candidato30 += 1;
                    textBox1.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.vote;
                }
                else if (num == "--")
                {
                    branco += 1;
                    textBox1.Clear();
                    pictureBox1.Image = Properties.Resources.vote;
                }

                else
                {
                    nulo += 1;
                    textBox1.Clear();
                    pictureBox1.Image = Properties.Resources.vote;
                }
            }
        }
    
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
