using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_IA
{
    class NodeNavigation : GenericNode
    {
        int[] Coord;
        public NodeNavigation(int[] newcoord) : base()
        {
            Coord = newcoord;
        }

        // TODO
        // Fonction qui permet de vérifier si le noeud est égale au noeud donné
        public override bool IsEqual(GenericNode N2)
        {
            NodeNavigation NV = (NodeNavigation)(N2);
            return (NV.Coord == Coord);
        }
        

        // TODO
        // Fonction qui permet d'obtenir le coût d'une arrête
        public override double GetArcCost(GenericNode N2)
        {
            NodeNavigation NT = (NodeNavigation)N2;
            return time_estimation((int)this.Coord[0], (int)this.Coord[1], NT.Coord[0], NT.Coord[1]);
        }

        // Soit on crée un classe outil / fonction et on les déclare sous forme static 
        public static double time_estimation(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;
            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180) alpha = 360 - alpha;
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }
            else
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

        public static char cas = 'a'; // à modifier en ‘b’ ou ‘c’ selon le choix de l’utilisateur
        public static double get_wind_speed(double x, double y)
        {
            if (cas == 'a')
                return 50;
            else if (cas == 'b')
                if (y > 150)
                    return 50;
                else return 20;
            else if (y > 150)
                return 50;
            else return 20;
        }
        public static double get_wind_direction(double x, double y)
        {
            if (cas == 'a')
                return 30;
            else if (cas == 'b')
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else return 65;
        }

        // TODO : Les modifier avec xf et yf
        // Permet de définir des coordonées finales par défaut
        public static int[] coordF = new int[] { 30, 30 };
        // Fonction qui définit l'état final d(à vérifier)e la navigation
        public override bool EndState()
        {
            return (this.Coord == coordF);
        }

        // TODO
        public override List<GenericNode> GetListSucc()
        {
            // On reconstruit le carré 3x3 à partir du nom et on mémorise la position du ?
            int posx = -1; int posy = -1;
            char[,] tab = new char[3, 3];
            for (int j = 0; j <= 2; j++)
                for (int i = 0; i <= 2; i++)
                {
                    tab[i, j] = Name[j * 3 + i];

                    if (tab[i, j] == '?')
                    {
                        posx = i;
                        posy = j;
                    }
                }

            List<GenericNode> lsucc = new List<GenericNode>();
            if (posx > 0)
            {
                // Successeur à gauche
                // recopie du tableau
                char[,] tab2 = new char[3, 3];
                for (int j = 0; j <= 2; j++)
                    for (int i = 0; i <= 2; i++)
                    {
                        tab2[i, j] = tab[i, j];
                    }
                // MAJ de la position du ?
                tab2[posx, posy] = tab2[posx - 1, posy];
                tab2[posx - 1, posy] = '?';
                // Ajout à listsucc
                lsucc.Add(new NodeNavigation(GetStringFromTab(tab2)));
            }
            if (posx < 2)
            {
                // Successeur à droite
                // recopie du tableau
                char[,] tab2 = new char[3, 3];
                for (int j = 0; j <= 2; j++)
                    for (int i = 0; i <= 2; i++)
                    {
                        tab2[i, j] = tab[i, j];
                    }
                // MAJ de la position du ?
                tab2[posx, posy] = tab2[posx + 1, posy];
                tab2[posx + 1, posy] = '?';
                // Ajout à listsucc
                lsucc.Add(new NodeNavigation(GetStringFromTab(tab2)));
            }

            if (posy > 0)
            {
                // Successeur en haut
                // recopie du tableau
                char[,] tab2 = new char[3, 3];
                for (int j = 0; j <= 2; j++)
                    for (int i = 0; i <= 2; i++)
                    {
                        tab2[i, j] = tab[i, j];
                    }
                // MAJ de la position du ?
                tab2[posx, posy] = tab2[posx, posy - 1];
                tab2[posx, posy - 1] = '?';
                // Ajout à listsucc
                lsucc.Add(new NodeNavigation(GetStringFromTab(tab2)));
            }
            if (posy < 2)
            {
                // Successeur en bas
                // recopie du tableau
                char[,] tab2 = new char[3, 3];
                for (int j = 0; j <= 2; j++)
                    for (int i = 0; i <= 2; i++)
                    {
                        tab2[i, j] = tab[i, j];
                    }
                // MAJ de la position du ?
                tab2[posx, posy] = tab2[posx, posy + 1];
                tab2[posx, posy + 1] = '?';
                // Ajout à listsucc
                lsucc.Add(new NodeNavigation(GetStringFromTab(tab2)));
            }

            return lsucc;
        }

        // MAYBE TODO
        public override double CalculeHCost()
        {
            // on compte les mal placés 
            /*  int nb=8;
              for (int i = 0; i < 8; i++)
                  if (Name[i] == Convert.ToChar(i + 49)) // En code ASCII 1 est le 49ème caractère
                      nb--;
              return(nb);
             */
            return (0);
        }

        private string GetStringFromTab(char[,] tab)
        {
            string newname = "";
            for (int j = 0; j <= 2; j++)
                for (int i = 0; i <= 2; i++)
                {
                    newname = newname + tab[i, j];
                }
            return newname;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
