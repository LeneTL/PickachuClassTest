namespace PicachuKlasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Pikachu = new Pokemon { Name= "Pikachu", Health = 50, Level = 10};
            
            Console.WriteLine($"{Pikachu.Name} is Level {Pikachu.Level} and has {Pikachu.Health}Hp");
        }
    }
}
