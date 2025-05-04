public class Coca : Plante
{
    private static int _compteur = 0;

    public Coca()
    {
        Nom = $"Coca{_compteur}";
        Nature = "Coca (stimulant)";
        SaisonsSemis = new List<Saison> { Saison.Printemps };

        EspaceNecessaire = 1.2f;
        VitesseDeCroissance = 0.6f;
        BesoinsEau = 0.4f;
        BesoinsLuminosite = 0.8f;
        TemperatureMin = 18;
        TemperatureMax = 28;
        EsperanceVie = 100;
        Production = 4;
    }
}
