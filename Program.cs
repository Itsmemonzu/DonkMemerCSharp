using System.Text;
using System.IO;
namespace DonkMemer
{
    class Program
    {
        static void Main (string[] args)
        {
            // Balance
            string path = Environment.CurrentDirectory;
           
            long bal = long.Parse(File.ReadAllText(@path + @"\balance.txt"));
            String currency = "$";


            // Arrays
            String[] commandlist = {"8ball", "bal", "shoplist", "buy", "bet", "stop", "inventory", "beg"};

            String[] EightBall = {"Yes", "No"};

            String[] shoplist = {"HitBlast's Refurbished M1 Mac", "+100 Chetona", "Bleach", "HFC Chicken"};

            String[] inventory = new string[] {"Balu", "10 IQ", "Shovel"};

            String[] begList = {"Random guy: Oh you poor little beggar, take 80$", "That guy you hate: ew get away", "LOLLL IMAGINE BEGGING", "You stink!", "*Random guy kicks you and runs away*", "Oh no! What a poor little creature... HAHAHA.... Here! Take 379$"};


            // Execution part

            int loop = 0;

            while(loop == 0)
            {       
                
                Console.WriteLine("");
                Console.WriteLine("Command list: 8ball, bal, shoplist, buy, bet, inventory, beg, stop");
                Console.WriteLine("");
                Console.WriteLine("Write a command: ");
                Console.WriteLine("");
                String cmd = Console.ReadLine();

                //8ball
                if(cmd.Equals(commandlist[0]))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please ask something after writing the command!");
                }
                if(cmd.Contains(commandlist[0]) && cmd.Length != commandlist[0].Length)
                {
                    Random rand = new Random();  
                    int index = rand.Next(EightBall.Length);  

                    Console.WriteLine("");
                    Console.WriteLine($"{EightBall[index]}");
                    Console.WriteLine("");
                
                }

                //Bal

                if(cmd.Equals(commandlist[1]))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Your balance is: " + bal + currency);
                    Console.WriteLine("");
                }

                //Shoplist

                if(cmd.Contains(commandlist[2]))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Shoplist:");
                    Console.WriteLine("");
                    Console.WriteLine("No 0. " + shoplist[0] + " Price: 100$");
                    Console.WriteLine("No 1 " + shoplist[1] + " Price: 50$");
                    Console.WriteLine("No 2 " + shoplist[2] + " Price: 25$");
                    Console.WriteLine("No 3 " + shoplist[3] + " Price: 15$");
                    Console.WriteLine("");
                }    

                //Buy

                if(cmd.Contains(commandlist[3]))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Shoplist:");
                    Console.WriteLine("");
                    Console.WriteLine("No 0. " + shoplist[0] + " Price: 100$");
                    Console.WriteLine("No 1 " + shoplist[1] + " Price: 50$");
                    Console.WriteLine("No 2 " + shoplist[2] + " Price: 25$");
                    Console.WriteLine("No 3 " + shoplist[3] + " Price: 15$");
                    Console.WriteLine("");

                    Console.WriteLine("What do you want to buy? Buying command: buy {itemNumber} eg. buy 1");
                    String[] buyCmds = {"buy 0", "buy 1", "buy 2", "buy 3"};
                    Console.WriteLine("");
                    String buyInput = Console.ReadLine();
                    
