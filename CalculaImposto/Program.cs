using System;
using System.Globalization;
using CalculaImposto.Enitites;
using System.Collections.Generic;

namespace CalculaImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            List<TaxPayers> list = new List<TaxPayers>();

            Console.Write("Enter the number of tax payers: ");
            int nTaxPayers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CI);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExp));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmp = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberEmp));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayers taxPayers in list)
            {
                Console.WriteLine(taxPayers.ToString());
            }
            Console.WriteLine();

        }
    }
}
