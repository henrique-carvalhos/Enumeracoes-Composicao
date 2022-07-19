using System;
using System.Collections.Generic;
using System.Globalization;
using Composição.Entities;
using Composição.Entities.Enums;

namespace Composição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            //Recebendo uma string e convertendo para um tipo Enum.
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level;
            Enum.TryParse<WorkerLevel>(Console.ReadLine(), out level);

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instânciando uma variável do tipo Department que receberá o valor da variável deptName.
            Department department = new Department(deptName);

            //Instânciando uma variável do tipo Worker que receberá os valores das variáveis name, level, salary, department.
            Worker worker = new Worker(name, level, salary, department);

            Console.Write("How many contracts to this woker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                //Intânciando um contrato
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //Adicionando o contrato ao trabalhador
                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
