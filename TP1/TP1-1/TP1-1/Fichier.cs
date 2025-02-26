namespace TP1_1;

public class Fichier
{
    private string nom;
    private double taille;
    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public double Taille
    {
        get { return taille; }
        set
        {
            if (value >= 0)
                taille = value;
            else
                throw new ArgumentException("La taille doit être positive.");
        }
    }
    public Fichier(string nom, double taille)
    {
        Nom = nom;
        Taille = taille;
    }
    public void AfficherInfos()
    {
        Console.WriteLine($"Fichier : {Nom}, Taille : {Taille} Mo");
    }
}