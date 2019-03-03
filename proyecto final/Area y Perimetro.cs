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
    public partial class Area_y_Perimetro : Form
    {
        public Area_y_Perimetro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variabels area
            double X1 = 0, X2, X3;
            double Y1, Y2, Y3;
            double Area1;
            double Area2;

            //variables perimetro
            double TotalPeri;
            double DabXP;
            double DbcXP;
            double DcaXP;
            double DabyP;
            double DbcyP;
            double DcayP;
            double TotalsumaABP, TotalsumaBcP, TotalsumaCaP;
            double TotalABP, TotalBCP, TotalCAP;
            //if checa los valores en el texbox
            if (TAXA.Text == "")
                MessageBox.Show("Falta agregar el valor X(A)", "Alerta");
            if (TAXB.Text == "")
                MessageBox.Show("Falta agregar el valor X(B)", "Alerta");
            if (TAXC.Text == "")
                MessageBox.Show("Falta agregar el valor X(C)", "Alerta");

            if (TAYA.Text == "")
                MessageBox.Show("Falta agregar el valor Y(A)", "Alerta");
            if (TAYB.Text == "")
                MessageBox.Show("Falta agregar el valor Y(B)", "Alerta");
            if (TAYC.Text == "")
                MessageBox.Show("Falta agregar el valor Y(C)", "Alerta");

            //se comprube q sea numero y no otro caracter

            try
            {
                X1 = Convert.ToDouble(TAXA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en X(A)");
                return;
            }

            //try b
            try
            {
                X2 = Convert.ToDouble(TAXB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en X(B)");
                return;
            }

            //try c
            try
            {
                X3 = Convert.ToDouble(TAXC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en X(C)");
                return;
            }


            //try AY
            try
            {
                Y1 = Convert.ToDouble(TAYA.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en Y(A)");
                return;
            }

            //try BY
            try
            {
                Y2 = Convert.ToDouble(TAYB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en Y(B)");
                return;
            }
            //TRY CY
            try
            {
                Y3 = Convert.ToDouble(TAYC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Escribe un numero en Y(C)");
                return;
            }

            //OPERACION Y IMPRESION DE AREA
            Area1 = (X1 * Y2) + (X2 * Y3) + (X3 * Y1) - (X1 * Y3) - (X2 * Y1) - (X3 * Y2) ;
            Area2 = Area1 / 2;
           
            this.TTOTAL.Text = Area2.ToString();

            //PERIMETRO...
           
            //opreacion de sacar la x
            DabXP = (Math.Pow((X2 - X1), 2));
            DbcXP = (Math.Pow((X2 - X3), 2));
            DcaXP = (Math.Pow((X1 - X3), 2));


            //operacion sacar la y
            DabyP = (Math.Pow((Y2 - Y1), 2));
            DbcyP = (Math.Pow((Y2 - Y3), 2));
            DcayP = (Math.Pow((Y1 - Y3), 2));

            //RESULTADO DE dAB
            TotalsumaABP = DabXP + DabyP;
            TotalABP = Math.Sqrt(TotalsumaABP);

            //Resultado de dbc
            TotalsumaBcP = DbcXP + DbcyP;
            TotalBCP = Math.Sqrt(TotalsumaBcP);

            //resultado de dca
            TotalsumaCaP = DcaXP + DcayP;
            TotalCAP = Math.Sqrt(TotalsumaCaP);

            TotalPeri = TotalABP + TotalBCP + TotalCAP;

            this.TEXTOTALPERI.Text = TotalPeri.ToString();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            TEXTOTALPERI.Clear();
            TTOTAL.Clear();
            TAXA.Clear();
            TAXB.Clear();
            TAXC.Clear();

            TAYA.Clear();
            TAYB.Clear();
            TAYC.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
