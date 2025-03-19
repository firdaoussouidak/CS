namespace TP3;

public class Personne
{
    private int code;
    private string nom;
    private string prenom;

    public Personne(int code, string nom, string prenom)
    {
        this.code = code;
        this.nom = nom;
        this.prenom = prenom;
    }
    
    public int Code
    {
        get { return code; }
        set { code = value; }
    }   
    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }
    public string Prenom
    {
        get { return prenom; }
        set { nom = value; }
    }

    public virtual string Afficher()
    {
        return $"Code: #{code} | Nom: {nom} | Prenom: {prenom}";
    }
}