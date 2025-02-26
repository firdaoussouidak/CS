namespace EX2;
public class Dictionnaire : Document
{
    private string langue;
    private int nombreDeDefinitions; 
    public Dictionnaire(string titre, string langue, int nombreDeDefinitions) : base(titre)
    {
        this.langue = langue;
        this.nombreDeDefinitions = nombreDeDefinitions;
    }
    public string Langue
    {
        get { return langue; }
        set { langue = value; }
    }
    public int NombreDeDefinitions
    {
        get { return nombreDeDefinitions; }
        set { nombreDeDefinitions = value; }
    }
    public override string Description()
    {
        return $"Dictionnaire #{NumeroEnregistrement} - Titre: {Titre}, Langue: {Langue}, Définitions: {NombreDeDefinitions}";
    }
}
