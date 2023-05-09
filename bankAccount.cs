public class bankAccount
{
    private double balance = 0;

    //constructor
    public bankAccount(double newBalance)
    {
        if(newBalance < 0)
        {
            throw new Exception("No negative Values");
        }

        balance = newBalance;
    }

    public double withdraw(double amount)
    {
        balance = balance - amount;
        return balance;
    }


     public double deposit(double amount)
    {
        balance = balance + amount;
        return balance;
    }

    //method to get the balance
    public double getBalance()
    {
        return balance;
    }
    
}

// created a new checking account that inherits from the bankAccount "parent" - method is called "base" class
public class checkingAccount : bankAccount 
{

    public checkingAccount(double initialBalance) : base(initialBalance)
    {

    }

}
