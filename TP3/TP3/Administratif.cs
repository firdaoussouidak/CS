namespace TP3;

public abstract class Administratif : Personnel
{
    protected Administratif(int code, string nom, string prenom, string bureau, double salaire, double prime) : base(code, nom, prenom, bureau, salaire, prime)
    {
    }

    public override double? CalculerSalaire()
    {
        return Salaire;

    }
    
    public override string Afficher()
    {
        return $"Code: {Code} | Nom: {Nom} | Prenom: {Prenom} | Bureau : {Bureau} | Salaire : {Salaire} | Prime : {Prime}";
    }
}