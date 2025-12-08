using System;

namespace PicachuKlasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddPokemon();

        }

        static void AddPokemon()
        {
            List<Pokemon> monster = new List<Pokemon>();

            Pokemon Pikachu = new Pokemon("Pikachu", 50, 10);
            Pokemon Balbasaur = new Pokemon("Balbusaur", 60, 8);

            monster.Add(Pikachu);
            monster.Add(Balbasaur);

            Console.WriteLine("Pokemon in List:");

            foreach (Pokemon pokemon in monster)
            {
                Console.WriteLine($"{pokemon.Name} is Level {pokemon.Level} and has {pokemon.Health}Hp");
            }
        }
    }
}
