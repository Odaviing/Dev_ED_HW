using System;
using System.Collections.Generic;
namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity of workers");
            int quantity_of_workers = Value_of_int(Console.ReadLine());
            List<Worker> workers = new List<Worker>();
            string name = "";
            int salary, subord;
            for (int  i = 0; i < quantity_of_workers; i++)
            {
                Console.WriteLine("Choose a new worker's position by entering a number 1-6");
                Console.WriteLine("1. Junior QA Engineer\n 2. Middle QA Engineer\n 3. Senior QA Engineer\n 4. Junior Developer\n 5. Middle Developer\n 6.Senior Developer");
                int position = Value_of_int(Console.ReadLine());
                while (position < 1 || position > 6)
                {
                    Console.WriteLine("Your choice should be from 1 to 6, try again");
                    position = Value_of_int(Console.ReadLine());
                }
                Console.WriteLine("Enter worker's name");
                name = Console.ReadLine();
                while (name == "")
                {
                    Console.WriteLine("You have to enter worker's name, try again");
                    name = Console.ReadLine();
                }
                Console.WriteLine("Enter worker's salary");
                salary = Value_of_int(Console.ReadLine());
                Console.WriteLine("Enter worker's number of subordinates");
                subord = Value_of_int(Console.ReadLine());

                Add_Worker(position, name, salary, subord, workers);
            }
            FindWorker(workers);
        }

       

        static int Value_of_int(string str)
        {
            int str_int;
            while (!Int32.TryParse(str, out str_int) || str_int < 0)
            {
                Console.WriteLine("Your value isn't a number or it's less then or equal than zero, try again");
                str = Console.ReadLine();

            }
            return str_int;
        }

        static void Add_Worker(int choice, string name, int salary, int subordinates, List<Worker> workers)
        {
            switch(choice)
            {
                case 1:
                    workers.Add(new QAJunior(name, salary, subordinates));
                    break;
                case 2:
                    workers.Add(new QAMiddle(name, salary, subordinates));
                    break;
                case 3:
                    workers.Add(new QASenior(name, salary, subordinates));
                    break;
                case 4:
                    workers.Add(new DeveloperJunior(name, salary, subordinates));
                    break;
                case 5:
                    workers.Add(new DeveloperMiddle(name, salary, subordinates));
                    break;
                case 6:
                    workers.Add(new DeveloperSenior(name, salary, subordinates));
                    break;
            }
        }

        static void FindWorker(List<Worker> workers)
        {
            Console.WriteLine("Do you want to get a information about worker?\n Press y to find a worker\n Press any other button to exit\n");
            if(Console.ReadLine().ToLower() == "y")
            {
                int counter_of_workers = 0;
                    Console.WriteLine("Enter the name of the worker\n");
                    string name = Console.ReadLine();
                    Console.WriteLine("Information about your workers:\n");
                    foreach (Worker worker in workers)
                    {
                        if (name == worker.GetName())
                        {
                            Console.WriteLine("Name: " + worker.GetName());
                            Console.WriteLine("Position: " + worker.GetPosition());
                            Console.WriteLine("Salary: " + worker.GetSalary());
                            Console.WriteLine("Number of subordinates: " + worker.GetNumberOfSubordinates());
                            Console.WriteLine("Responsibility level: " + worker.GetResponsibilityLevel());
                            Console.WriteLine();
                            counter_of_workers++;
                        }

                    }
                    if (counter_of_workers == 0)
                    {
                        Console.WriteLine("There is no worker with a such name.");
                       
                    }

            }
        }
    }

}
