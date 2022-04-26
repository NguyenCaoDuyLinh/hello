﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt26_4
{
    public abstract class Animal
    {
        public abstract void makeSound();
        public virtual void Eat()
        {
            Console.WriteLine("Động vật ăn cỏ");
        }
        public void Run()
        {
            Console.WriteLine("Chạy bằng 4 chân");
        }
    }
    public class Cat : Animal
    {
        
        public override void makeSound()
        {
            Console.WriteLine("Mèo meow meow.");
        }
        
        public override void Eat()
        {
            Console.WriteLine("Mèo ăn cá.");
        }
        public void Run()
        {
            Console.WriteLine("Chạy bằng 4 chân");
        }

    }
    
    public class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bay nhu chim");
        }
        public override void Eat()
        {
            Console.WriteLine("Chim an gi?");
        }

        public override void makeSound()
        {
            Console.WriteLine("ec' ec'");
        }
    }
    public static void main(string[] args)
    {

        Cat cat134 = new Cat();

        Bird bird134 = new Bird();

        cat134.Run();
        bird134.Fly();

        Console.ReadKey();
    }
}
