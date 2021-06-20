using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string city;
            Member member = null;
            int choice;
            do
            { //Enter name;
                do
                {
                    Console.WriteLine("Enter the member  name  : ");
                    name = Console.ReadLine();
                    if (name.Length < 6 || name.Length > 40)
                    {
                        Console.WriteLine("Ten thanh vien khong hop le : ");
                    }
                } while (name.Length < 6 || name.Length > 40);
                //Enter  age;
                bool check;
                do
                {
                    Console.WriteLine("Enter the age of the member : ");
                   
                     check = int.TryParse(Console.ReadLine(), out age);
                    if (!check)
                    {
                        Console.WriteLine("Dinh dang tuoi ko hop le ");
                    }
                    if (age <= 6)
                    {
                        Console.WriteLine("Tuoi phai tu 6 tro len ");
                    }

                } while ( !check || age <= 6);
             //Enter city;

                do
                {
                    Console.WriteLine("Enter the city  : ");
                    city = Console.ReadLine();
                    if (city.Length < 4)
                    {
                        Console.WriteLine("Ten thanh pho khong hop le : ");
                    }
                } while (city.Length < 4);
                menu();
                do
                {
                    Console.WriteLine("Enter your choice : ");

                } while (!int.TryParse(Console .ReadLine(), out choice));

                switch (choice)
                {
                    case 1:
                         member = new Member() { name = name, age = age, city = city };
                        Console.WriteLine("Name\tAge\t\tCity\tProfession\t\tMembership Fee\t");
                        Console.WriteLine(student(member));
                        break;
                    case 2:
                         member = new Member() { name = name, age = age, city = city };
                        Console.WriteLine("Name\tAge\t\tCity\tProfession\t\tMembership Fee\t");
                        Console.WriteLine(Teacher(member));
                        break;
                    case 3:
                        member = new Member() { name = name, age = age, city = city };
                        Console.WriteLine("Name\tAge\t\tCity\tProfession\t\tMembership Fee\t");
                        Console.WriteLine(Retired(member));
                        break;
                    case 4:
                        member = new Member() { name = name, age = age, city = city };
                        Console.WriteLine("Name\tAge\t\tCity\tProfession\t\tMembership Fee\t");
                        Console.WriteLine(Other(member));
                        break;

            
                    default:
                        Console.WriteLine("Invalid choice : ");
                        break;
                }

                Console.WriteLine(" Do you want to exit the program  Yes (Y) or No(N) ");
                string exit = Console.ReadLine();
                if (exit.StartsWith("Y") || exit.StartsWith("y")){
                    Environment.Exit(0);
                }
                
                    
            } while (true);

            Console.ReadKey();
        }
        static void menu()
        {
            Console.WriteLine("Select your profession :");
            Console.WriteLine("1. Student :");
            Console.WriteLine("1. Teacher :");
            Console.WriteLine("1. Retired :");
            Console.WriteLine("1. Others :");
        }

        static string student(Member member)
        {
            member.job = "student";
            member.fee = 1000;
            return member.display();
        }
        static string Teacher(Member member)
        {
            member.job = "Teacher";
            member.fee = 1400;
            return member.display();
        }
        static string Retired(Member member)
        {
            member.job = "Retired";
            member.fee = 1500;
            return member.display();
        }
        static string Other(Member member)
        {
            member.job = "Other";
            member.fee = 2000;
            return member.display();
        }

    }
}

