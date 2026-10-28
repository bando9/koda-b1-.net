public class Account(string accountNumber, string ownerName, int balance)
{
    // Property 
    public string AccountNumber { get; set; } = accountNumber;
    public string OwnerName { get; set; } = ownerName;
    public int Balance { get; set; } = balance;


    public String GetInformation()
    {
        return $"Balance: {Balance}";
    }
}