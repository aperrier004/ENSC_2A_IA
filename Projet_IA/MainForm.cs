/*
 * PROJET IA - 2A ENSC
 * Auteurs : Juliette GADEAU et Alban PERRIER
 * Fichier : MainForm.cs
 * But : Classe permettant de gérer le Form et ses évenements
 */
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
    public partial class MainForm : Form
    {
        static public int nbPixels = 300;
        static public int x0 = -1;
        static public int xf = -1;
        static public int y0 = -1;
        static public int yf = -1;
        static public char typeVent = ' ';
        static public int cptClick = 0;
        static public int unitsTextBox;


        public MainForm()
        {
            InitializeComponent();
        }


        private void button_start_Click(object sender, EventArgs e)
        {
            // Si les coordonées de nos points ont été paramétrés ainsi que le type de vent
            if (x0 >= 0 && y0 >= 0 && xf >= 0 && yf >= 0 && (typeVent != ' '))
            {

                // On affiche un feedback pour le vent 
                label_ConsigneVent.Text = "Vent sélectionné : " + typeVent;

                // Permet de ne plus pouvoir cliquer sur l'image
                pictureBox_fondMarin.Enabled = false;
                label_consignePoint.Text = "Les points ont été paramétrés avec x0: " + x0 + " y0: " + y0 + " xf: " + xf + " yf: " + yf;

                // On initialise l'arbre
                SearchTree g = new SearchTree();
                // On crée le noeud initial avec les coordonées intiales
                NodeNavigation N0 = new NodeNavigation(x0,y0);
                // On lance l'algorithme A*
                List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);

                // Si une solution n'est pas trouvée
                if (Lres.Count == 0)
                {
                    label_feedback.Text = "Pas de solution";
                }
                // Si une solution a été trouvée
                else
                {
                    label_feedback.Text = "Une solution a été trouvée";

                    double tpsTotal = 0;
                    for (int i = 0; i < Lres.Count-1; i++)
                    {
                        NodeNavigation N1 = (NodeNavigation)Lres[i];
                        NodeNavigation N2 = (NodeNavigation)Lres[i+1];

                        // On appelle la fonction tracerSegment pour tracer le chemin entre les deux derniers noeuds
                        tracerSegment(N1.CoordX, N1.CoordY, N2.CoordX, N2.CoordY);

                        // Estimation du temps total
                        tpsTotal += Lres[i].GetArcCost(Lres[i + 1]);
                    }
                    // On arrondit le temps total
                    double resTps = Math.Round(tpsTotal,2);
                    // On affiche le temps total dans le form
                    textBox_tpsTotalNav.Text = resTps.ToString();
                    // On affiche le nombre de noeuds dans le form
                    textBox_nbNoeuds.Text = Lres.Count.ToString();
                    // On affiche la somme des noeuds dans le form
                    textBox_sommeNoeudsOF.Text = (g.CountInOpenList() + g.CountInClosedList()).ToString();
                }

                button_restart.Visible = true;
                button_start.Enabled = false;

            } else
            {
                label_feedback.Text = "Vous n'avez pas terminé le paramétrage de l'application";
            }
        }

        // Entrée : des int correspondants aux coordonées de deux points
        // Sortie : /
        // Desc : Tracer une ligne entre deux points et dessiner un cercle pour le point de départ et d'arrivée
        public void tracerSegment(int x1, int y1, int x2, int y2)
        {
            // soient x1, y1, x2, y2 des double utilisés pour définir les 2 extrémités d’un segment.

            // Objets pour les couleurs
            Pen penwhite = new Pen(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            Graphics g = pictureBox_fondMarin.CreateGraphics();
            // On dessine un segment entre les deux points
            g.DrawLine(penwhite, x1, y1, x2, y2);

            // On dessin un cercle plein sur les deux points
            g.FillEllipse(redBrush, x0, y0, 5, 5);
            g.FillEllipse(redBrush, xf, yf, 5, 5);
        }

        private void textBox_x0_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_x0.Text, out unitsTextBox))
            {
                x0 = int.Parse(textBox_x0.Text);
            }
            else
            {
                label_feedback.Text = "Attention à votre valeur de x0";
            }
            label_consignePoint.Text = "";
        }

        private void pictureBox_fondMarin_MouseClick(object sender, MouseEventArgs e)
        {
            // Si on a pas déjà rentrée des coordonées avant dans les textBox
            if(label_consignePoint.Text != "")
            {
                // On enlève les options de rentrer à la main les coordonées
                label_consigneCoord.Text = "";
                textBox_x0.Enabled = false;
                textBox_y0.Enabled = false;
                textBox_xf.Enabled = false;
                textBox_yf.Enabled = false;
                // S'il s'agit du premier clic sur l'image
                if (cptClick == 0)
                {
                    // Point de départ
                    x0 = e.X;
                    y0 = e.Y;

                    label_consignePoint.Text = "Cliquez de nouveau sur l'image pour paramétrer le point d'arrivée";

                    cptClick++;

                }
                // S'il s'agit du deuxième clic sur l'image
                else if (cptClick == 1)
                {
                    // Point d'arrivée
                    xf = e.X;
                    yf = e.Y;

                    // Permet de ne plus pouvoir cliquer sur l'image
                    pictureBox_fondMarin.Enabled = false;
                    label_consignePoint.Text = "Les points ont été paramétrés avec x0: " + x0 + " y0: " + y0 + " xf: " + xf + " yf: " + yf;

                }
            }
            
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

        private void textBox_y0_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_y0.Text, out unitsTextBox))
            {
                y0 = int.Parse(textBox_y0.Text);
            }
            else
            {
                label_feedback.Text = "Attention à votre valeur de y0";
            }
        }

        private void textBox_xf_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_xf.Text, out unitsTextBox))
            {
                xf = int.Parse(textBox_xf.Text);
            }
            else
            {
                label_feedback.Text = "Attention à votre valeur de xf";
            }
                
        }

        private void textBox_yf_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_yf.Text, out unitsTextBox))
            {
                yf = int.Parse(textBox_yf.Text);
            }
            else
            {
                label_feedback.Text = "Attention à votre valeur de yf";
            }
               
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
