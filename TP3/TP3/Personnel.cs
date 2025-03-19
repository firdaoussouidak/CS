namespace TP3;

public abstract class Personnel : Personne
{
    private string bureau;
    protected double salaire;
    private double prime;

    public Personnel(int code, string nom, string prenom, string bureau, double salaire, double prime) : base(code, nom, prenom)
    {
        this.bureau = bureau;
        this.salaire = salaire;
        this.prime = prime;
    }
    public string Bureau
    {
        get { return bureau; }
        set { bureau = value; }
    }

    public double Salaire
    {
        get { return salaire; }
        set { salaire = value; }
    }

    public double Prime
    {
        get { return prime; }
        set { prime = value; }
    }

    public override string Afficher()
    {
        return $"Code: {Code} | Nom: {Nom} | Prenom: {Prenom} | Bureau : {bureau} | Salaire : {salaire} | Prime : {prime}";
    }

    public abstract double? CalculerSalaire();

}