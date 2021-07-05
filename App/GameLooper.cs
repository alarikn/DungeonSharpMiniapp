using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        string path = AppDomain.CurrentDomain.BaseDirectory;
        JObject jsonObject = JObject.Parse(File.ReadAllText($"{path}monsters.json"));
        string jsonData = jsonObject.ToString();
        var monsterData = JsonConvert.DeserializeObject<MonsterRoot>(jsonData);
        foreach(MonsterResult monster in monsterData.Results)
        {
            Console.WriteLine(monster.Name);
        }

        Console.Read();
    }
}
