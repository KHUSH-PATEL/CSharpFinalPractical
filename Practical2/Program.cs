namespace Banking
{
    class Customer_Account
    {
        string bank_name = "SBI";
        string customer_name;
        long customer_accountNo;

        public Customer_Account(long customer_accountNo, string customer_name)
        {
            this.customer_accountNo = customer_accountNo;
            this.customer_name = customer_name;
            printInfo();
        }
        /// <summary>
        /// This method prints the details of the customers.
        /// It Display bank name, customer account number and Customer name.
        /// </summary>
        public void printInfo()
        {
            Console.WriteLine("Bank name is {0}", bank_name);
            Console.WriteLine("Customer Account number is {0}", customer_accountNo);
            Console.WriteLine("Customer Name is {0}", customer_name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer_Account ca1 = new Customer_Account(123456789, "Khush");
        }
    }
}