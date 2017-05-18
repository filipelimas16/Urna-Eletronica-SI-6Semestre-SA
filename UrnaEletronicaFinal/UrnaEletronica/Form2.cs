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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int candidato10, int candidato20, int candidato30, int nulo, int branco)
        {
            InitializeComponent();
            label1.Text = Convert.ToString(candidato10);
            label2.Text = Convert.ToString(candidato20);
            label3.Text = Convert.ToString(candidato30);
            label4.Text = Convert.ToString(nulo);
            label5.Text = Convert.ToString(branco);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
