namespace EX2;
using System;

class Program
{
    static void Main(string[] args)
    {
        Livre livre1 = new Livre("Le C# pour les débutants", "Souidak Firdaous", 300);
        Dictionnaire dic1 = new Dictionnaire("Dictionnaire Anglais", "Anglais", 50000);
        Livre livre2 = new Livre("Le Guide du Développeur", "Soulhi Malak", 250);
        Biblio biblio = new Biblio(5);
        
        biblio.AjouterDocument(livre1);
        biblio.AjouterDocument(dic1);
        biblio.AjouterDocument(livre2);
        
        Console.WriteLine("Descriptions de tous les documents:");
        biblio.ToutesLesDescriptions();
        
        Console.WriteLine("\nTous les auteurs:");
        biblio.TousLesAuteurs();
        
        Console.WriteLine("\nDictionnaires:");
        biblio.AfficherDictionnaires();
        
        Console.WriteLine("\nNombre de livres dans la bibliothèque: " + biblio.NombreDeLivres());
    }
}
