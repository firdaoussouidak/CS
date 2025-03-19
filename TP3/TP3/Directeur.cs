namespace TP3;

public class Directeur : Personnel
{
    private static Directeur instance;

    private Directeur(int code, string nom, string prenom, string bureau, double salaire, double prime)
        : base(code, nom, prenom, bureau, salaire, prime) {}

    public static Directeur GetInstance(int code, string nom, string prenom, string bureau, double salaire, double prime)
    {
        if (instance == null)
        {
            instance = new Directeur(code, nom, prenom, bureau, salaire, prime);
        }
        else
        {
            Console.WriteLine("Erreur : Un directeur existe déjà !");
        }
        return instance;
    }

    public override double? CalculerSalaire()
    {
        return Salaire + Prime;
    }

    public override string Afficher()
    {
        return $"Directeur -> {base.Afficher()}";
    }
}