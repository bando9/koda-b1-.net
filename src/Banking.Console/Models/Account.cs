public class Account
{
    // Property 
    public string AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public int Balance { get; set; } 

    public Account(string accountNumber, string ownerName, int balance)
    {
        if (String.IsNullOrWhiteSpace(accountNumber))
        {
            throw new ArgumentException("Account Number must be string");
        }
        if (String.IsNullOrWhiteSpace(ownerName))
        {
            throw new ArgumentException("Owner Name must be string");
        }
        if (balance <= 0)
        {
            throw new ArgumentException("Balance must be more than 0");
        }

        AccountNumber=accountNumber;
        OwnerName=ownerName;
        Balance=balance;
    }


    public String GetInformation()
    {
        return $"Account Number\t: {AccountNumber}\nName: {OwnerName}\nBalance: {Balance}\n";
    }
}