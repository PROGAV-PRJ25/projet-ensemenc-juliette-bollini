public class Cannabis : Plante
{
    private static int _compteur = 0;
    private static int _totalHarvested = 0;
    public static int TotalHarvested => _totalHarvested;

    public Cannabis()
    {
        _compteur++;
        Nature = "Cannabis";
        Nom = $"Canabis{_compteur}";
        EspaceNecessaire = 2.0f;
        VitesseDeCroissance = 0.8f;
        BesoinsEau = 0.6f;
        BesoinsLuminosite = 0.9f;
        TemperatureMin = 15;
        TemperatureMax = 30;
        EsperanceVie = 120;
        Maladie = "cercosporiose";
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
