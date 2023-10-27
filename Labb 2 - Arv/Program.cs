namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Hund hund = new Hund("Pepsi", 5, "Hund", "Torrfoder", 30, "Golden Retriever");
            Katt katt = new Katt("Findus", 12, "Katt", "Möss", 5, "Ja");
            Panter panter = new Panter("Shadow", 3, "Svart Panter", "Kött", 110, "Hona");
            Tax tax = new Tax("Sansa", 5, "Hund", "Torrfoder", 12, "Tax", "Hona");
            Shiba shiba = new Shiba("Mojo", 8, "Hund", "Torrfoder", 10, "Shiba", "Orange");



            hund.animalInfo();
            hund.makeSound();
            hund.Busig();
            Console.WriteLine();

            katt.animalInfo();
            katt.makeSound();
            katt.Fluffy();
            Console.WriteLine();

            panter.animalInfo();
            panter.makeSound();
            panter.Dangerous();
            Console.WriteLine();

            tax.animalInfo();
            tax.makeSound();
            tax.Leka(60);
            tax.Busig();
            Console.WriteLine();

            shiba.animalInfo();
            shiba.makeSound();
            shiba.Busig();
            shiba.takeANap();


        }
    }
}