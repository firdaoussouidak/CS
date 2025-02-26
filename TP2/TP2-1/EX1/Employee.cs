namespace EX1;
using System;
public class Employee
{
    private string nom;
    private float salaire;
    private string poste;
    private DateTime dateEmbauche;

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public float Salaire
    {
        get { return salaire; }
        set { salaire = value; }
    }

    public string Poste
    {
        get { return poste; }
        set { poste = value; }
    }

    public DateTime DateEmbauche
    {
        get { return dateEmbauche; }
        set { dateEmbauche = value; }
    }
    public Employee(string nom, float salaire, string poste, DateTime dateEmbauche)
    {
        this.nom = nom;
        this.salaire = salaire;
        this.poste = poste;
        this.dateEmbauche = dateEmbauche;
    }
}