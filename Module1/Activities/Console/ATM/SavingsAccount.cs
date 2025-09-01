public class SavingsAccount : BankAccount
{
    public SavingsAccount(string accNo, double bal, string pin) : base(accNo, bal, pin) { }

    public void AddInterest()
    {
        Console.WriteLine("Interest added for savings account.");
    }
}
