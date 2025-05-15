public class Boutique
{
    public int Argent { get; private set; }

    public Boutique()
    {
        Argent = 100;
    }

    public void VendreTout()
    {
        Console.WriteLine("\n💼 Vente de la récolte en cours...");

        // Récupérer les quantités récoltées
        int totalCoca = Coca.TotalHarvested;
        int totalCannabis = Cannabis.TotalHarvested;
        int totalPavot = Pavot.TotalHarvested;

        // Prix de base
        int prixBaseCoca = 100;
        int prixBaseCannabis = 10;
        int prixBasePavot = 50;

        // Prix progressifs (plus t’en cultives, plus tu gagnes)
        int prixFinalCoca = prixBaseCoca + (totalCoca * 100);
        int prixFinalCannabis = prixBaseCannabis + (totalCannabis * 10);
        int prixFinalPavot = prixBasePavot + (totalPavot * 50);

        // Gains calculés
        int gainCoca = totalCoca * prixFinalCoca;
        int gainCannabis = totalCannabis * prixFinalCannabis;
        int gainPavot = totalPavot * prixFinalPavot;

        int gainTotal = gainPavot + gainCannabis + gainCoca;
        Argent += gainTotal;

        // Affichage
        Console.WriteLine($"- {totalCoca}x Coca vendus à {prixFinalCoca}€/unité → +{gainCoca}€");
        Console.WriteLine(
            $"- {totalCannabis}x Cannabis vendus à {prixFinalCannabis}€/unité → +{gainCannabis}€"
        );
        Console.WriteLine(
            $"- {totalPavot}x Pavot vendus à {prixFinalPavot}€/unité → +{gainPavot}€"
        );
        Console.WriteLine($"\n💰 Total gagné : {gainTotal}€");
        Console.WriteLine($"💸 Argent total : {Argent}€");

        // Réinitialise les compteurs après la vente
        Coca.ResetCompteur();
        Cannabis.ResetCompteur();
        Pavot.ResetCompteur();
    }

    public void AfficherArgent()
    {
        Console.WriteLine($"\n💸 Argent actuel : {Argent}€");
    }
}
