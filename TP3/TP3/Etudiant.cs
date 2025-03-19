namespace TP3;

public class Etudiant : Personne
{
    private int niveau;
    private double moyenneAnnuelle;

    public Etudiant(int code, string nom, string prenom, int niveau, double moyenneAnnuelle) : base(code, nom, prenom)
    {
        this.niveau = niveau;
        this.moyenneAnnuelle = moyenneAnnuelle;
    }

    public int Niveau
    {
        get { return niveau; }
        set { niveau = value; }
    }

    public double MoyenneAnnuelle
    {
        get { return moyenneAnnuelle; }
        set { moyenneAnnuelle = value; }
    }

    public override string Afficher()
    {
        return $"Code: {Code} | Nom: {Nom} | Prenom: {Prenom} | Niveau : {Niveau} | Moyenne Annuelle : {MoyenneAnnuelle}";
    }
}