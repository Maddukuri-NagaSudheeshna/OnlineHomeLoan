namespace OnlineHomeLoan.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string ? Employement { get; set; }

        public string ? Organization { get; set; }

        public int MonthlyIncome { get; set; }

        public int LoanAmount { get; set; }

        public int Tenure { get; set; }

        public string ? FirstName { get; set; }

        public string ? LastName { get; set; }
        public string ? Gender { get; set; }

        public string ? DateOfBirth { get; set; }

        public int MobileNumber  { get; set; }

        public int Adhaar { get; set; }

        public int Pan { get; set; }
    }
}
