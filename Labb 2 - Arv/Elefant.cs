using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    public class Elefant : Djur
    {
        public string _Origin;

        public Elefant(string Colour, string Name, string Breed, int Age, int Speed, string Origin) : base(Colour, Name, Breed, Age, Speed)
        {
            _Origin = Origin;
        }

        public void makeSound()
        {
            Console.WriteLine("Woff Woff!!");
        }

        public void PrintInfo()
        {

        }

    }
}
