using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Training
{
    public static class Mdf2018
    {
        public static void MainMdf2018(string[] args)
        {
            string line;

            int i = 0;
            int nbJours = -1;
            double soldePremierJour = 0;
            List<int> list = new List<int>();

            while ((line = Console.ReadLine()) != null)
            //while (i < args.Length)
            {
                //line = args[i];
                //
                // Lisez les données et effectuez votre traitement */
                //
                if (i == 0)
                {
                    nbJours = Convert.ToInt32(line);
                }
                else if (i == 1)
                {
                    soldePremierJour = Convert.ToInt32(line);
                }
                else if (i < (nbJours + 2))
                {
                    list.Add(Convert.ToInt32(line));
                }
                else
                {
                    Console.Error.WriteLine("Too many lines : " + line);
                }

                i++;
            }

            //Gestion des cas d'erreur
            if (nbJours < 1 || nbJours > 365)
                Console.WriteLine(0);

            if (soldePremierJour < 0 || soldePremierJour > 500)
                Console.WriteLine(0);

            // Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
            /* Un entier correspondant à la différence arrondie à l'entier supérieur entre l'ancienne méthode de calcul des intérêts débiteurs et la nouvelle méthode.
             * Pour éviter les soucis liés aux arrondis, une tolérance d'un euro en plus ou en moins sera acceptée. */
            double interet1 = TotalMontantMethod1(soldePremierJour, list);
            double interet2 = TotalMontantMethod2(soldePremierJour, list);
            double diff = Math.Round(Math.Abs(interet1 - interet2));
            Console.WriteLine(diff);
           

        }

        /* Dans le passé, si le solde d'un client était négatif pendant plus 2 de jours consécutifs, on commençait à calculer un intérêt débiteur. 
         * Cet intérêt était égal à 10% du solde du compte à partir du 3ème jour et tant que le compte demeurait négatif. */
        static double TotalMontantMethod1(double soldePremierJour, List<int> variations)
        {
            int nbJoursConsecutif = 0;
            double SumInteretDebiteur = 0.0;
            double InteretDebiteur = 0.0;
            double solde = soldePremierJour;

            foreach (int variation in variations)
            {
                solde += variation;

                if (solde < 0)
                {
                    nbJoursConsecutif++;
                }
                else
                {
                    nbJoursConsecutif = 0;
                }

                if (nbJoursConsecutif >= 3)
                {
                    InteretDebiteur = Math.Abs(0.1 * solde);
                    SumInteretDebiteur += InteretDebiteur;
                }

            }

            return SumInteretDebiteur;
        }

        /* Désormais, si un client a un solde négatif, dès le premier jour son intérêt débiteur sera égal à 20% du solde,
         * idem pour les jours suivants, et si le solde reste négatif plus de 3 jours consécutifs, 
         * l'intérêt débiteur pour chaque jour à partir du 4ème sera de 30% du solde tant que le solde demeure négatif.  */
        static double TotalMontantMethod2(double soldePremierJour, List<int> variations)
        {
            int nbJoursConsecutif = 0;
            double SumInteretDebiteur = 0.0;
            double InteretDebiteur = 0.0;
            double solde = soldePremierJour;

            foreach (int variation in variations)
            {
                solde += variation;

                if (solde < 0)
                {
                    nbJoursConsecutif++;
                }
                else
                {
                    nbJoursConsecutif = 0;
                }

                if (nbJoursConsecutif >= 4)
                {
                    InteretDebiteur = Math.Abs(0.3 * solde);
                    SumInteretDebiteur += InteretDebiteur;
                }
                else if (nbJoursConsecutif >= 1)
                {
                    InteretDebiteur = Math.Abs(0.2 * solde);
                    SumInteretDebiteur += InteretDebiteur;
                }
               

            }

            return SumInteretDebiteur;
        }

    }
}
