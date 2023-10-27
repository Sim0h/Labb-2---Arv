using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Tax : Hund
    {
        public string Gender;
        public Tax(string name = "Okänt", int age = 0, string art = "Okänt", string eats = "Okänt", double weight = 0, string breed = "Okänt", string gender = "Okänt") : base(name, age, art, eats, weight, breed)
        {
            Gender = gender;
        }

        public override void makeSound()
        {
            Console.WriteLine($"Hunden {Name} säger woff woff woff! ");
        }
        
        public void Leka(int minuter)
        {
            Console.WriteLine($"Hunden {Name} vill gärna leka i {minuter}min!");
        }
    }
}
