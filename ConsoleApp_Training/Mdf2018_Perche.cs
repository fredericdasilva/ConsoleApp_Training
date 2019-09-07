using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp_Training
{
    public static class Mdf2018_Perche
    {
        class Essai
        {
            public Essai(string Athlete, double Hauteur, string Resultat)
            {
                this.athlete = Athlete;
                this.hauteur = Hauteur;
                this.resultat = Resultat;
            }
            public string athlete { get; set; }
            public double hauteur { get; set; }
            public string resultat { get; set; }
           
        }
      

        public static void MainMdf2018(string[] args)
        {
            string line;

            int i = 0;
            int nbEssais = -1;
            string[] subList;
            List<Essai> listEssai = new List<Essai>();
            Essai essai;

            while ((line = Console.ReadLine()) != null)
            //while (i < args.Length)
            {
                //line = args[i];
                //
                // Lisez les données et effectuez votre traitement */
                //
                if (i == 0)
                {
                    nbEssais = Convert.ToInt32(line);
                }
                else if (i > 0)
                {
                    //list.Add(line);
                    subList = line.Split(" ");
                    essai = new Essai(subList[0], Convert.ToDouble(subList[1].Replace(".", ",")), subList[2]);
                    listEssai.Add(essai);
                }

                i++;
            }

            string result = "KO";

            //Chercher la hauteur plus haute réussie
            double maxHauteur = (from e in listEssai
                          where e.resultat == "S"
                          select e).Max(x=>x.hauteur);

            //Chercher les athlètes ayant franchi l'hauteur la plus haute et trier leur nb d'essais
            var res = (from e in listEssai
                       where e.hauteur == maxHauteur
                       group e by e.athlete into grp
                       select new { key = grp.Key, cnt = grp.Count() }).OrderBy(x=>x.cnt).ToList(); ;

            if (res.Count() == 1)
                result = res[0].key;
            else if (res[0].cnt < res[1].cnt)
                result = res[0].key;


            /* Le nom du vainqueur du concours ou la chaine KO s'il y a égalité parfaite entre plusieurs vainqueurs potentiels. */
            Console.WriteLine(result);


        }

       

    }
}
