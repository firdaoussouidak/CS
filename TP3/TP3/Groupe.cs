namespace TP3;

public class Groupe
{
    private string nom;
    private List<Etudiant> Etudiants;

    public Groupe(string nom)
    {
        this.nom = nom;
        this.Etudiants = new List<Etudiant>();
    }
    
    public Groupe(string nom, List<Etudiant> Etudiants)
    {
        this.nom = nom;
        this.Etudiants = Etudiants;
    }

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public List<Etudiant> Etudiant
    {
        get { return Etudiants; }
        set { Etudiants = value; }
    }

    public void AjouterEtudiant(Etudiant etudiant)
    {
        this.Etudiants.Add(etudiant);
    }

    public void AfficherEtudiants()
    {
        foreach (Etudiant etudiant in Etudiants)
        {
            Console.WriteLine(etudiant.Nom);
        }
    }

    public Etudiant GetEtudiant(int index)
    {
        return Etudiants[index];
    }
}