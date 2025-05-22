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
            "Bienvenue dans ENSemenC, vous êtes au Mexique au sein d'un terrain composé de plusieurs potagers sur lesquels vous devez faire poussez des plantes récréatives à caractéristiques hallucinogènes !\n Le but du jeu est de gagner le plus de sous possible avec vos récoltes pendant le nombre de semaines que vous souhaitez jouer "
        );
    }

    public void AfficherMenuClassique(bool modeRapide) //une lecture des touches données par le joueur est à faire
    {
        Console.WriteLine("\n--- Menu ---");
        Console.WriteLine("1. Planter");
        Console.WriteLine("2. Arroser");
        Console.WriteLine("3. Récolter");
        Console.WriteLine("4. Ratisser");
        Console.WriteLine("5. Regarder mes terrains ");
        Console.WriteLine("6. Vendre ");
        Console.WriteLine("7. Soigner");

        if (modeRapide)
        {
            Console.WriteLine("8. Passer en mode lent (jour par jour) ");
        }
        else
        {
            Console.WriteLine("8. Passer en mode rapide (semaine par semaine) ");
        }
        Console.WriteLine("9. Fini ");
    }

    public void AfficherAlerte(string message) // voir pour le type de message entre alerte
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n⚠️ {message} ⚠️");
        Console.ResetColor();
    }

    public void AfficherTerrain(Terrain terrain, bool clignote) //Affichage du terrain après une modification
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
                    Console.Write($" {plante?.GetSymbole(clignote) ?? " "} |");
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

    private bool TerrainContientPlantesMalades(Terrain terrain)
    {
        return terrain.Plantes.Any(p => p.EstMalade);
    }

    public void AfficherTousLesTerrainsAvecNavigation(List<Terrain> tousLesTerrains)
    {
        int index = 0;
        bool quitter = false;

        while (!quitter)
        {
            var terrain = tousLesTerrains[index];
            bool contientMalades = TerrainContientPlantesMalades(terrain);

            if (!contientMalades) // Affichage non clignotant
            {
                Console.Clear();
                Console.WriteLine($"--- TERRAIN {index + 1}/{tousLesTerrains.Count} ---");
                AfficherTerrain(terrain, false);
                Console.WriteLine("\n← gauche | → droite | Échap pour revenir au menu");

                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(100);
                }

                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.RightArrow && index < tousLesTerrains.Count - 1)
                    index++;
                else if (key == ConsoleKey.LeftArrow && index > 0)
                    index--;
                else if (key == ConsoleKey.Escape)
                    quitter = true;
            }
            else // Affichage clignotaant
            {
                bool clignote = false;
                bool resterSurTerrain = true;

                while (resterSurTerrain && !quitter)
                {
                    Console.Clear();
                    Console.WriteLine($"--- TERRAIN {index + 1}/{tousLesTerrains.Count} ---"); //défilement des numéros de terrain
                    AfficherTerrain(terrain, clignote);
                    Console.WriteLine("\n← gauche | → droite | Échap pour revenir au menu");

                    Thread.Sleep(500);
                    clignote = !clignote;

                    if (Console.KeyAvailable) // lecture touche utilisateur
                    {
                        var key = Console.ReadKey(true).Key;

                        if (key == ConsoleKey.RightArrow && index < tousLesTerrains.Count - 1)
                        {
                            index++;
                            resterSurTerrain = false;
                        }
                        else if (key == ConsoleKey.LeftArrow && index > 0)
                        {
                            index--;
                            resterSurTerrain = false;
                        }
                        else if (key == ConsoleKey.Escape)
                        {
                            quitter = true;
                            resterSurTerrain = false;
                        }
                    }
                }
            }
        }
    }

    public void AfficherJaugeEau(float pourcentage) //Affiche la jauge d'eau du terrain afin de ne pas en manquer
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

    public void RecherchePolice(List<Terrain> tousLesTerrains, Boutique boutique)
    {
        Random rnd = new Random();
        double tirage = rnd.NextDouble();

        if (tirage < 0.01 && tousLesTerrains.Count > 0) // 15% de chance
        {
            int terrainIndex = rnd.Next(tousLesTerrains.Count);
            Terrain terrainCible = tousLesTerrains[terrainIndex];
            int coutCorruption = 500;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                $"\n🚔 Une patrouille de police a repéré une activité suspecte sur le terrain '{terrainCible.Nom}' !"
            );
            Console.ResetColor();

            if (boutique.Argent >= coutCorruption)
            {
                boutique.RetirerArgent(coutCorruption);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
                    $"💸 Vous avez corrompu la police pour {coutCorruption}€. Terrain sauvé !"
                );
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(
                    "Pas assez d'argent pour corrompre ! Le plantes du terrain ont été saisies !"
                );
                Console.ResetColor();
                // Supprimer toutes les plantes du terrain
                terrainCible.Plantes.Clear();

                // Supprimer le terrain
                tousLesTerrains.RemoveAt(terrainIndex);
            }
        }
    }
}
