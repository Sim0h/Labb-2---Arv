using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Panter : Djur
    {
        public string Gender;

        public Panter(string name = "Okänt", int age = 0, string art = "Okänt", string eats = "Okänt", double weight = 0, string gender = "Okänt") : base(name, age, art, eats, weight)
        {
            Gender = gender;
        }

        public override void makeSound()
        {
            Console.WriteLine("Pantern säger ROAAAR!");
        }

        public override void animalInfo()
        {
            base.animalInfo();
            Console.WriteLine($"Pantern {Name} är av könet: {Gender}.");
        }

        public override void isItAPet()
        {
            Console.WriteLine("Pantern är inte ett husdjur.");
        }

        public void Dangerous()
        {
            Console.WriteLine($"Pantern {Name} är farlig.");
        }
    }
}
