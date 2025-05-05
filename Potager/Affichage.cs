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
        Console.WriteLine("1. Arroser");
        Console.WriteLine("2. Récolter");
        Console.WriteLine("3. Changer de terrain");
        Console.WriteLine("4. Passer à la semaine suivante");
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

        Console.WriteLine($"\nÉtat du terrain : {terrain.Nom}\n");

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
    }
}
