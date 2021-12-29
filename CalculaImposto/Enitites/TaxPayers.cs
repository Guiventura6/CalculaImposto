using System.Globalization;
using System.Text;

namespace CalculaImposto.Enitites
{
    abstract class TaxPayers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}: $ {TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
