namespace EX2;
using System;
public class Biblio
{
    private Document[] documents;
    private int compteur;
    public Biblio(int tailleInitiale = 10)
    {
        documents = new Document[tailleInitiale];
        compteur = 0;
    }
    public void AjouterDocument(Document document)
    {
        if (compteur == documents.Length)
        {
            Document[] nouveauTableau = new Document[documents.Length * 2];
            Array.Copy(documents, nouveauTableau, documents.Length);
            documents = nouveauTableau;
        }
        documents[compteur++] = document;
    }
    public int NombreDeLivres()
    {
        int count = 0;
        for (int i = 0; i < compteur; i++)
        {
            if (documents[i] is Livre)
            {
                count++;
            }
        }
        return count;
    }
    public void AfficherDictionnaires()
    {
        for (int i = 0; i < compteur; i++)
        {
            if (documents[i] is Dictionnaire)
            {
                Console.WriteLine(documents[i].Description());
            }
        }
    }
    public void TousLesAuteurs()
    {
        for (int i = 0; i < compteur; i++)
        {
            if (documents[i] is Livre livre)
            {
                Console.WriteLine($"Numéro: {documents[i].NumeroEnregistrement}, Auteur: {livre.Auteur}");
            }
            else
            {
                Console.WriteLine($"Numéro: {documents[i].NumeroEnregistrement}, Pas d'auteur");
            }
        }
    }
    public void ToutesLesDescriptions()
    {
        for (int i = 0; i < compteur; i++)
        {
            Console.WriteLine(documents[i].Description());
        }
    }
}
