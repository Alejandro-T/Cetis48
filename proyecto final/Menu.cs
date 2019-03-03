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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Distancia_y_punto_medio A = new Distancia_y_punto_medio();
            A.Show();
        }

        private void buttonCerrarApp_Click(object sender, EventArgs e)
        {
            DialogResult yes;

            yes = MessageBox.Show("¿Desea salir","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (yes == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (yes == DialogResult.No)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //area y per..
            Area_y_Perimetro B =new Area_y_Perimetro();
            B.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pendeinte y angulos
            Pendiente_y_Angulos c = new Pendiente_y_Angulos();
            c.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
              Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
              Int32 ancho = (this.Width - panel3.Width) / 2;
              panel3.Location = new Point(ancho, panel3.Location.Y);
              timer1.Enabled = true;
              label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Distancia_y_punto_medio A = new Distancia_y_punto_medio();
            A.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width:(141),height:(96));
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: (102), height: (61));
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(width: (141), height: (96));
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(width: (102), height: (61));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //area y per..
            Area_y_Perimetro B = new Area_y_Perimetro();
            B.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //pendeinte y angulos
            Pendiente_y_Angulos c = new Pendiente_y_Angulos();
            c.Show();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(width: (141), height: (96));
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(width: (102), height: (61));
        }

        
    }
}
