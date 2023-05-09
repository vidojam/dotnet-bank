public class bankAccount {
  // tyoe of checking account
  private double balance = 0;

  // constructor
  public bankAccount(double newBalance) {
    if (newBalance < 0) {
      throw new Exception ("no negative values");
    }
    balance = newBalance;
  } 

  // create a new checking account that inherits from the bankAccount "parent" class
  public double withdraw (double amount) {
    if (balance - amount < 0) {
        throw new Exception("No negative Values");
    };
    balance = balance - amount;
    return balance;
  }
  
  public double deposit(double amount) {
    balance = balance +=amount;
    return balance;
  }

  // method to get the balance
  public double getBalance() {
    return balance;
  }
}

