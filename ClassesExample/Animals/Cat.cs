using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Cat
    {
        public CatColor Color { get; set; }

        public bool isFeral { get; set; }

        public Chicken BestFriend { get; set; }

        public void Dye(CatColor color)
        {
            Color = color;
        }

        public void HaveASnack()
        {
            Console.WriteLine($"the {Color} cat took a bite of {BestFriend.Name}. Oops.");
            BestFriend.Peck($"The {Color} cat.");
        }
    }

    enum CatColor
    {
        Orange = 1,
        Grey,
        Black,
        Calico,
        Tabby,
        White
    }
}
