using System;
using System.IO;

namespace EpicBattle
{
    class Program
    {



        static void Main(string[] args)
        {
            //string[] heroes = { "Harry Potter", "Superman", "Luke Skywalker", "Lara Croft" };
            //string[] villains = { "Voldemort", "Joker", "Venom", "Dart Vaider", "Cruella" };
            string folredPath = @"C:\Users\opilane\samples\";
            string[] heroes = GetDataFromFile(folredPath+"heroes.txt");
            string[] villains = GetDataFromFile(folredPath+"villains.txt");
            string[] heroeWeapon = GetDataFromFile(folredPath + "weapon.txt");
            string[] villainWeapon = GetDataFromFile(folredPath + "weapon.txt");

            string randomHero = GetRandomCharacter(heroes);
            string randomVillain = GetRandomCharacter(villains);
            string heroeWeapon = GetRandomCharacter(heroeWeapon);
            string villainWeapon = GetRandomCharacter(villainWeapon);
            
            Console.WriteLine($"Your first fighter is >>> {randomHero}");
            Console.WriteLine($"Your second fighter is >>> {randomVillain}");
            Console.WriteLine($"{randomHero} with {heroeWeapon} will fight {randomVillain} with {villainWeapon}")

        }
        public static string GetRandomCharacter(string[] someArray)
        {

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomCharacter = someArray[randomIndex];
            return randomCharacter;


        }
        public static string[] GetDataFromFile(string filePath) {
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;

        }
    }  
}
