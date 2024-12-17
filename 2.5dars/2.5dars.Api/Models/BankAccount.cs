namespace _2._5dars.Api.Models;

public class BankAccount
{
    private string _accountNumber;

    public string AccountNumber
    {
        get { return _accountNumber; }
    }
    private double _balance;

    public double Balance
    {
        get { return _balance; }
    }

    public void Deposite(double amount)
    {
        _balance += amount;

    }
}
