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
        static public int[,] matrice;
        static public int nbPixels = 300;
        static public int x0 = -1;
        static public int xf = -1;
        static public int y0 = -1;
        static public int yf = -1;
        static public char typeVent = ' ';
        static public int cptClick = 0;


        public Form1()
        {
            InitializeComponent();
            
            
        }


        public void initMatrice()
        {
            //Initilisation d'une matrice représentant l'océan à parcourir
            //Elle contient le départ x0,y0 et l'arrivée xf,yf
            matrice = new int[nbPixels, nbPixels];
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
            if (x0 >= 0 && y0 >= 0 && xf >= 0 && yf >= 0 && (typeVent != ' '))
            {
                label_ConsigneVent.Text = "Vent sélectionné : " + typeVent;

                SearchTree g = new SearchTree();
                NodeNavigation N0 = new NodeNavigation(x0,y0);
                List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);

                if (Lres.Count == 0)
                {
                    label_feedback.Text = "Pas de solution";
                }
                else
                {
                    label_feedback.Text = "Une solution a été trouvée";

                    double tpsTotal = 0;
                    //foreach (GenericNode N in Lres)
                    for (int i = 0; i < Lres.Count-1; i++)
                    {
                        NodeNavigation N1 = (NodeNavigation)Lres[i];
                        NodeNavigation N2 = (NodeNavigation)Lres[i+1];
                        tracerSegment(N1.CoordX, N1.CoordY, N2.CoordX, N2.CoordY);
                        //listBox1.Items.Add(N); pourquoi on avait écrit ça déjà ?

                        //Esimation du temps total
                        tpsTotal += Lres[i].GetArcCost(Lres[i + 1]);
                    }
                    textBox_tpsTotalNav.Text = tpsTotal.ToString();
                    textBox_nbNoeuds.Text = Lres.Count.ToString();
                    textBox_sommeNoeudsOF.Text = (g.CountInOpenList() + g.CountInClosedList()).ToString();
                }

            } else
            {
                label_feedback.Text = "Vous n'avez pas terminé le paramétrage de l'application";
            }
        }

        public void tracerSegment(double x1, double x2, double y1, double y2)
        {
            // soient x1, y1, x2, y2 des double utilisés pour définir les 2 extrémités d’un segment.
            Pen penwhite = new Pen(Color.White); // d’autres couleurs sont disponibles
            Graphics g = pictureBox_fondMarin.CreateGraphics();

            //Code du prof :
            //g.DrawLine(penwhite, new Point((int)x1, pictureBox_fondMarin.Height - (int)y1),
            //new Point((int)x2, pictureBox_fondMarin.Height - (int)y2));

            //Plus logique que ce soit ça :
            g.DrawLine(penwhite, new Point((int)x1, (int)y1), new Point((int)x2, (int)y2));
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_x0_TextChanged(object sender, EventArgs e)
        {
            x0 = int.Parse(textBox_x0.Text);
        }

        private void pictureBox_fondMarin_MouseClick(object sender, MouseEventArgs e)
        {
            if(cptClick == 0)
            {
                // Point de départ
                x0 = e.X;
                y0 = e.Y;

                label_consignePoint.Text = "Cliquez de nouveau sur l'image pour paramétrer le point d'arrivée";
                cptClick++;

            }
            else if(cptClick == 1)
            {
                // Point d'arrivée
                xf = e.X;
                yf = e.Y;

                pictureBox_fondMarin.Enabled = false;
                label_consignePoint.Text = "Les points ont été paramétrés avec x0: " + x0 + " y0: " + y0 + " xf: " + xf + " yf: " + yf;

            }
        }

        private void pictureBox_fondMarin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox_fondMarin_DoubleClick(object sender, EventArgs e)
        {

        }

        private void radioButton_a_CheckedChanged(object sender, EventArgs e)
        {
            typeVent = 'a';
        }

        private void radioButton_b_CheckedChanged(object sender, EventArgs e)
        {
            typeVent = 'b';
        }

        private void radioButton_c_CheckedChanged(object sender, EventArgs e)
        {
            typeVent = 'c';
        }

        private void radioButton_a_Click(object sender, EventArgs e)
        {
            typeVent = 'a';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void textBox_x0_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox_y0_TextChanged(object sender, EventArgs e)
        {
            y0 = int.Parse(textBox_y0.Text);
        }

        private void textBox_xf_TextChanged(object sender, EventArgs e)
        {
            xf = int.Parse(textBox_xf.Text);
        }

        private void textBox_yf_TextChanged(object sender, EventArgs e)
        {
            yf = int.Parse(textBox_yf.Text);
        }
    }
}
