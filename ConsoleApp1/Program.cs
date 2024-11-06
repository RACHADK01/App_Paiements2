using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        // Instances de Carte de Credit
        CarteCredit achat_CC1 = new CarteCredit(156.00, "Achat de livres", 467887346);
        CarteCredit achat_CC2 = new CarteCredit(226.43, "Achat d'équipement", 987654321);
        CarteCredit achat_CC3 = new CarteCredit(50.50, "Repas au restaurant", 456789123);

        achat_CC1.AfficherDetails();
        achat_CC2.AfficherDetails();
        achat_CC3.AfficherDetails();

    }
}