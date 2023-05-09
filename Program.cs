 

// Console.WriteLine("Hello, World!");

// int age = 26;
// string name = "Damian";
// bool isHere = true;
// double salary = 22000.01;


// // Console.WriteLine("Your age is " + age);
// Console.WriteLine($" hi {name} Your age is {age} and is {isHere}");
// Console.WriteLine($"And you make ${salary} a year");

try
{
savingsAccount myAccount 
= new savingsAccount (300);

// myAccount.balance = 300;

Console.Write($"Your balance is ");
Console.Write(myAccount.getBalance());

Console.WriteLine(" and your're good looking");

} catch (Exception ex) {
  Console.WriteLine($"We got an error: {ex.Message}");
}

public class checkingAccount : bankAccount {

  public checkingAccount (double initialBalance): base(initialBalance) {

  }
   
} 
public class savingsAccount : bankAccount {

  public savingsAccount (double initialBalance): base(initialBalance) {
    this.deposit (100);
  }
   
} 