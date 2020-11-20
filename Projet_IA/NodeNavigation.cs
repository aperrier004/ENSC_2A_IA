/*
 * PROJET IA - 2A ENSC
 * Auteurs : Juliette GADEAU et Alban PERRIER
 * Fichier : NodeNavigation.cs
 * But : Classe héritant de GenericNode, permettant de gérer les noeuds de notre solution
 */

using System;
using System.Collections.Generic;

namespace Projet_IA
{
    class NodeNavigation : GenericNode
    {
        // public pour que ça puisse être utilisé par tracerSegment dans Form1
        public int CoordX; 
        public int CoordY;
        // Constructeur
        public NodeNavigation(int newcoordX, int newCoordY) : base()
        {
            CoordX = newcoordX;
            CoordY = newCoordY;
        }

        // Entrée : un objet GenericNode
        // Sortie : un booléen
        // Desc : renvoie True si l’égalité entre deux objets de type GenericNode est vérifiée
        public override bool IsEqual(GenericNode N2)
        {
            NodeNavigation NV = (NodeNavigation)(N2);
            return (NV.CoordX == CoordX && NV.CoordY == CoordY);
        }


        // Entrée : un objet GenericNode
        // Sortie : un double
        // Desc : appelle la fonction time_estimation() permettant de renvoyer un double correspondant 
        //        au coût d’un chemin et donc le temps mis par le bateau pour aller d’un point A à un point B
        public override double GetArcCost(GenericNode N2)
        {
            // On caste le noeud pour obtenir ses coordonnées
            NodeNavigation NT = (NodeNavigation)N2;
            return time_estimation(CoordX, CoordY, NT.CoordX, NT.CoordY);
        }

        // Entrée : les coordonnées de deux points
        // Sortie : un double représentant le temps
        // Desc : Permet d'obtenir le temps de navigation entre deux points 
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
            return distance / boatspeed;
        }
        // Entrée : les coordonnées d'un point
        // Sortie : un réel
        // Desc : permet de donner la vitesse du vent selon le type de vent
        public static double get_wind_speed(double x, double y)
        {
            if (MainForm.typeVent == 'a')
                return 50;
            else if (MainForm.typeVent == 'b')
                if (y > 150)
                    return 50;
                else return 20;
            else if (y > 150)
                return 50;
            else return 20;
        }
        // Entrée : les coordonnées d'un point
        // Sortie : un réel
        // Desc : Permet de donner la direction du vent selon le type de vent
        public static double get_wind_direction(double x, double y)
        {
            if (MainForm.typeVent == 'a')
                return 30;
            else if (MainForm.typeVent == 'b')
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else return 65;
        }

        // Entrée : /
        // Sortie : un booléen
        // Desc : renvoie True si l’objet de type GenericNode étudié correspond au 
        //       point d’arrivée du bateau saisi par l’utilisateur
        public override bool EndState()
        {
            return (this.CoordX == MainForm.xf && this.CoordY == MainForm.yf);
        }

        // Entree : /
        // Sortie : Une liste d'objet de type GenericNode
        // Desc :  vérifie les coordonnées de tous les nœuds voisins et s’ils sont possibles (c’est-à-dire pas en 
        //          dehors de l’image ou pas déjà fermé/parcouru) les ajoute à une liste de nœuds qui sera renvoyée
        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();
            
