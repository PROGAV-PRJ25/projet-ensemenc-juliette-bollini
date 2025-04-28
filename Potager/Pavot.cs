public class Pavot : Plante
{
    public Pavot()
    {
        Nature = "Pavot (opiacé)";
        SaisonsSemis.Add("Printemps");
        TerrainPrefere = "terre lourde";
        Espacement = 0.5f;
        EspaceNecessaire = 1.0f;
        VitesseDeCroissance = 0.5f;
        BesoinsEau = 0.5f;
        BesoinsLuminosite = 0.7f;
        TemperatureMin = 10;
        TemperatureMax = 25;
        EsperanceVie = 90;
        Production = 3;
    }
}
