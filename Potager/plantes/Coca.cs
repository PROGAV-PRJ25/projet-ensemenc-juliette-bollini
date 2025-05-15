public class Coca : Plante
{
    private static int _compteur = 0;
    private static int _totalHarvested = 0;
    public static int TotalHarvested => _totalHarvested;

    public Coca()
    {
        _compteur++;
        Nom = $"Coca{_compteur}";
        Nature = "Coca";
        SaisonsSemis = new List<Saison> { Saison.Printemps };

        EspaceNecessaire = 1.2f;
        VitesseDeCroissance = 0.6f;
        BesoinsEau = 0.4f;
        BesoinsLuminosite = 0.8f;
        TemperatureMin = 18;
        TemperatureMax = 28;
        EsperanceVie = 100;
        Maladie = "Botrytis";
        ProbaTomberMalade = 0.01;
    }

    protected override void AjouterAuPanier()
    {
        _totalHarvested++;
    }
}
