namespace Projet_2;

class Compte
{
    // initialisation des attributs
    public int Num {get; set;}
    public string nom {get; set;}
    public double solde {get; set;}

    // méthode d'initialisation
    public Compte(int num, string nom, double solde)
    {
        this.Num = num;
        this.nom = nom;
        this.solde = solde;
    }
}
class Program
{
    static void Main(string[] args)
    {
        static void displayCompte(Compte c)
        {
            Console.WriteLine($"{c.Num} /{c.nom} /{c.solde}");
        }

        static void displayBDD(List<Compte> bdd)
        {
            Console.WriteLine("Voici la liste des comptes dans la banque et leur solde :");
            foreach (Compte c in bdd)
            {
                displayCompte(c);
            }
            Console.WriteLine("\n");
        }

        static void credit(Compte c, double montant)
        {
            Console.WriteLine("Procédure de crédit");
            displayCompte(c);
            c.solde += montant;
            displayCompte(c);
            Console.WriteLine("Fin de crédit");
        }
        static void debit(Compte c, double montant)
        {
            Console.WriteLine("Procédure de débit");
            displayCompte(c);
            c.solde -= montant;
            displayCompte(c);
            Console.WriteLine("Fin de débit");
        }

        Compte compte1 = new Compte(1, "Sebastien Puduglen", 2500.8);
        Compte compte2 = new Compte(2, "Jeanne Pudlashat", 15000.35);
        Compte compte3 = new Compte(3, "Harry Shlingzboub", 6500.50);

        List<Compte> BDDBank = new List<Compte>();
        BDDBank.Add(compte1);
        BDDBank.Add(compte2);
        BDDBank.Add(compte3);
        displayBDD(BDDBank);

        Compte compte4 = compte1;
        Console.WriteLine("Avant crédit compte 1 500 euros");
        Console.WriteLine("Compte 1");
        displayCompte(compte1);
        Console.WriteLine("Compte 4");
        displayCompte(compte4);
        Console.WriteLine("\n");

        credit(compte1, 500);
        Console.WriteLine("\n");
        debit(compte4, 100);

        Console.WriteLine("\nAprès crédit compte 1 500 euros");
        Console.WriteLine("Compte 1");
        displayCompte(compte1);
        Console.WriteLine("Compte 4");
        displayCompte(compte4);
        // ici, les deux comptes partagent la même valeur constamment.
    }
}