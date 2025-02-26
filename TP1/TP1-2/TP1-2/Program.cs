namespace TP12;
using System;

class Program
{
    static void Main()
    {
        Projet projet = new Projet("P001", "Gestion de la consommation de café", 4, 10, 50);
        
        projet.AjouterProgrammeur(new Programmeur(1, "Souidak", "Firdaous", 205));
        projet.AjouterProgrammeur(new Programmeur(2, "Soulhi", "Malak", 566));
        
        projet.AfficherProgrammeurs();
        
        projet.AjouterConsommationCafe(1, 1, 5);
        projet.AjouterConsommationCafe(1, 2, 8);
        projet.AjouterConsommationCafe(2, 1, 7);
        projet.AjouterConsommationCafe(2, 2, 9);
        
        projet.AfficherTotalCafeParSemaine(1);
        projet.AfficherTotalCafeParSemaine(2);
    }
}

