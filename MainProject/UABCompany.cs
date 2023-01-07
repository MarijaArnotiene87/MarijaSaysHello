namespace MainProject
{
    public class UABCompany : Company
    {
        private string ownerName;

        public UABCompany(string name, int year, string vatNumber, string ownerName) : base(name, year, vatNumber)
        {
            this.ownerName = ownerName;
        }

        public override void PrintCompanyEmployeesCountByCity(string city)
        {
            base.PrintCompanyEmployeesCountByCity(city);
            Console.WriteLine("Counting done");
            Console.WriteLine();
        }

        public override string GetCompanyInfo() => base.GetCompanyInfo() + $" and owner name {ownerName}";

        public new void PrintCompanyName() => Console.WriteLine($"Company hidden name is {Name}");
    }
}
