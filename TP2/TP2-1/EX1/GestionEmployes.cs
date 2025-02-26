namespace EX1;
public class GestionEmployes
    {
        private Employee[] employes;
        private int employeCount;

        public GestionEmployes()
        {
            employes = new Employee[0]; // Tableau vide
            employeCount = 0;
        }

        public void AjouterEmploye(Employee employe)
        {
            Employee[] newList = new Employee[employeCount + 1];
            for (int i = 0; i < employeCount; i++)
            {
                newList[i] = employes[i];
            }
            newList[employeCount] = employe;
            employes = newList;
            employeCount++;
        }

        public void SupprimerEmploye(Employee employe)
        {
            int index = -1;
            for (int i = 0; i < employeCount; i++)
            {
                if (employes[i] == employe)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Employee[] newList = new Employee[employeCount - 1];
                for (int i = 0, j = 0; i < employeCount; i++)
                {
                    if (i != index)
                    {
                        newList[j++] = employes[i];
                    }
                }
                employes = newList;
                employeCount--;
            }
        }

        public float CalculerSalaireTotal()
        {
            float salaireTotal = 0;
            for (int i = 0; i < employeCount; i++)
            {
                salaireTotal += employes[i].Salaire;
            }
            return salaireTotal;
        }

        public float CalculerSalaireMoyen()
        {
            if (employeCount == 0)
                return 0;
            return CalculerSalaireTotal() / employeCount;
        }

        public Employee[] GetEmployes()
        {
            return employes;
        }
}