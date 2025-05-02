public class Coca : Plante
{
    public Coca()
    {
        Nature = "Coca (stimulant)";
        SaisonsSemis.Add("Printemps");
        Espacement = 0.7f;
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
