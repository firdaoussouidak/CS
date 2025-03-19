namespace TP3;
using System;

class Program
{
    static void Main()
    {
        // Création de la gestion des ressources humaines
        RessourcesHumaines rh = new RessourcesHumaines();

        // Création du Directeur (Singleton)
        Directeur directeur = Directeur.GetInstance(1, "El Idrissi", "Ali", "Bureau 101", 20000, 5000);
        rh.AjouterPersonnel(directeur);

        // Création d'un enseignant
        Enseignant enseignant1 = new Enseignant(2, "Bennani", "Omar", "Bureau 202", 12000, 2000, Grade.PH, 10);
        rh.AjouterPersonnel(enseignant1);

        // Création de groupes et d'étudiants
        Groupe groupe1 = new Groupe("G1");
        groupe1.AjouterEtudiant(new Etudiant(101, "Ahmed", "Karim", 2, 14.5));
        groupe1.AjouterEtudiant(new Etudiant(102, "Said", "Mohammed", 2, 12.3));

        Groupe groupe2 = new Groupe("G2");
        groupe2.AjouterEtudiant(new Etudiant(103, "Fatima", "Zahra", 3, 15.7));

        // Affectation des groupes à l'enseignant
        enseignant1.AjouterGroupe(groupe1);
        enseignant1.AjouterGroupe(groupe2);

        // Affichage des enseignants et leurs groupes
        rh.Afficher_Enseignants();

        // Recherche d'un enseignant
        int position = rh.Rechercher_Ens(2);
        Console.WriteLine(position != -1 ? $"Enseignant trouvé à l'index {position}" : "Enseignant introuvable");

        // Test du singleton
        Directeur directeur2 = Directeur.GetInstance(3, "Faux", "Directeur", "Bureau 103", 25000, 6000);
    }
}