public class Pavot : Plante
{
    // Compteur statique, initialisé à 0 une seule fois pour la classe Pavot
    private static int _compteur = 0;

    public Pavot()
    {
        // Incrémente le compteur et génère le nom unique
        _compteur++;
        Nom = $"pavot{_compteur}";

        Nature = "Pavot (opiacé)";
        SaisonsSemis = new List<Saison> { Saison.Printemps };
        EspaceNecessaire = 1.0f;
        VitesseDeCroissance = 0.02f;
        BesoinsEau = 0.5f;
        BesoinsLuminosite = 0.7f;
        TemperatureMin = 10;
        TemperatureMax = 25;
        EsperanceVie = 90;
        Production = 3;
    }
}
