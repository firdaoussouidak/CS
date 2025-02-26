namespace EX1;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Création de quelques employés
        Employee emp1 = new Employee("Firdaous", 7000, "Développeuse", new DateTime(2022, 5, 1));
        Employee emp2 = new Employee("Malak", 9600, "Chef de projet", new DateTime(2018, 3, 12));
        Employee emp3 = new Employee("Houssame", 8000, "Designer", new DateTime(2022, 1, 19));

        // Création de l'instance de GestionEmployes et ajout des employés
        GestionEmployes gestion = new GestionEmployes();

        Console.WriteLine("Avant ajout des employés:");

        // Affichage du salaire total et moyen avant ajout
        Directeur directeur = Directeur.Instance;
        directeur.SetGestionEmployes(gestion);
        Console.WriteLine("Salaire total de l'entreprise: " + directeur.SalaireTotal());
        Console.WriteLine("Salaire moyen des employés: " + directeur.SalaireMoyen());

        // Ajout des employés
        gestion.AjouterEmploye(emp1);
        gestion.AjouterEmploye(emp2);
        gestion.AjouterEmploye(emp3);

        // Affichage du salaire total et moyen après ajout
        Console.WriteLine("\nAprès ajout des employés:");
        Console.WriteLine("Salaire total de l'entreprise: " + directeur.SalaireTotal());
        Console.WriteLine("Salaire moyen des employés: " + directeur.SalaireMoyen());

        // Affichage des employés ajoutés
        Console.WriteLine("\nListe des employés ajoutés:");
        foreach (var employe in gestion.GetEmployes())
        {
            Console.WriteLine($"Nom: {employe.Nom}, Poste: {employe.Poste}, Salaire: {employe.Salaire}");
        }

        // Suppression d'un employé (par exemple, 'Malak')
        gestion.SupprimerEmploye(emp2);

        // Affichage du salaire total et moyen après suppression
        Console.WriteLine("\nAprès suppression de l'employé Malak:");
        Console.WriteLine("Salaire total de l'entreprise: " + directeur.SalaireTotal());
        Console.WriteLine("Salaire moyen des employés: " + directeur.SalaireMoyen());

        // Affichage des employés restants
        Console.WriteLine("\nListe des employés restants:");
        foreach (var employe in gestion.GetEmployes())
        {
            Console.WriteLine($"Nom: {employe.Nom}, Poste: {employe.Poste}, Salaire: {employe.Salaire}");
        }
    }
}
