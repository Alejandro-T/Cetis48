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
    public partial class Pendiente_y_Angulos : Form
    {
        public Pendiente_y_Angulos()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //variables pendeinte
            double MAB, MBC, MCA;
            double A2=0, B2=0, C2=0;
            double A=0, B=0, C=0;

            //variables angulos
            double Angulo1, Angulo2, Angulo3;
            double tan1,tan2,tan3;
            double total;

            if (XAT.Text == "")
                MessageBox.Show("Falta agregar el valor X(A)", "Alerta");
            if (XBT.Text == "")
                MessageBox.Show("Falta agregar el valor X(B)", "Alerta");
            if (XCT.Text == "")
                MessageBox.Show("Falta agregar el valor X(C)", "Alerta");

            if (YAT.Text == "")
                MessageBox.Show("Falta agregar el valor Y(A)", "Alerta");
            if (YBT.Text == "")
                MessageBox.Show("Falta agregar el valor Y(B)", "Alerta");
            if (YCT.Text == "")
                MessageBox.Show("Falta agregar el valor Y(C)", "Alerta");

            //se comprube q sea numero y no otro caracter
            
            //leer puntos(X) 
            try
            {
                A = Convert.ToDouble(XAT.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en X(A)");
                return;
            }

            //try X(B)
            try
            {
                B = Convert.ToDouble(XBT.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en X(B)");
                return;
            }

            //try X(C)
            try
            {
                C = Convert.ToDouble(XCT.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en X(C)");
                return;
            }

            //Leer puntos(Y)                 
            
            //TRY Y(A)
            try
            {
                A2 = Convert.ToDouble(YAT.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en Y(A)");
                return;
            }

            //TRY Y(B)
            try
            {
                B2 = Convert.ToDouble(YBT.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en Y(B)");
                return;
            }

            //TRY Y(C)
            try
            {
                C2 = Convert.ToDouble(YCT.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en Y(C)");
                return;
            }


            //pendiente
            listBox1.Items.Add("Pendiente PMAB");
            MAB = (B2 - A2) / (B - A);
            listBox1.Items.Add(MAB.ToString());

            listBox2.Items.Add("Pendiente MBC");
            MBC = (C2 - B2) / (C - B);
            listBox2.Items.Add(MBC.ToString());

            listBox3.Items.Add("Pendiente MCA");
            MCA = (A2 - C2) / (A - C);
            listBox3.Items.Add(MCA.ToString());

            //Angulos =1/match.tan(val(texbox))
            Angulo1 = (MAB - MBC) / (1 + (MBC * MAB));
            Angulo2 = (MBC - MCA) / (1 + (MCA * MBC));
            Angulo3 = (MCA - MAB) / (1 + (MAB * MCA));
            tan1 = Math.Atan(Angulo1) * 180 / Math.PI;
            tan2 = Math.Atan(Angulo2) * 180 / Math.PI;
            tan3 = Math.Atan(Angulo3) * 180 / Math.PI;
            listBox1.Items.Add(tan1.ToString());
            listBox2.Items.Add(tan2.ToString());
            listBox3.Items.Add(tan3.ToString());
            total = tan1 + tan2 + tan3;
            this.textBox1.Text = total.ToString();
         
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            XAT.Clear();
            XBT.Clear();
            XCT.Clear();

            YAT.Clear();
            YBT.Clear();
            YCT.Clear();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
