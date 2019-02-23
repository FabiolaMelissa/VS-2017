using App.UI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.Forma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if  (rbtCuadrado.Checked == true)
            {

                              
                Cuadrado forma = new Cuadrado();
                forma.ParmX= Convert.ToDouble(txtParmx.Text);
                forma.Area();
                lblArea.Text = forma.AreaFinal.ToString();
            }

            if (rbtCirculo.Checked == true)
            {
                
                Circulo forma = new Circulo();
                forma.ParmX = Convert.ToDouble(txtParmx.Text);
                forma.Area();
                lblArea.Text = forma.AreaFinal.ToString();

            }

            if (rbtTriangulo.Checked == true)
            {
                
                Triangulo forma = new Triangulo();
                forma.ParmX = Convert.ToDouble(txtParmx.Text);
                forma.ParmY = Convert.ToDouble(txtParmy.Text);
                forma.Area();
                lblArea.Text = forma.AreaFinal.ToString();

            }

            


        }
    }
}
