namespace EX1;
using System;
public class Directeur
{
    private static Directeur instanceUnique;
    private GestionEmployes gestionEmployes;

    private Directeur()
    {
        gestionEmployes = new GestionEmployes();
    }

    public static Directeur Instance
    {
        get
        {
            if (instanceUnique == null)
            {
                instanceUnique = new Directeur();
            }
            return instanceUnique;
        }
    }

    public void SetGestionEmployes(GestionEmployes gestion)
    {
        gestionEmployes = gestion;
    }

    public float SalaireTotal()
    {
        return gestionEmployes.CalculerSalaireTotal();
    }

    public float SalaireMoyen()
    {
        return gestionEmployes.CalculerSalaireMoyen();
    }

    public GestionEmployes GetGestionEmployes()
    {
        return gestionEmployes;
    }
}
