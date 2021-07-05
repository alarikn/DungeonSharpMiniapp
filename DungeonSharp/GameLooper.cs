using System;

public class GameLooper
{
    private class Hero
    {
        public char heroName;
        public bool attacker;

        public Hero(char heroName, bool attacker)
        {
            this.heroName = heroName;
            this.attacker = attacker;
        }
    }

    Hero[] heroes = new Hero[2];
    public void Start()
    {
        heroes = new Hero[] {
                new Hero('q', true),
                new Hero('e', false)
            };

        string heroString = "";
        for (int i = 0; i < heroes.Length; i++)
        {
            heroString += $" {heroes[i].heroName} ";
        }
        heroString += "\n";
        for (int i = 0; i < heroes.Length; i++)
        {
            heroString += $" h ";
        }
        Console.WriteLine(heroString);

        Console.ReadKey();
    }
}

