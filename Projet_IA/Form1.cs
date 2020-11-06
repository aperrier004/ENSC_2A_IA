using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_IA
{
    public partial class Form1 : Form
    {
        static public double[,] matrice;
        static public int nbPixels = 300;
        static public int x0;
        static public int xf;


        public Form1()
        {
            InitializeComponent();
        }

        public void initMatrice()
        {
            //Initilisation d'une matrice représentant l'océan à parcourir
            //Elle contient le départ x0,y0 et l'arrivée xf,yf
            matrice = new double[nbPixels, nbPixels];
            for (int i = 0; i < nbPixels; i++)
                for (int j = 0; j < nbPixels; j++)
                {
                    matrice[i, j] = -1;

                }
                    


          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            
        }

        public void tracerSegment(double x1, double x2, double y1, double y2)
        {
            // soient x1, y1, x2, y2 des double utilisés pour définir les 2 extrémités d’un segment.
            Pen penwhite = new Pen(Color.White); // d’autres couleurs sont disponibles
            Graphics g = pictureBox_fondMarin.CreateGraphics();
            g.DrawLine(penwhite, new Point((int)x1, pictureBox_fondMarin.Height - (int)y1),
            new Point((int)x2, pictureBox_fondMarin.Height - (int)y2));
        }

        


        
        // Vérifier si c'est le bon évenement 
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if(radioButton_a.Checked)
            {
                NodeNavigation.cas = 'a';
            }
            else if (radioButton_b.Checked)
            {
                NodeNavigation.cas = 'b';
            }
            else if (radioButton_c.Checked)
            {
                NodeNavigation.cas = 'c';
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_x0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
