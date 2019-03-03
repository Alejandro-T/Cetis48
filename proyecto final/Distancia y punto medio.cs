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
    public partial class Distancia_y_punto_medio : Form
    {
        public Distancia_y_punto_medio()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //distcncia
            double A = 0, B = 0, C = 0;
            double DabX;
            double DbcX;
            double DcaX;
            double A2, B2, C2;
            double Daby;
            double Dbcy;
            double Dcay;
            double TotalsumaAB, TotalsumaBc, TotalsumaCa;
            double TotalAB, TotalBC, TotalCA;

            //punto medio                       
            double PMABX, PMBCX, PMCAX;
            double PMABY, PMBCY, PMCAY;






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

            //opreacion de sacar la x
            DabX = (Math.Pow((B - A), 2));
            DbcX = (Math.Pow((B - C), 2));
            DcaX = (Math.Pow((A - C), 2));


            //operacion sacar la y
            Daby = (Math.Pow((B2 - A2), 2));
            Dbcy = (Math.Pow((B2 - C2), 2));
            Dcay = (Math.Pow((A2 - C2), 2));

            //RESULTADO DE dAB
            TotalsumaAB = DabX + Daby;
            TotalAB = Math.Sqrt(TotalsumaAB);

            //Resultado de dbc
            TotalsumaBc = DbcX + Dbcy;
            TotalBC = Math.Sqrt(TotalsumaBc);

            //resultado de dca
            TotalsumaCa = DcaX + Dcay;
            TotalCA = Math.Sqrt(TotalsumaCa);

            //impresion de distancia
            listBox1.Items.Add("DAB");
            listBox1.Items.Add(TotalAB.ToString());
            listBox2.Items.Add("DBC");
            listBox2.Items.Add(TotalBC.ToString());
            listBox3.Items.Add("DCA");
            listBox3.Items.Add(TotalCA.ToString());

            //OPERACIONES PUNTO MEDIO
            PMABX = (A + B) / 2;
            PMBCX = (B + C) / 2;
            PMCAX = (C + A) / 2;

            PMABY = (A2 + B2) / 2;
            PMBCY = (B2 + C2) / 2;
            PMCAY = (C2 + A2) / 2;

            //impresion de punto medio
            listBox1.Items.Add("PMAB");
            listBox1.Items.Add(PMABX.ToString()+" X");
            listBox1.Items.Add(PMABY.ToString()+" Y");

            listBox2.Items.Add("PMBC");
            listBox2.Items.Add(PMBCX.ToString()+" X");
            listBox2.Items.Add(PMBCY.ToString()+" Y");

            listBox3.Items.Add("PMCA");
            listBox3.Items.Add(PMCAX.ToString()+" X");
            listBox3.Items.Add(PMCAY.ToString()+" Y");

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            //x=0
            XAT.Text = "0";
            XBT.Text = "0";
            XCT.Text = "0";
            
            //y=0
            YAT.Text = "0";
            YBT.Text = "0";
            YCT.Text = "0";

            //limpiar campos
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
