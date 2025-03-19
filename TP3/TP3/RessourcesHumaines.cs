namespace TP3;
using System.Collections.Generic;
using System.Linq;

public class RessourcesHumaines : IRessourcesHumaines
{
    private List<Personnel> GRH;

    public RessourcesHumaines()
    {
        GRH = new List<Personnel>();
    }

    public void AjouterPersonnel(Personnel p)
    {
        GRH.Add(p);
    }

    public void Afficher_Enseignants()
    {
        foreach (var p in GRH.OfType<Enseignant>())
        {
            Console.WriteLine(p.Afficher());
            foreach (var groupe in p.Group)
            {
                Console.WriteLine($"  Groupe: {groupe.Key}");
                foreach (var etudiant in groupe.Value)
                {
                    Console.WriteLine($"    {etudiant.Afficher()}");
                }
            }
        }
    }

    public int Rechercher_Ens(int code)
    {
        var enseignant = GRH.OfType<Enseignant>().FirstOrDefault(e => e.Code == code);
        return enseignant != null ? GRH.IndexOf(enseignant) : -1;
    }
}