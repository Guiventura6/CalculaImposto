using System;
using System.Globalization;
using CalculaImposto.Enitites;

namespace CalculaImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            TaxPayers taxPayers = new Individual("Joao", 50000.00, 2000.00);

            Console.WriteLine(taxPayers.Name); 
            Console.WriteLine(taxPayers.AnualIncome); 
            Console.WriteLine(taxPayers.TaxesPaid().ToString("F2", CI)); 


        }
    }
}
