using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Hund : Djur
    {
        public string Breed;

        public Hund(string name = "Okänt", int age = 0, string art = "Okänt", string eats = "Okänt", double weight = 0, string breed = "Okänt") : base(name, age, art, eats, weight)
        {
            Breed = breed;
        }

        public override void makeSound()
        {
            Console.WriteLine("Hunden säger Woff Woff!");
        }

        public override void animalInfo()
        {
            base.animalInfo();
            Console.WriteLine($"Hunden {Name} är av rasen : {Breed}.");
        }

        public override void isItAPet()
        {
            Console.WriteLine("Hunden är ett husdjur.");
        }

        public void Busig()
        {
            Console.WriteLine($"Hunden {Name} är busig.");
        }
    }
}
