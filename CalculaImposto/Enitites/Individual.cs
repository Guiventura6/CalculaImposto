namespace CalculaImposto.Enitites
{
    class Individual : TaxPayers
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            double tax, healthDisc = 0;
            if (AnualIncome < 20000.00)
                tax = AnualIncome * 15.0 / 100.0;
            else
                tax = AnualIncome * 25.0 / 100.0;

            if (HealthExpenditures > 0)
            {
                healthDisc = HealthExpenditures * 50.0 / 100.0;
            }

            return tax - healthDisc;
        }
    }
}
