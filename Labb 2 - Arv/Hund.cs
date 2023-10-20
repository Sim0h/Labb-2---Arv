using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    public class Hund : Djur
    {
        public string _Size;

        public Hund(string Colour, string Name, string Breed, int Age, int Speed, string Size) : base(Colour, Name, Breed, Age, Speed)
        {
            _Size = Size;
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
