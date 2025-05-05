public class Cannabis : Plante
{
    private static int _compteur = 0;

    public Cannabis()
    {
        Nature = "Cannabis";
        Nom = $"Canabis{_compteur}";
        SaisonsSemis = new List<Saison> { Saison.Printemps };
        EspaceNecessaire = 2.0f;
        VitesseDeCroissance = 0.8f;
        BesoinsEau = 0.6f;
        BesoinsLuminosite = 0.9f;
        TemperatureMin = 15;
        TemperatureMax = 30;
        EsperanceVie = 120;
        Production = 5;
    }
}
