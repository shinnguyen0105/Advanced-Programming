using System;
using System.Collections.Generic;

namespace Inheritance
{
    public abstract class Animals 
    {
        private string name;
        private int age;
        private string gender;

        protected Animals(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get{return this.name;}
            set{this.name = value;}
        }
        public int Age
        {
            get{return this.age;}
            set{this.age = value;}
        }
        public string Gender
        {
            get{return this.gender;}
            set{this.gender = value;}
        }
        public virtual string MakeSound()
        {
            return string.Empty;
        }
    }
    public class Chicken : Animals
    {
        public Chicken(string name, int age, string gender) : base(name, age, gender)
        {
        }
        public override string MakeSound()
        {
            return "O o O o";
        }
        public void Getinfor()
        {
            Console.WriteLine($"{Name} is {Age} day"); 
        }
    }
    public class Dog : Animals
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }
        public override string MakeSound()
        {
            return "BauBau";
        }
        public void Getinfor()
        {
            Console.WriteLine($"{Name} is {Age} day");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chicken mychicken = new Chicken("White chicken", 5, "M");
            Dog mydog = new Dog("Shiba", 100, "F");
            mychicken.Getinfor();
            mydog.Getinfor();
            Console.ReadKey();
        }
    }
}
