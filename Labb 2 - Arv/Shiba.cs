using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Shiba : Hund
    {
        public string Colour;
        public Shiba(string name = "Okänt", int age = 0, string art = "Okänt", string eats = "Okänt", double weight = 0, string breed = "Okänt", string colour = "Okänt") : base(name, age, art, eats, weight, breed)
        {
            Colour = colour;
        }

        public override void makeSound()
        {
            Console.WriteLine($"Hunden {Name} säger Wooooooff! ");
        }

        public void takeANap()
        {
            Console.WriteLine($"Hunden {Name} vill gärna ta en tupplur");
        }

       
       
    }
}
