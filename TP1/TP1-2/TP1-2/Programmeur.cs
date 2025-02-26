namespace TP12;
using System;

public class Programmeur
{
    private int id;
    private string nom;
    private string prenom;
    private int bureau;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public string Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }

    public int Bureau
    {
        get { return bureau; }
        set { bureau = value; }
    }

    public Programmeur(int id, string nom, string prenom, int bureau)
    {
        Id = id;
        Nom = nom;
        Prenom = prenom;
        Bureau = bureau;
    }

    public void AfficherInfos()
    {
        Console.WriteLine($"ID: {Id}, Nom: {Nom}, Prénom: {Prenom}, Bureau: {Bureau}");
    }
}