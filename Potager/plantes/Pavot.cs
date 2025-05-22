public class Pavot : Plante
{
    // Compteur statique, initialisé à 0 une seule fois pour la classe Pavot
    private static int _compteur = 0;
    private static int _totalHarvested = 0;
    public static int TotalHarvested => _totalHarvested;

    public Pavot()
    {
        // Incrémente le compteur et génère le nom unique
        _compteur++;
        Nom = $"pavot{_compteur}";
        Nature = "Pavot";
        EspaceNecessaire = 1.0f;
        VitesseDeCroissance = 0.02f;
        BesoinsEau = 0.5f;
        BesoinsLuminosite = 0.7f;
        TemperatureMin = 10;
        TemperatureMax = 25;
        EsperanceVie = 90;
        Maladie = "Rouille";
        ProbaTomberMalade = 0.01;
    }

    protected override void AjouterAuPanier()
    {
        _totalHarvested++;
    }

    public static void ResetCompteur()
    {
        _totalHarvested = 0;
    }
}
