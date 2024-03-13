namespace NombreMagique
{
    internal class Program
    {
        static int DemandeNombre(int min, int max)
        {
            int nombre = 0;
            while(nombre == 0)
            {
                Console.Write("Entrez un nombre entre " + min + " et " + max+ " : ");
                string reponse = Console.ReadLine();
                try
                {
                    //Conversion d'un string en entier
                    nombre = int.Parse(reponse);  
                    if(nombre <= 1 || nombre >= 10)
                    {
                        Console.WriteLine("\nErreur: Le nombre doit etre entre "+ min +" et "+ max);
                        nombre = 0;
                    }
                }
                catch 
                {
                    Console.WriteLine("Erreur: Nombre entré n'est pas valide."); ;
                }
            }
            return nombre;
        }
            
        static void Main(string[] args)
        {
            const int no_min = 1;
            const int no_max = 10;
            Random rand = new Random();
            int no_magique  = rand.Next(no_min, no_max+1);

            int nombre = no_magique+1;

            int nbVies = 4;
            while(nbVies > 0)
            {
                Console.WriteLine("Il vous reste " + nbVies + " tentatives");
                nombre = DemandeNombre(no_min, no_max);
                if (no_magique > nombre)
                {
                    Console.WriteLine("Le nombre magique est plus grand.");
                }
                else if (no_magique < nombre)
                {
                    Console.WriteLine("Le nombre magique est plus petit.");
                }
                else
                {
                    Console.WriteLine("Bravo,vous avez trouvé le nombre magique!!! \nCe nombre magique est: " + no_magique + ".");
                    break;
                }
                nbVies--;
            }
            if (nbVies == 0)
            {
                Console.WriteLine("Vous avez perdu. \nLe nombre magique était " + no_magique);
            }
        }
    }
}
