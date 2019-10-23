using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        class Hotel
        {
            public double PerDay { get; set; }
            public int NumberDay { get; set; }
            public string Season { get; set; }
            public string Discountypes { get; set; }
            public void createbill()
            {
                switch (Season)
                {
                    case "Summer":
                        if (Discountypes == "VIP")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 4 * 0.8));
                        }
                        if (Discountypes == "SecondVisit")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 4 * 0.9));
                        }
                        if (Discountypes == "")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 4));
                        }
                        break;
                    case "Autumn":
                        if (Discountypes == "VIP")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 1 * 0.8));
                        }
                        if (Discountypes == "SecondVisit")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 1 * 0.9));
                        }
                        if (Discountypes == "")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 1));
                        }
                        break;
                    case "Spring":
                        if (Discountypes == "VIP")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 2 * 0.8));
                        }
                        if (Discountypes == "SecondVisit")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 2 * 0.9));
                        }
                        if (Discountypes == "")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 2));
                        }
                        break;
                    case "Winter":
                        if (Discountypes == "VIP")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 3 * 0.8));
                        }
                        if (Discountypes == "SecondVisit")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 3 * 0.9));
                        }
                        if (Discountypes == "")
                        {
                            Console.WriteLine("Per of day {0} Number of days {1} in {2} with {3} account = ${4}", PerDay, NumberDay, Season, Discountypes, (PerDay * NumberDay * 3));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        
        class Student : IComparable<Student>
        {
            public string name { get; set; }
            public int age { get; set; }
            public double grade { get; set; }
            public Student(string _name, int _age, double _grade)
            {
                name = _name;
                age = _age;
                grade = _grade;
            }

            int IComparable<Student>.CompareTo(Student other)
            {

                throw new NotImplementedException();
            }
        }
        static void PrintRow(int r)
        {
            for (int i = 0; i <= r; i++)
            {
                for (int j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (int i = r - 1; i >= 1; i--)
            {
                for (int j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
        static bool Contains(int x, int y, int x1, int y1, int x2, int y2)
        {
            if (x > x1 && x < x2 && y > y1 && y < y2)
                return true;
            return false;
        }
        
        static void Main(string[] args)
        {
            
            int input;
            Console.WriteLine("Enter your request:");
            Console.WriteLine("    1. Draw rhombus...");
            Console.WriteLine("    2. Point in Rectangle...");
            Console.WriteLine("    3. Student System...");
            Console.WriteLine("    4. Hotel Reservation...");
            input = Convert.ToInt32(Console.ReadLine());
            List<Student> list = new List<Student>();
            list.Add(new Student("Nguyen Cong Nhat", 18, 9.0));
            list.Add(new Student("Nguyen Tat Thang", 18, 5.5));
            while (input != 5)
            {
                if (input >5 || input <0)
                {
                    Console.WriteLine("Invalid Conmmand");
                }
                else
                {
                    switch (input)
                    {
                        case 1:
                            int n;
                            Console.WriteLine("Enter Edge length of rhombus: ");
                            n = int.Parse(Console.ReadLine());
                            PrintRow(n);
                            break;
                        case 2:
                            int x, y, x1, x2, y1, y2;
                            Console.WriteLine("Find point in rectangle...");
                            Console.WriteLine("Enter x: ");
                            x = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter y: ");
                            y = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter x1, x2, y1, y2");
                            x1 = Convert.ToInt32(Console.ReadLine());
                            x2 = Convert.ToInt32(Console.ReadLine());
                            y1 = Convert.ToInt32(Console.ReadLine());
                            y2 = Convert.ToInt32(Console.ReadLine());
                            if (Contains(x, y, x1, y1, x2, y2))
                                Console.WriteLine("True");
                            else
                                Console.WriteLine("False");
                            break;
                        case 3:
                            string fb = "";
                            foreach (Student stu in list)
                            {
                                if (stu.grade > 5 && stu.grade <= 7 )
                                {
                                    fb = "Average";
                                }
                                if (stu.grade > 7)
                                {
                                    fb = "Excillent";
                                }
                                Console.WriteLine("Student {0} {1} years old. {2} student.", stu.name, stu.age, fb);
                            }
                            break;
                        case 4:
                            List<Hotel> bill = new List<Hotel>();
                            Console.WriteLine("===Create bill in hotel====");
                            Console.WriteLine("Enter number bill wants to create:");
                            int sobill = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < sobill; i++)
                            {
                                Console.WriteLine("ID {0}: ", (i + 1));
                                bill.Add(new Hotel());
                                Console.WriteLine("Price per day:");
                                bill[i].PerDay = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Number of days:");
                                bill[i].NumberDay = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Season:");
                                bill[i].Season = Console.ReadLine();
                                Console.WriteLine("Discount Types:");
                                bill[i].Discountypes = Console.ReadLine();
                                Console.WriteLine("Successfull");
                                Console.WriteLine("=============");
                            }
                            
                            foreach (Hotel lastbill in bill)
                            {
                                lastbill.createbill();
                                Console.WriteLine("==============");
                            }
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }
                    if (input == 5) break;
                }
                Console.WriteLine("Enter your request:");
                Console.WriteLine("    1. Draw rhombus...");
                Console.WriteLine("    2. Point in Rectangle...");
                Console.WriteLine("    3. Student System...");
                Console.WriteLine("    4. Hotel Reservation...");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
