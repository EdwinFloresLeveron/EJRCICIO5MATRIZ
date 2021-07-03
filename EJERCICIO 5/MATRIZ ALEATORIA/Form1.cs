using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATRIZ_ALEATORIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_crearmatriz_Click(object sender, EventArgs e)
        {
            
            int FILA = Convert.ToInt32(txt_fila.Text);
            int COLUMNA = Convert.ToInt32(txt_columna.Text);

            int[,] matrizale = new int[FILA, COLUMNA];
            Random aletorio = new Random();

            for (int fila = 0; fila < matrizale.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizale.GetLength(0); columna++)
                {
                    matrizale[fila, columna] = aletorio.Next(100);

                }
            }

            for (int fila = 0; fila < matrizale.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizale.GetLength(0); columna++)
                {
                    MessageBox.Show("la posicion es:"+fila+","+columna+"="+matrizale[fila, columna]);
                }
            }

        }

        private void btn_llenarmatriz_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }
    }
}          