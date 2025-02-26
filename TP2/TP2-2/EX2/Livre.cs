namespace EX2;
public class Livre : Document
{
    private string auteur;
    private int nombreDePages;
    public Livre(string titre, string auteur, int nombreDePages) : base(titre)
    {
        this.auteur = auteur;
        this.nombreDePages = nombreDePages;
    }
    public string Auteur
    {
        get { return auteur; }
        set { auteur = value; }
    }
    public int NombreDePages
    {
        get { return nombreDePages; }
        set { nombreDePages = value; }
    }
    public override string Description()
    {
        return $"Livre #{NumeroEnregistrement} - Titre: {Titre}, Auteur: {Auteur}, Pages: {NombreDePages}";
    }
}
