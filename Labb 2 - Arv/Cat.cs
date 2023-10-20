using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    public class Cat : Djur
    {
        public bool _Claws;

        public Cat(string Colour, string Name, string Breed, int Age, int Speed, bool Claws) : base(Colour, Name, Breed, Age, Speed)
        {
            _Claws = Claws;
        }

        public void makeSound()
        {
            Console.WriteLine("The cat Meows! ");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Djuret är en {_Breed}. Den heter {_Name}, är {_Age} år gammal och är {_Colour} färgad.\n Djuter springer i {_Speed} kM/h.\nHar djuret klor? {_Claws}");
        }
    }
}
