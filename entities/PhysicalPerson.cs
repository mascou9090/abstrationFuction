namespace abstrationFuction.entities
{
    public class PhysicalPerson : Taxpayer
    {
        public double HealthSpending { get; set; }

        public PhysicalPerson(){}
        public PhysicalPerson(string name, double yearIncome, double healthSpending) : base(name,yearIncome)
        {
           HealthSpending = healthSpending; 
        }
    }
}