namespace TP12;
using System;

public class Projet
{
    private string code;
    private string sujet;
    private int dureeSemaines;
    private Programmeur[] programmeurs;
    private ConsommationCafe[] consommations;
    private int indexProgrammeurs = 0;
    private int indexConsommations = 0;

    public string Code
    {
        get { return code; }
        set { code = value; }
    }

    public string Sujet
    {
        get { return sujet; }
        set { sujet = value; }
    }

    public int DureeSemaines
    {
        get { return dureeSemaines; }
        set { dureeSemaines = value; }
    }

    public Projet(string code, string sujet, int dureeSemaines, int maxProgrammeurs, int maxConsommations)
    {
        Code = code;
        Sujet = sujet;
        DureeSemaines = dureeSemaines;
        programmeurs = new Programmeur[maxProgrammeurs];
        consommations = new ConsommationCafe[maxConsommations];
    }

    public void AjouterProgrammeur(Programmeur programmeur)
    {
        if (indexProgrammeurs < programmeurs.Length)
        {
            programmeurs[indexProgrammeurs] = programmeur;
            indexProgrammeurs++;
            Console.WriteLine($"Programmeur {programmeur.Nom} {programmeur.Prenom} ajouté.");
        }
        else
        {
            Console.WriteLine("Nombre maximum de programmeurs atteint.");
        }
    }

    public Programmeur RechercherProgrammeur(int id)
    {
        for (int i = 0; i < indexProgrammeurs; i++)
        {
            if (programmeurs[i].Id == id)
                return programmeurs[i];
        }
        return null;
    }

    public void AfficherProgrammeurs()
    {
        Console.WriteLine($"Programmeurs du projet {Code}:");
        for (int i = 0; i < indexProgrammeurs; i++)
        {
            programmeurs[i].AfficherInfos();
        }
    }

    public void AjouterConsommationCafe(int numeroSemaine, int idProgrammeur, int nombreTasses)
    {
        Programmeur prog = RechercherProgrammeur(idProgrammeur);
        if (prog != null)
        {
            if (indexConsommations < consommations.Length)
            {
                consommations[indexConsommations] = new ConsommationCafe(numeroSemaine, prog, nombreTasses);
                indexConsommations++;
                Console.WriteLine($"Consommation ajoutée pour {prog.Nom} {prog.Prenom}.");
            }
            else
            {
                Console.WriteLine("Nombre maximum de consommations atteint.");
            }
        }
        else
        {
            Console.WriteLine("Programmeur introuvable.");
        }
    }

    public void AfficherTotalCafeParSemaine(int numeroSemaine)
    {
        int total = 0;
        for (int i = 0; i < indexConsommations; i++)
        {
            if (consommations[i].NumeroSemaine == numeroSemaine)
                total += consommations[i].NombreTasses;
        }
        Console.WriteLine($"Total de café consommé en semaine {numeroSemaine}: {total} tasses.");
    }
}
