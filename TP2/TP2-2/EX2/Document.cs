namespace EX2;
public class Document
{
    private static int compteur = 1; 
    private int numeroEnregistrement;
    private string titre; 

    public Document(string titre)
    {
        numeroEnregistrement = compteur++;
        this.titre = titre;
    }
    
    public int NumeroEnregistrement
    {
        get { return numeroEnregistrement; }
    }
    
    public string Titre
    {
        get { return titre; }
        set { titre = value; }
    }
    
    public virtual string Description()
    {
        return $"Document #{NumeroEnregistrement} - Titre: {Titre}";
    }
}
