using System;

namespace Les_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entrer le nom du produit");
                string nomProduit = Console.ReadLine();
            Console.WriteLine("entrer le prix du produit");
                double prixHorsTva = Convert.ToDouble(Console.ReadLine());
            int tva = 19;
            double dTva = Convert.ToDouble(tva);
            double prixTtc = prixHorsTva + prixHorsTva * dTva / 100;
            string result = " le prix TTc du produit " + nomProduit + " est " + prixTtc;
            Console.WriteLine(result);

        }
    }
}
