using System;
using System.Collections.Generic;
using System.Text;

namespace NetCart.ConsoleUI
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }
        protected virtual void DisplayName()
        {
            Console.WriteLine("Animal");
        }
    }

    public class Dog : Animal
    {
        public sealed override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof! Woof!");
        }

        protected override void DisplayName()
        {
            Console.WriteLine("Dog");
        }
    }

    public class puppy : Dog
    {
       
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says: Meow! Meow!");
        }
        protected override void DisplayName()
        {
            Console.WriteLine("Cap");
        }
    }


    public class RuntimePolyMorphism
    {

        public void RunDemo()
        {
            Animal myAnimal;
            Console.WriteLine("Enter D for Dog and C for Cat");
            string input = Console.ReadLine();
            if (input == "D")
            {
                myAnimal = new Dog(); //Animal is Reference Type, Dog is ObjectType
            }
            else if (input == "C")
            {
                myAnimal = new Cat(); // Cat Objet type
            }
            else
            {
                myAnimal = new Animal();
            }

            myAnimal.MakeSound(); //Call Cat Method
        }



    }
}
