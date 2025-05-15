public class Affichage
{
    public void AfficherPotager(Terrain terrain)
    {
        Console.WriteLine("État du potager :");
        foreach (var plante in terrain.Plantes)
        {
            Console.Write($"| {plante.GetSymbole()} ");
        }
        Console.WriteLine("|");
    }

    public void AfficherDebut()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n⚠️  ATTENTION : Ce simulateur est une œuvre fictionnelle.");
        Console.WriteLine("Toutes les substances cultivées ici sont illégales dans la vraie vie.");
        Console.WriteLine("Ce jeu est une satire pédagogique. Ne reproduisez RIEN chez vous. ");
        Console.ResetColor();
        Console.WriteLine(
            "Bienvenue dans ENSemenC, vous êtes au Mexique au sein d'un terrain composé de plusieurs potagers sur lesquels vous devez faire poussez des plantes récréatives à caractéristiques hallucinogènes ! "
        );
    }

    public void AfficherMenuClassique() //une lecture des touches données par le joueur est à faire
    {
        Console.WriteLine("\n--- Menu ---");
        Console.WriteLine("1. Planter");
        Console.WriteLine("2. Arroser");
        Console.WriteLine("3. Récolter");
        Console.WriteLine("4. Ratisser");
        Console.WriteLine("5. Regarder mes terrains ");
        Console.WriteLine("6. Boutique ");
        Console.WriteLine("7. Fini ");
    }

    public void AfficherAlerte(string message) // voir pour le type de message entre alerte
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n⚠️ {message} ⚠️");
        Console.ResetColor();
    }

    public void AfficherTerrain(Terrain terrain)
    {
        int lignes = 3;
        int colonnes = 3;

        Console.WriteLine($"\nÉtat du terrain :\n {terrain.Nom}\n");

        for (int i = 0; i < lignes; i++)
        {
            Console.Write("+");
            for (int j = 0; j < colonnes; j++)
                Console.Write("----+");
            Console.WriteLine();

            Console.Write("|");
            for (int j = 0; j < colonnes; j++)
            {
                int index = i * colonnes + j;
                if (index < terrain.Plantes.Count)
                {
                    var plante = terrain.Plantes[index];
                    Console.Write($" {plante?.GetSymbole() ?? " "} |");
                }
                else
                {
                    Console.Write("    |");
                }
            }
            Console.WriteLine();
        }

        Console.Write("+");
        for (int j = 0; j < colonnes; j++)
            Console.Write("----+");
        Console.WriteLine();

        AfficherJaugeEau(terrain.TeneurEau);
    }

    public void AfficherTousLesTerrainsAvecNavigation(List<Terrain> tousLesTerrains)
    {
        int index = 0;
        ConsoleKey key;

        do
        {
            Console.Clear();
            Console.WriteLine($"--- TERRAIN {index + 1}/{tousLesTerrains.Count} ---");

            AfficherTerrain(tousLesTerrains[index]);

            Console.WriteLine(
                "\nUtilise les flèches gauche/droite pour naviguer. Échap pour revenir au menu."
            );
            key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.RightArrow && index < tousLesTerrains.Count - 1)
                index++;
            else if (key == ConsoleKey.LeftArrow && index > 0)
                index--;
        } while (key != ConsoleKey.Escape);
    }

    public void AfficherJaugeEau(float pourcentage)
    {
        int tailleTotale = 10;
        int remplis = (int)Math.Round((pourcentage * tailleTotale) / 100);
        int vides = tailleTotale - remplis;

        Console.Write("💧 Eau disponible : [");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(new string('█', remplis));
        Console.ResetColor();
        Console.Write(new string('░', vides));
        Console.WriteLine($"] {pourcentage}%");
    }
}
