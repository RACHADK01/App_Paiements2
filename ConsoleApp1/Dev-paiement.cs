using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dev_paiement
    {
        //Initialisation des propriétés
        public double Montant { get; set; }
        public string Description { get; set; }
        //Initialisation du constructeur 
        public Dev_paiement(double montant, string description) 
        {
            Montant = montant;
            Description = description;
        }
        //Initialisation de la méthode 
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Montant:{Montant},Description:{Description}");
        }

    }
}
