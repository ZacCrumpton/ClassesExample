using ClassesExample.Animals;
using System;

namespace ClassesExample
{
    class program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken("Liza");
            var bob = new Chicken("bob");

            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");


            bob.Peck();

            Console.WriteLine($"{chicken.Name} and {bob.Name} are chickens");

            var llama = new Llama(3, "brown");
            llama.Dye("Teal");

            var cat = new Cat();
            cat.Color = CatColor.Tabby;
            cat.BestFriend = bob;

            cat.HaveASnack();

            Console.WriteLine($"this cat is {cat.Color}");
        }
    }
}
