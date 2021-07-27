using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sets admin password
            string adminPass = "Password"; 
           
            // Sets user balance to a number
            int jormaBal = 12980;           
            int petriBal = 56240;            
            int turskaBal = 17594730;
            
            // Sets Password for user

            string jormaPass = "AwkwardOtters83";
            string petriPass = "FunnyDoge51";
            string turskaPass = "CuteCats12";

            Console.WriteLine("Welcome! Please insert your ID number to proceed: ");
            int userId = Convert.ToInt32(Console.ReadLine());
            
            // Uses predefined userId to gain access to different values
            switch (userId)
            {
                case 123456:
                    Console.WriteLine("Please input your password:");
                    jormaPass = Console.ReadLine();
                    if (jormaPass != "AwkwardOtters83")
                    {
                        Console.WriteLine("Password is incorrect try again");
                        Console.ReadKey();
                    }
                    if (jormaPass == "AwkwardOtters83")
                    {
                        Console.WriteLine("Hello, Jorma what would you like to do today?");
                        string userAction = Console.ReadLine();
                       
                        // What the user wants to do with their predefined balance
                        switch (userAction)
                        {
                            case "balance":
                                Console.Write("Your current balance is " + jormaBal);
                                Console.ReadKey();
                                break;
                            case "deposit":
                                Console.WriteLine("How much would you like to deposit");
                                int jormaDep = Convert.ToInt32(Console.ReadLine());
                                if (jormaDep < 401)
                                {
                                    int jormaTotal = Convert.ToInt32(jormaBal + jormaDep);
                                    Console.WriteLine("Your total balance is now " + jormaTotal);
                                    Console.ReadKey();

                                }
                                else
                                {
                                    Console.WriteLine("Error: Ammount is too large to deposit try again.");
                                    Console.ReadKey();
                                }
                                break;
                            case "withdraw":
                                Console.WriteLine("How much would you like to withdraw?");
                                int jormaWith = Convert.ToInt32(Console.ReadLine());
                                if (jormaWith == 10)
                                {
                                    Console.WriteLine("10e has been withdrawn from your account");
                                    jormaBal = Convert.ToInt32(jormaBal - jormaWith);
                                    Console.WriteLine("Your remaining balance is " + jormaBal);
                                    Console.ReadKey();
                                }
                                if (jormaWith == 20)
                                {
                                    Console.WriteLine("20e has been withdrawn from your account");
                                    jormaBal = Convert.ToInt32(jormaBal - jormaWith);
                                    Console.WriteLine("Your remaining balance is " + jormaBal);
                                    Console.ReadKey();
                                }
                                if (jormaWith == 50)
                                {
                                    Console.WriteLine("50e has been withdrawn from your account");
                                    jormaBal = Convert.ToInt32(jormaBal - jormaWith);
                                    Console.WriteLine("Your remaining balance is " + jormaBal);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("That ammount is not possible to withdraw try again.");
                                    Console.ReadKey();
                                }
                                break;
                        }
                    }
                    break;

                case 270721:
                    Console.WriteLine("Please input your password:");
                    petriPass = Console.ReadLine();
                    if (petriPass != "FunnyDoge51")
                    {
                        Console.WriteLine("Password is incorrect try again");
                        Console.ReadKey();
                    }
                    if (petriPass == "FunnyDoge51")
                    {
                        Console.WriteLine("Hello, Petri what would you like to do today?");
                        string userAction1 = Console.ReadLine();
                        switch (userAction1)
                        {
                            case "balance":
                                Console.Write("Your current balance is " + petriBal);
                                Console.ReadKey();
                                break;
                            case "deposit":
                                Console.WriteLine("How much would you like to deposit");
                                int petriDep = Convert.ToInt32(Console.ReadLine());
                                if (petriDep < 401)
                                {
                                    int petriTotal = Convert.ToInt32(petriBal + petriDep);
                                    Console.WriteLine("Your total balance is now " + petriTotal);
                                    Console.ReadKey();

                                }
                                else
                                {
                                    Console.WriteLine("Error: Ammount is too large to deposit try again.");
                                    Console.ReadKey();
                                }
                                break;
                            case "withdraw":
                                Console.WriteLine("How much would you like to withdraw?");
                                int petriWith = Convert.ToInt32(Console.ReadLine());
                                if (petriWith == 10)
                                {
                                    Console.WriteLine("10e has been withdrawn from your account");
                                    petriBal = Convert.ToInt32(petriBal - petriWith);
                                    Console.WriteLine("Your remaining balance is " + petriBal);
                                    Console.ReadKey();
                                }
                                if (petriWith == 20)
                                {
                                    Console.WriteLine("20e has been withdrawn from your account");
                                    petriBal = Convert.ToInt32(petriBal - petriWith);
                                    Console.WriteLine("Your remaining balance is " + petriBal);
                                    Console.ReadKey();
                                }
                                if (petriWith == 50)
                                {
                                    Console.WriteLine("50e has been withdrawn from your account");
                                    petriBal = Convert.ToInt32(petriBal - petriWith);
                                    Console.WriteLine("Your remaining balance is " + petriBal);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("That ammount is not possible to withdraw try again.");
                                    Console.ReadKey();
                                }
                                break;
                        }
                        break;
                    }
                    break;

                case 210907:
                    Console.WriteLine("Please input your password:");
                    turskaPass = Console.ReadLine();
                    if (turskaPass != "CuteCats12")
                    {
                        Console.WriteLine("Password is incorrect try again");
                        Console.ReadKey();
                    }
                    if (turskaPass == "CuteCats12")
                    {
                        Console.WriteLine("Hello, Turska what would you like to do today?");
                        string userAction2 = Console.ReadLine();
                        switch (userAction2)
                        {
                            case "balance":
                                Console.Write("Your current balance is " + turskaBal);
                                Console.ReadKey();
                                break;
                            case "deposit":
                                Console.WriteLine("How much would you like to deposit");
                                int turskaDep = Convert.ToInt32(Console.ReadLine());
                                if (turskaDep < 401)
                                {
                                    int turskaTotal = Convert.ToInt32(turskaBal + turskaDep);
                                    Console.WriteLine("Your total balance is now " + turskaTotal);
                                    Console.ReadKey();

                                }
                                else
                                {
                                    Console.WriteLine("Error: Ammount is too large to deposit try again.");
                                    Console.ReadKey();
                                }
                                break;
                            case "withdraw":
                                Console.WriteLine("How much would you like to withdraw?");
                                int turskaWith = Convert.ToInt32(Console.ReadLine());
                                if (turskaWith == 10)
                                {
                                    Console.WriteLine("10euro has been withdrawn from your account");
                                    turskaBal = Convert.ToInt32(turskaBal - turskaWith);
                                    Console.WriteLine("Your remaining balance is " + turskaBal);
                                    Console.ReadKey();
                                }
                                if (turskaWith == 20)
                                {
                                    Console.WriteLine("20euro has been withdrawn from your account");
                                    turskaBal = Convert.ToInt32(turskaBal - turskaWith);
                                    Console.WriteLine("Your remaining balance is " + turskaBal);
                                    Console.ReadKey();
                                }
                                if (turskaWith == 50)
                                {
                                    Console.WriteLine("50euro has been withdrawn from your account");
                                    turskaBal = Convert.ToInt32(turskaBal - turskaWith);
                                    Console.WriteLine("Your remaining balance is " + turskaBal);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("That ammount is not possible to withdraw try again.");
                                    Console.ReadKey();
                                }
                                break;

                        }
                        break;
                    }
                    break;
                case 000000:
                    Console.WriteLine("Confirm admin login via password: ");
                    adminPass = Console.ReadLine();
                    if (adminPass != "Password")
                    {
                        Console.WriteLine("Incorrect password try again.");
                        Console.ReadKey();
                    }
                    if (adminPass == "Password")
                    {
                        Console.WriteLine("Admin access granted");
                        Console.WriteLine("Press any key to start debugging");
                        Console.ReadKey();
                        Console.WriteLine("Debugging process initiated");                        
                        Console.WriteLine("Error: Ip address not whitelisted on server");
                        Console.ReadKey();
                    }
                    break;
                    
                    // If the entered userId is not a number or not the same as the predefined value
                    default:                   
                    Console.WriteLine("Error not a valid ID number please try again.");
                    Console.ReadKey();
                    break;
            }
            
        }
    }
}