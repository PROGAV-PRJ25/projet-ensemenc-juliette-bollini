public class TerrainTerre : Terrain
{
    private static int _compteur = 0;

    public TerrainTerre()
    {
        _compteur++;
        Nom = $"Terrain de terre{_compteur}";
        TypeSol = "Terre";
        TeneurEau = 100;
    }

    public override void Assecher()
    {
        TeneurEau -= 2 * Plantes.Count;
    }
}