            // successeur à droite
            if(VerifCoord(this.CoordX + 1, this.CoordY))
            {
                lsucc.Add(new NodeNavigation(this.CoordX + 1, this.CoordY));
            }
            // successeur à gauche
            if (VerifCoord(this.CoordX - 1, this.CoordY))
            {
                lsucc.Add(new NodeNavigation(this.CoordX - 1, this.CoordY));
            }
            // successeur en haut
            if (VerifCoord(this.CoordX, this.CoordY + 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX, this.CoordY + 1));
            }
            // successeur en bas
            if (VerifCoord(this.CoordX, this.CoordY - 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX, this.CoordY - 1));
            }
            // successeur en haut à droite
            if (VerifCoord(this.CoordX + 1, this.CoordY + 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX +1, this.CoordY + 1));
            }
            // successeur en haut à gauche
            if (VerifCoord(this.CoordX - 1, this.CoordY + 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX - 1, this.CoordY + 1));
            }
            // successeur en bas à droite
            if (VerifCoord(this.CoordX + 1, this.CoordY - 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX + 1, this.CoordY - 1));
            }
            // successeur en bas à gauche
            if (VerifCoord(this.CoordX - 1, this.CoordY - 1))
            {
                lsucc.Add(new NodeNavigation(this.CoordX - 1, this.CoordY - 1));
            }
            return lsucc;
        }

        // Entrée : les coordonnées d'un point
        // Sortie : un booléen
        // Desc : renvoie True si les coordonnées étudiées sont contenues dans la zone navigable
        public bool VerifCoord(int CoordX, int CoordY)
        {
            bool cond = false;

            // Si les coordonnées de ce point font parties de la fenêtre de pixels de l'image
            if (CoordX > 0 && CoordY > 0 && CoordX < MainForm.nbPixels && CoordY < MainForm.nbPixels)
            {
                cond = true;
            }

            return cond;
        }

        // Entrée : /
        // Sortie : un double
        // Desc : Fonction heuristique qui calcule la distance entre le noeud étudié et le point d'arrivée
        //Heuristique mauvaise, la on fait la distance
        //public override double CalculeHCost()
        //{
        //    double distance = 0;
        //    distance = Math.Sqrt(Math.Pow((double)(this.CoordX) - (double)(MainForm.xf), 2) + Math.Pow((double)(this.CoordY - MainForm.yf), 2));

        //    return (distance);
        //}

        //heurisitique avec le temps
        //public override double CalculeHCost()
        //{
        //    //double temps = 0;
        //    //temps = time_estimation(CoordX, CoordY, MainForm.xf, MainForm.yf);
        //    //return (temps);
        //    //distance = Math.Sqrt(Math.Pow((double)(this.CoordX) - (double)(MainForm.xf), 2) + Math.Pow((double)(this.CoordY - MainForm.yf), 2));
        //    return 0;

        //}

        //public override double CalculeHCost()
        //{
        //    double x1 = this.CoordX;
        //    double y1 = this.CoordY;
        //    double x2 = MainForm.xf;
        //    double y2 = MainForm.yf;
        //    double dTotale = Math.Sqrt(Math.Pow(MainForm.xf - this.CoordX, 2) + Math.Pow(MainForm.yf - this.CoordY, 2));
        //    double nbTroncon = Math.Floor(dTotale / 10);
        //    double angle = Math.Atan2(MainForm.yf - this.CoordY, MainForm.xf - this.CoordX);
        //    double pasX = Math.Cos(angle) * 10;
        //    double pasY = Math.Sin(angle) * 10;
        //    double coutTotal = 0;

        //    if (MainForm.nbPixels == 0)
        //    {
        //        coutTotal = time_estimation(this.CoordX, this.CoordY, MainForm.xf, MainForm.yf);
        //    }
        //    else
        //    {
        //        double tempX = this.CoordX;
        //        double tempY = this.CoordY;
        //        for (int i = 0; i < nbTroncon; i++) // calcul de la somme des coûts pour tous les tronçons
        //        {
        //            coutTotal += time_estimation(tempX, tempY, tempX + pasX, tempY + pasY);

        //        }

        //        // calcul du coût pour dernier tronçons vu qu'on a arrondi en bas leur nombre
        //        coutTotal += time_estimation(tempX, tempY, MainForm.xf, MainForm.yf);
        //    }

        //    return coutTotal;
        //}

        //heuristique avec le temps d'après la distance et la vitesse maximale
        public override double CalculeHCost()
        {
            double temps = 0;
            temps = (Math.Sqrt(Math.Pow((double)(this.CoordX) - (double)(MainForm.xf), 2) + Math.Pow((double)(this.CoordY - MainForm.yf), 2))) / 45;

            return temps;
        }
    }
}
