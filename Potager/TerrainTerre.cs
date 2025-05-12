public class TerrainTerre : Terrain
{
    private static int _compteur = 0;

    public TerrainTerre()
    {
        _compteur++;
        Nom = $"Terrain de terre{_compteur}";
        TypeSol = "Terre";
        TeneurEau = 0.6f;
    }

    protected override void ArroserTerrain()
    {
        TeneurEau = 0.6f;
    }
}
