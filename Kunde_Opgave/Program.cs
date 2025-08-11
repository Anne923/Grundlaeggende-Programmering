namespace Kunde_Opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "John";
            Console.WriteLine(customer.FirstName);

            Customer customer2 = new Customer("Jane");
            Console.WriteLine(customer2);
        }
    }
}
