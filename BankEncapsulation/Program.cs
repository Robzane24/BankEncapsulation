namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much money would you like to deposit?");

            var depositAmount = double.Parse(Console.ReadLine());

            account.Deposit(depositAmount);

            Console.WriteLine($"Your balance is now {account.GetBalance()}");
        }
    }
}
