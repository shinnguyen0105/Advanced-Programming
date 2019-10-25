using System;

namespace Encapsulation
{
    public class Chicken
    {
        private string name;
        private int age;
        private string gender;
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
            get { return this.gender; }
            set { this.gender = value; }
        }
        public void Get_infor()
        {
            Console.WriteLine($"{Name} is {Age} day - Gender: {Gender}.");
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Chicken mychicken = new Chicken();
            mychicken.Name = "Chicken_Black";
            mychicken.Age = 10;
            mychicken.Gender = "F";
            mychicken.Get_infor();
            Console.ReadKey();
        }
    }
}
