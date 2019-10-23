using System;
using System.Text;

namespace TestBuilder
{
    public class Life
    {
        public Life(string family, string friends, string money)
        {
            this.Family = family;
            this.Friends = friends;
            this.Money = money;
        }
        public string life_maxim()
        {
            return "On the way to success, there is no trace of lazy men";
        }
        public string Start()
        {
            return "So, Try hard....";
        }
        protected string GetLife()
        {
            return $"The most important things: {this.Family}  {this.Friends}  {this.Money}";
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(this.GetLife()).AppendLine(this.life_maxim()).Append(this.Start());

            return builder.ToString();
        }



        public string Family { get; }

        private string Friends { get; }

        public string Money { get; protected set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Life mylife = new Life("my family", "my friends", "Infinity");
            Console.WriteLine(mylife.ToString());
            Console.ReadKey();
        }
    }
}
