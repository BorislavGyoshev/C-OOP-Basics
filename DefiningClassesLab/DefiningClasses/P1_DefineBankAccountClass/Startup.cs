using System;
using System.Collections.Generic;

class Startup
{
    static void Main()
    {
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var cmdArgs = input.Split();
            switch (cmdArgs[0])
            {
                case "Create": Create(cmdArgs, accounts); break;
                case "Deposit": Deposit(cmdArgs, accounts); break;
                case "Withdraw": Withdrow(cmdArgs, accounts); break;
                case "Print": Print(cmdArgs, accounts); break;
            }
        }
    }

    private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdrow(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var amound = double.Parse(cmdArgs[2]);
        if (accounts.ContainsKey(id))
        {
            if (accounts[id].Balance < amound)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Withdraw(amound);
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var amound = double.Parse(cmdArgs[2]);
        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(amound);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id, acc);
        }
    }
}
