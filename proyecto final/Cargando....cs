using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador < 5)
            {
                picture[contador].BackgroundImage = proyecto_final.Properties.Resources.Circle2;
                contador++;
                label1.Text = "Cargando al " + contador * 20 + "%";
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Menu p = new Menu();
                p.Show();
            }
        }
        PictureBox[] picture;
        int contador = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            picture=new PictureBox[5] {pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5};
        }

        
    }
}
