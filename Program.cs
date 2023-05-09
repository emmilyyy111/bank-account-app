// Console.WriteLine("Emily is great");
// int age = 26;

// string name = "Emily";

// bool isHere = true;

// double salary = 22000.01;

// Console.WriteLine($"My name is {name} and my age is {age}? {isHere}");
// Console.WriteLine($"And you make {salary} a year");

try {
checkingAccount myAccount 
= new checkingAccount(300);
// myAccount.balance = 300;

Console.Write("your balance is ");
Console.Write(myAccount.getBalance());
Console.WriteLine($" and your good looking");
} catch (Exception ex)
{
    Console.WriteLine($"We got an error: {ex.Message}");
}