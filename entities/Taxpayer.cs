namespace abstrationFuction.entities
{
    abstract public class Taxpayer
    {
        public string Name { get; set; }
        public double YearIncome { get; set; }
        public Taxpayer() {}
        public Taxpayer(string name, double yearIncome)
        {
            Name = name;
            YearIncome = yearIncome;
        }
    }
}