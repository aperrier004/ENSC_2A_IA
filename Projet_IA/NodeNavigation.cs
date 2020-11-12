using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_IA
{
    class NodeNavigation : GenericNode
    {
        int CoordX;
        int CoordY;
        public NodeNavigation(int newcoordX, int newCoordY) : base()
        {
            CoordX = newcoordX;
            CoordY = newCoordY;
        }

        // TODO
        // Fonction qui permet de vérifier si le noeud est égale au noeud donné
        public override bool IsEqual(GenericNode N2)
        {
            NodeNavigation NV = (NodeNavigation)(N2);
            return (NV.CoordX == CoordX && NV.CoordY == CoordY);
        }
        

        // TODO
        // Fonction qui permet d'obtenir le coût d'une arrête
        public override double GetArcCost(GenericNode N2)
        {
            NodeNavigation NT = (NodeNavigation)N2;
            return time_estimation(CoordX, CoordY, NT.CoordX, NT.CoordY);
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

        public static double get_wind_speed(double x, double y)
        {
            if (Form1.typeVent == 'a')
                return 50;
            else if (Form1.typeVent == 'b')
                if (y > 150)
                    return 50;
                else return 20;
            else if (y > 150)
                return 50;
            else return 20;
        }
        public static double get_wind_direction(double x, double y)
        {
            if (Form1.typeVent == 'a')
                return 30;
            else if (Form1.typeVent == 'b')
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else return 65;
        }

        // TODO : Les modifier avec xf et yf
        // Fonction qui définit l'état final d(à vérifier)e la navigation
        public override bool EndState()
        {
            return (this.CoordX == Form1.xf && this.CoordY == Form1.yf);
        }

        // TODO
        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();
            
            // succ à droite
            if(verifCoord(this.CoordX + 1, this.CoordY))
            {
                lsucc.Add(new NodeNavigation(this.CoordX + 1, this.CoordY));
            }
            // succ à gauche
            if (verifCoord(this.CoordX - 1, this.CoordY))
            {
                lsucc.Add(new NodeNavigation(this.CoordX - 1, this.CoordY));
            }
            // succ en haut
            if (verifCoord(this.CoordX, this.CoordY + 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX, this.CoordY + 1));
            }
            // succ en bas
            if (verifCoord(this.CoordX, this.CoordY - 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX, this.CoordY - 1));
            }
            // succ en haut à droite
            if (verifCoord(this.CoordX + 1, this.CoordY + 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX +1, this.CoordY + 1));
            }
            // succ en haut à gauche
            if (verifCoord(this.CoordX - 1, this.CoordY + 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX - 1, this.CoordY + 1));
            }
            // succ en bas à droite
            if (verifCoord(this.CoordX + 1, this.CoordY - 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX + 1, this.CoordY - 1));
            }
            // succ en bas à gauche
            if (verifCoord(this.CoordX - 1, this.CoordY - 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX - 1, this.CoordY - 1));
            }


            return lsucc;
        }

        // Fonction qui permet de savoir si les coordonées sont dans la zone naviguable
        public bool verifCoord(int CoordX, int CoordY)
        {
            bool cond = false;

            if (CoordX > 0 && CoordY > 0 && CoordX < Form1.nbPixels && CoordY < Form1.nbPixels)
            {
                cond = true;
            }

            return cond;
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

        // A SUPPRIMER ?
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
        /*
        public override string ToString()
        {
            return Coord;
        }*/

    }
}
