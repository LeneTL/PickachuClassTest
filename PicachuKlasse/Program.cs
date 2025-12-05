namespace PicachuKlasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Pikachu = new Pokemon("Pikachu", 50, 10);
            var Balbusaur = new Pokemon("Balbusaur", 60, 8);
            Console.WriteLine($"{Pikachu.Name} is Level {Pikachu.Level} and has {Pikachu.Health}Hp");
            Console.WriteLine($"{Balbusaur.Name} is Level {Balbusaur.Level} and has {Balbusaur.Health}Hp");
        }
    }
}
