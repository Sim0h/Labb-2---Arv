using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Djur
    {
        public string Name;
        public int Age;
        public string Art;
        public string Eats;
        public double Weight;

        public Djur(string name, int age, string art, string eats, double weight)
        {
            Name = name;
            Age = age;
            Art = art;
            Eats = eats;
            Weight = weight;
        }

        public virtual void makeSound()
        {
            Console.WriteLine("Djuret gör ett ljud");
        }
        public virtual void animalInfo()
        {
            Console.WriteLine($"Djuret heter {Name} och är {Age} år gammal.\nDjuret är en {Art}.\nDen äter {Eats} och väger {Weight} kg");
        }

        public virtual void isItAPet()
        {
            Console.WriteLine("Djuret är ett husdjur eller inte");
        }
    }
}