                    try
                    {

                        
                        if(buyInput.Equals(buyCmds[0]) && bal >= 100)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Succesfully bought " + shoplist[0] + "!") ;
                            bal = bal-100;
                            inventory = inventory.Append("HitBlast's Refurbished M1 Mac").ToArray();
                            Console.WriteLine("");

                            Console.WriteLine("Current balance: " + bal + currency);
                            Console.WriteLine("");

                        }
                        if(buyInput.Equals(buyCmds[1]) && bal >= 50)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Succesfully bought " + shoplist[1] + "!") ;
                            bal = bal-50;
                            inventory = inventory.Append("+100 Chetona").ToArray();
                            Console.WriteLine("");
                            Console.WriteLine("Current balance: " + bal + currency);
                            Console.WriteLine("");

                        }
                        if(buyInput.Equals(buyCmds[2]) && bal >= 25)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Succesfully bought " + shoplist[2] + "!") ;
                            bal = bal-25;
                            inventory = inventory.Append("Bleach").ToArray();
                            Console.WriteLine("");
                            Console.WriteLine("Current balance: " + bal + currency);
                            Console.WriteLine("");

                        }
                        if(buyInput.Equals(buyCmds[3]) && bal >= 15)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Succesfully bought " + shoplist[3] + "!") ;
                            bal = bal-15;
                            inventory = inventory.Append("HFC Chicken").ToArray();
                            Console.WriteLine("");
                            Console.WriteLine("Current balance: " + bal + currency);
                            Console.WriteLine("");

                        }

                    }
                    catch
                    {

                    }

                

                }


                //Bet

                if(cmd.Contains(commandlist[4]))
                {
                    int betBal;

                    try
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Current balance: " + bal + currency);
                        Console.WriteLine("How much do you want to bet?");
                        Console.WriteLine("");

                        betBal = Convert.ToInt16(Console.ReadLine());

                        if(betBal <= bal)
                         {
                             //Betting Arrays

                             int[] playerArray = {1,2,3,4,5,6,7,8,9,10};
                             int[] botArray = {1,2,3,4,5,6,7,8,9,10};

                             Random randNum1 = new Random();  
                             int playerNum = randNum1.Next(playerArray.Length);

                             Random randNum2 = new Random();  
                             int botNum = randNum2.Next(botArray.Length);

                             if(playerNum > botNum)
                             {
                                 Console.WriteLine("");
                                 Console.WriteLine("You rolled " + playerNum + " and Bot rolled " + botNum);
                                 Console.WriteLine("You won " + betBal + currency + "!");
                                 Console.WriteLine("");
                                 bal = bal+betBal;
                                 Console.WriteLine("Current balance: " + bal + currency);
                                 Console.WriteLine("");
                             }
                             if(playerNum == botNum)
                             {
                                 Console.WriteLine("");
                                 Console.WriteLine("You rolled " + playerNum + " and Bot rolled " + botNum);
                                 Console.WriteLine("You won and lost nothing.");
                                 Console.WriteLine("");
                                 Console.WriteLine("Current balance: " + bal + currency);
                                 Console.WriteLine("");
                             }
                             if(playerNum < botNum)
                             {
                                 Console.WriteLine("");
                                 Console.WriteLine("You rolled " + playerNum + " and Bot rolled " + botNum);
                                 Console.WriteLine("You lost " + betBal + currency);
                                 bal = bal-betBal;
                                 Console.WriteLine("");
                                 Console.WriteLine("Current balance: " + bal + currency);
                                 Console.WriteLine("");
                             }
                        }     
                    }
                    catch
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Invalid format!");

                    }
                }

                //Beg 
                if(cmd.Equals(commandlist[7]))
                {
                    Console.WriteLine("");
                    Random rand = new Random();  
                    int indexBeg = rand.Next(begList.Length);  

                    Console.WriteLine("");
                    Console.WriteLine($"{begList[indexBeg]}");
                    Console.WriteLine("");
                    if(begList[indexBeg].Equals(begList[0]))
                    {
                        bal = bal+80;
                        Console.WriteLine("");
                        Console.WriteLine("Your current balance: " + bal + currency);
                    }
                    if(begList[indexBeg].Equals(begList[1]))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your current balance: " + bal + currency);
                    }
                    if(begList[indexBeg].Equals(begList[2]))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your current balance: " + bal + currency);
                    }
                    if(begList[indexBeg].Equals(begList[3]))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your current balance: " + bal + currency);
                    }
                    if(begList[indexBeg].Equals(begList[4]))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your current balance: " + bal + currency);
                    }
                    if(begList[indexBeg].Equals(begList[5]))
                    {
                        bal = bal+379;
                        Console.WriteLine("");
                        Console.WriteLine("Your current balance: " + bal + currency);
                    }



                }

                //Inventory
                if(cmd.Equals(commandlist[6]))
                {   
                    Console.WriteLine("");
                    Console.WriteLine("Your inventory is:");
                    Console.WriteLine("");
                    Console.WriteLine(string.Join("\n", inventory));
                    Console.WriteLine("");
                }

                //Stop
                if(cmd.Equals(commandlist[5]))
                {
                    StreamWriter writer = new StreamWriter(@path + @"\balance.txt");
                    writer.WriteLine(bal);
                    writer.Close();
                    Console.WriteLine("Stopping...");
                    break;

                }

            }

        }
    }
}
