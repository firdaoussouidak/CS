namespace TP1_1;

public class Repertoire
{
    private string nom;
    private Fichier[] fichiers;
    private int index;

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public Repertoire(string nom, int capacite)
    {
        Nom = nom;
        fichiers = new Fichier[capacite];
        index = 0;
    }

    public void AjouterFichier(Fichier fichier)
    {
        if (index < fichiers.Length)
        {
            fichiers[index] = fichier;
            index++;
        }
        else
        {
            Console.WriteLine("Le répertoire est plein, impossible d'ajouter un nouveau fichier.");
        }
    }

    public void AfficherContenu()
    {
        Console.WriteLine($"Répertoire : {Nom}");
        for (int i = 0; i < index; i++)
        {
            fichiers[i].AfficherInfos();
        }
    }
}