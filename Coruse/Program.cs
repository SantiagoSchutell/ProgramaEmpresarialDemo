using System;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using Coruse.Enitities;
using Coruse.Enitities.Enums;



namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament' s name: ");
            string deptName = Console.ReadLine();
            Console.Write("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level Junior/MidLevel/Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level , baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
             
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, ValuePerHour, hours);

                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate incime (MM/YYYY): ");
            string monthAndyear = Console.ReadLine();
            int month = int.Parse(monthAndyear.Substring(0, 2));
            int year = int.Parse(monthAndyear.Substring(3));

            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Departament: "+worker.Departament.Name);
            Console.WriteLine("Income for: "+monthAndyear+": "+worker.InCome(year, month));




        }
    }
}