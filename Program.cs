using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata;
// week2 exercise
namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<10)
                //Console.WriteLine($"Attemp {i+1} \n");
            {
                try
                {
                    Greet();
                    long card_number = long.Parse(Console.ReadLine());
                    int digits = (int)Math.Floor(Math.Log10(card_number)) + 1;
                    if (digits == 16)
                    {
                        Console.WriteLine("Please Enter Your Pin : ");
                        int pin = Convert.ToInt32(Console.ReadLine());
                        int temp = (int)Math.Log10(pin) + 1;
                        if (temp == 4)
                        {
                            Console.WriteLine("1 - Transfer ");
                            Console.WriteLine("2 - Withdraw ");
                            Console.WriteLine("3- Deposit");
                            Console.WriteLine("4 - Quit");
                            int option = Convert.ToInt32(Console.ReadLine());
                            if(option>=1 & option <= 4)
                            {
                                switch (option)
                                {
                                    case 1:
                                        Console.WriteLine("Enter The Amount :(Not Over 1000");
                                        int amount = Convert.ToInt32(Console.ReadLine());
                                        if(amount<=1000 & amount > 0)
                                        {
                                            Console.WriteLine("Please Enter The Email You want to transfer the money:");
                                            string d_card = Console.ReadLine();

                                            try {

                                                Console.WriteLine($"Your Email Is : {d_card}");
                                                Console.WriteLine("To confirm Please Press 1:");
                                                int accept = Convert.ToInt32(Console.ReadLine());
                                                if (accept == 1)
                                                {
                                                    Console.WriteLine("Money Sent !");
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            catch(Exception e)
                                            {
                                                Console.WriteLine($"Error: {e.Message}");
                                            }
                                            
                                        }
                                       
                                        else
                                        {
                                            break;
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Please Enter The Amount You Would Like To Withdraw : ");
                                        int withdraw_amount = Convert.ToInt32(Console.ReadLine());
                                        if (withdraw_amount>0 & withdraw_amount<=1000)
                                        {
                                            Console.WriteLine("Please Take Your Money From Machine");
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("The Amount is Either Negative or Over the Limit .");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Please Insert Your Cash: \n Note That The Limit is 2000 Dollars \n To accept our" +
                                            "cookies please press 1 :");
                                        int cook =Convert.ToInt32(Console.ReadLine());
                                        if (cook==1)
                                        {
                                            Console.WriteLine("Successful! ");
                                        }

                                        break;
                                    case 4:
                                        break;
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Digits Must be 4 !");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Your Card digits number must be 16 !");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input must be eger!");
                }
                i++;

            }



        }
        
       static void Greet()
    {
        Console.WriteLine("WELCOME TO VIRTUAL ATM \n Please Enter Your Debit/Credit Card Number : \"");
    }
       
        
    }
    
}




