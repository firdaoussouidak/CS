namespace TP12;
using System;

public class ConsommationCafe
{
    private int numeroSemaine;
    private Programmeur programmeur;
    private int nombreTasses;

    public int NumeroSemaine
    {
        get { return numeroSemaine; }
        set { numeroSemaine = value; }
    }

    public Programmeur Programmeur
    {
        get { return programmeur; }
        set { programmeur = value; }
    }

    public int NombreTasses
    {
        get { return nombreTasses; }
        set { nombreTasses = value; }
    }

    public ConsommationCafe(int numeroSemaine, Programmeur programmeur, int nombreTasses)
    {
        NumeroSemaine = numeroSemaine;
        Programmeur = programmeur;
        NombreTasses = nombreTasses;
    }

    public void AfficherInfos()
    {
        Console.WriteLine($"Semaine {NumeroSemaine}: {Programmeur.Nom} {Programmeur.Prenom} a consommé {NombreTasses} tasses de café.");
    }
}