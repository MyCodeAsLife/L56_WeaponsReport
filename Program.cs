using System;
using System.Collections.Generic;
using System.Linq;

namespace L56_WeaponsReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Headquarters headquarters = new Headquarters();

            headquarters.ShowSquadPersonnels();
        }
    }

    class Headquarters
    {
        private List<Soldier> _soldiers = new List<Soldier>();

        public Headquarters()
        {
            Fill();
        }

        public void ShowSquadPersonnels()
        {
            var squadPersonnel = _soldiers.Select(soldier => new { Name = soldier.Name, Rank = soldier.Rank });
            int maxNameLenght = _soldiers.Max(soldier => soldier.Name.Length);
            int maxRankLenght = _soldiers.Max(soldier => soldier.Rank.Length);

            foreach (var soldier in squadPersonnel)
                Console.WriteLine($"{{0, -{maxNameLenght}}} - {{1, -{maxRankLenght}}}", soldier.Name, soldier.Rank);
        }

        private void Fill()
        {
            _soldiers.Add(new Soldier("Виталий", "Абакан", "Cтарший лейтенант", 36));
            _soldiers.Add(new Soldier("Александр", "Люгер", "Майор", 48));
            _soldiers.Add(new Soldier("Рембо", "Мачете", "Засекречено", 99));
            _soldiers.Add(new Soldier("Дмитрий", "ПКМ", "Подполковник", 68));
            _soldiers.Add(new Soldier("Петр", "АК-74М", "Рядовой", 7));
        }
    }

    class Soldier
    {
        public Soldier(string name, string weapon, string rank, int service)
        {
            Name = name;
            Weapon = weapon;
            Rank = rank;
            Service = service;
        }

        public string Name { get; private set; }
        public string Weapon { get; private set; }
        public string Rank { get; private set; }
        public int Service { get; private set; }
    }
}
