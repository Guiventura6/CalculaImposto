namespace CalculaImposto.Enitites
{
    class Company : TaxPayers
    {

        public int NumberOfEmployee { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployee) : base(name, anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double TaxesPaid()
        {
            if (NumberOfEmployee > 10)
                return AnualIncome * 14.0 / 100.0;
            else
                return AnualIncome * 16.0 / 100.0;
        }
    }
}
