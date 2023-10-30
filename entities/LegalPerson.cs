namespace abstrationFuction.entities
{
    public class LegalPerson : Taxpayer
    {
        public int Employees { get; set; }

        public LegalPerson(){}
        public LegalPerson(string name, double yearIncome, int employees) : base(name, yearIncome)
        {
            Employees = employees;
        }
    }
}