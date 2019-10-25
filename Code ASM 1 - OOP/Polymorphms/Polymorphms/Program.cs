using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                this.gender = value;
            }
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Sound of animals");
        }
        public virtual void Status()
        {
            Console.WriteLine("== Information of Animal ==");
        }
    }
    public class Chicken : Animal
    {
        public Chicken(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("O o O o");
        }
        public override void Status()
        {
            Console.WriteLine("== Information of Chicken ==");
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
            Console.WriteLine("=============================");
        }
    }
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Gau gau Gau gau");
        }
        public override void Status()
        {
            Console.WriteLine("== Information of Dog ==");
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
            Console.WriteLine("=============================");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chicken mychicken = new Chicken("White chicken", 5, "M");
            Dog mydog = new Dog("Shiba", 100, "F");
            mychicken.Status();
            mychicken.MakeSound();
            mydog.Status();
            mydog.MakeSound();
            Console.ReadKey();
        }
    }
}
