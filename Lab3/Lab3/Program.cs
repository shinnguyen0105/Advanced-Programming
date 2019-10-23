using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{

    class Program
    {
       
     
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter your request:");
            Console.WriteLine("    1. First and Reserve Team...");
            Console.WriteLine("    2. ...");
            Console.WriteLine("    3. ...");
            input = Convert.ToInt32(Console.ReadLine());
    
            while (input != 4)
            {
                if (input > 4 || input < 0)
                {
                    Console.WriteLine("Invalid Conmmand");
                }
                else
                {
                    switch (input)
                    {
                        case 1:
                            List<Person> information = new List<Person>();
                            Console.WriteLine("Nhap so luong nguoi can them: ");
                            int soluong = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < soluong; i++)
                            {
                                Console.WriteLine("ID {0}: ", (i + 1));
                                information.Add(new Person());
                                Console.WriteLine("First Name:");
                                information[i].FirstName = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("Last Name:");
                                information[i].LastName = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("Age:");
                                information[i].Age = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("=============");
                            }
                            foreach (Person printsort in information)
                            {
                                Console.WriteLine("{0} {1} is {2} years old.", printsort.FirstName , printsort.LastName, printsort.Age); 
                                Console.WriteLine("==============");
                            }
                            break;
                        case 2:
                           
                            break;
                        case 3:
                            
                            break;
                        case 4:
                            
                        case 5:
                            break;
                        default:
                            break;
                    }
                    if (input == 5) break;
                }
                Console.WriteLine("Enter your request:");
                Console.WriteLine("    1. First and Reserve Team...");
                Console.WriteLine("    2. ...");
                Console.WriteLine("    3. ...");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
