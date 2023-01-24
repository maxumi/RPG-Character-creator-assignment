class Program
{
    static void Main(string[] args)
    {//creates 1 Character.
        CharacterSheet Char1 = new();
    }
    class CharacterSheet
    {
        public CharacterSheet()
        {
            int roll = 1;
            while (roll == 1)
            {//makes a loop which generates a Character.
                Name = NameGenrator();
                characterClass = RandomClass();
                Race = RaceGenerator();
                Level = LevelGenerator();
                Birthday = CalculateAge();
                ShowCharacter();
                string anws = Console.ReadLine();
                if (anws == "End"||anws =="end")
                {
                    roll = 2;//"Ends the program"
                }
                Console.Clear();
            }

        }
        private static string[] CharacterClass = { "Fighter", "Wizard","Rogue","Bard"};
        private static string[] CharacterRace = { "Human", "Dwarf", "Elf", "Halfling" };
        public void ShowCharacter()
        {

                Stats stats = new();//Gets stats from "Stats"
                stats.Strength = stats.RollDice();
                stats.Dexterity = stats.RollDice();
                stats.Constitution = stats.RollDice();
                stats.Intelligence = stats.RollDice();
                stats.Wisdom = stats.RollDice();
                stats.Charisma = stats.RollDice();
                Console.WriteLine("Name: "+Name);//writes the stats below.
                Console.WriteLine("Class: "+characterClass+" "+Level);
                Console.WriteLine("Race: " + Race);
                Console.WriteLine("\nStats:\n");
                Console.WriteLine("Strength: " + stats.Strength);
                Console.WriteLine("Dexterity: " + stats.Dexterity);
                Console.WriteLine("Constitution: " + stats.Constitution);
                Console.WriteLine("Intelligence: " + stats.Intelligence);
                Console.WriteLine("Wisdom: " + stats.Wisdom);
                Console.WriteLine("Charisma: " + stats.Charisma);
                Console.WriteLine("\nBirthDay: " + Birthday.ToString("dd/MM/yyyy"));//Removes some of the exess Time.

                Console.WriteLine("\nWrite \"End\" to end the program.");
            
        }
        public string Name { get; set; }
        public string NameGenrator()
        {
            Random random = new();
            string[] NameList = { "John", "Karl", "Dawi", "Husik", "Bjørn", "Jon-Gold", "Hel", "Skur", "Susan"};
            string nameRand =NameList[random.Next(NameList.Length)];
            return nameRand;
        }
        public string characterClass { get; set; }
        public string RandomClass()
        {
            Random random = new();
            string ranClass = CharacterClass[random.Next(CharacterClass.Length)];
            return ranClass;
        }
        public string Race { get; set; }
        public string RaceGenerator()
        {
            Random random = new();
            string RanRace = CharacterRace[random.Next(CharacterRace.Length)];
            return RanRace;
        }
        public int Level { get; set; }
        public int LevelGenerator()
        {
            Random random = new();
            int LevelRan = random.Next(1, 20);
            return LevelRan;
        }
        public DateTime Birthday { get; set; }
        public DateTime CalculateAge()
        {
            Random random = new();
            int year = random.Next(1960, 2012);
            int month = random.Next(1, 13);
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);
            DateTime Birth = new DateTime(year, month, day);


            return Birth;
        }
         public class Stats
        {
          public int Strength { get; set; }
          public int Dexterity { get; set; }
          public int Constitution { get; set; }
          public int Intelligence { get; set; }
          public int Wisdom { get; set; }
          public int Charisma { get; set; }
          
          public int RollDice()
            {
                Random random = new ();
                int DieRoll= random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                return DieRoll;
            }
        }
    }
}