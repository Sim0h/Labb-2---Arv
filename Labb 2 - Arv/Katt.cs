using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Katt : Djur
    {
        public string Claws;

        public Katt(string name = "Okänt", int age = 0, string art = "Okänt", string eats = "Okänt", double weight = 0, string claws = "Okänt") : base(name, age, art, eats, weight)
        {
            Claws = claws;
        }

        public override void makeSound()
        {
            Console.WriteLine("Katten säger mjauuuu!");
        }

        public override void animalInfo()
        {
            base.animalInfo();
            Console.WriteLine($"Har {Name} klor? {Claws}");
        }

        public override void isItAPet()
        {
            Console.WriteLine("Katten är ett husdjur.");
        }

        public void Fluffy()
        {
            Console.WriteLine($"Katten {Name} är fluffig.");
        }
    }
    
    


}
