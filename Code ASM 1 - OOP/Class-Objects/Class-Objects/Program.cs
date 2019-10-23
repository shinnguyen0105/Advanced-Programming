using System;

namespace Class_Objects
{
    class Animals
    {
        public string name;
        public int age;
        public string gender;
        public void setname(string Name)
        {
            name = Name;
        }
        public void setage(int Age)
        {
            age = Age;
        }
        public void setgender(string Gender)
        {
            gender = Gender;
        }
        public void Get_infor()
        {
            Console.WriteLine($"Name: {name} is {age} day -- Gender: {gender}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animals myanimals = new Animals();
            myanimals.setname("black Dog");
            myanimals.setage(4);
            myanimals.setgender("f");

            myanimals.Get_infor();
            Console.ReadKey();
        }
    }
}
