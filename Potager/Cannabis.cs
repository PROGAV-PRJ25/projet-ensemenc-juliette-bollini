public class Cannabis : Plante
{
    public Cannabis()
    {
        Nature = "Cannabis (plante récréative)";
        SaisonsSemis.AddRange(new[] { "Printemps", "Été" });
        TerrainPrefere = "terre légère";
        Espacement = 1.0f;
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
