namespace TP3;
using System.Collections.Generic;

public class Enseignant : Personnel
{
    private Grade grade;
    private int volumeHoraire;
    private Dictionary<string, List<Etudiant>> groups;

    public Enseignant(int code, string nom, string prenom, string bureau, double salaire, double prime, Grade grade, int volumeHoraire)
        : base(code, nom, prenom, bureau, salaire, prime)
    {
        this.grade = grade;
        this.volumeHoraire = volumeHoraire;
        this.groups = new Dictionary<string, List<Etudiant>>();
    }

    public Grade Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public int VolumeHoraire
    {
        get { return volumeHoraire; }
        set { volumeHoraire = value; }
    }

    public Dictionary<string, List<Etudiant>> Group
    {
        get { return groups; }
    }

    public override double? CalculerSalaire()
    {
        double tauxHoraire = grade switch
        {
            Grade.PA => 300,
            Grade.PH => 350,
            Grade.PES => 400,
            _ => 0
        };

        return Salaire + Prime + (volumeHoraire * tauxHoraire);
    }

    public override string Afficher()
    {
        return $"Enseignant -> {base.Afficher()} | Grade: {grade} | Volume Horaire: {volumeHoraire}";
    }

    public void AjouterGroupe(Groupe groupe)
    {
        if (!groups.ContainsKey(groupe.Nom))
        {
            groups[groupe.Nom] = new List<Etudiant>();
        }
        groups[groupe.Nom].AddRange(groupe.Etudiant);
    }

    public List<Etudiant> this[string groupName]
    {
        get => groups.ContainsKey(groupName) ? groups[groupName] : new List<Etudiant>();
        set => groups[groupName] = value;
    }
}