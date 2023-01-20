using System.Text;
using System.IO;
namespace DonkMemer
{
    class Program
    {

        // TO DOOD DOO DO
        // Add Bake command
        
        static void Main (string[] args)
        {
            // Balance
            string path = Environment.CurrentDirectory;
           
            long bal = long.Parse(File.ReadAllText(@path + @"\balance.txt"));
            String currency = "$";


            // Arrays
            String[] commandlist = {"8ball", "bal", "shoplist", "buy", "bet", "stop", "inventory", "beg", "fortunecookie", "fish", "sell", "bakery", "bake"};

            String[] EightBall = {"Yes", "No"};

            String[] shoplist = {"HitBlast's Refurbished M1 Mac", "+100 Chetona", "Bleach", "HFC Chicken"};

            String[] inventory = new string[] {"Balu", "10 IQ", "Shovel"};

            String[] begList = {"Random guy: Oh you poor little beggar, take 80$", "That guy you hate: ew get away", "LOLLL IMAGINE BEGGING", "You stink!", "*Random guy kicks you and runs away*", "Oh no! What a poor little creature... HAHAHA.... Here! Take 379$"};

            String[] fortuneTeller = {"Do not hold onto things that require a tight grip.", "Don't come this far to only come this far.", "Vulnerability sounds like faith and looks like courage.", "Do it scared.", "Today it's up to you to create the peacefulness you long for.", "If you refuse to accept anything but the best, you very often get it.", "A smile is your passport into the hearts of others.", "Your high-minded principles spell success.", "Hard work pays off in the future, laziness pays off now.", "Change can hurt, but it leads a path to something better.", "Enjoy the good luck a companion brings you.", "People are naturally attracted to you.", "Hidden in a valley beside an open stream- This will be the type of place where you will find your dream.", "A chance meeting opens new doors to success and friendship.", "You learn from your mistakes... You will learn a lot today.", "If you have something good in your life, don't let it go!", "What ever you're goal is in life, embrace it visualize it, and for it will be yours.", "Your shoes will make you happy today.", "You cannot love life until you live the life you love.", "Be on the lookout for coming events; They cast their shadows beforehand.", "Land is always on the mind of a flying bird.", "The man or woman you desire feels the same about you.", "Meeting adversity well is the source of your strength.", "A dream you have will come true.", "Our deeds determine us, as much as we determine our deeds.", "Never give up. You're not a failure if you don't give up.", "You will become great if you believe in yourself.", "There is no greater pleasure than seeing your loved ones prosper.", "You already know the answer to the questions lingering inside your head.", "It is now, and in this world, that we must live.", "You must try, or hate yourself for not trying.", "You can make your own happiness.", "The greatest risk is not taking one.", "The love of your life is stepping into your planet this summer.", "Love can last a lifetime, if you want it to.", "Adversity is the parent of virtue.", "Serious trouble will bypass you.", "A short stranger will soon enter your life with blessings to share.", "Now is the time to try something new.", "Wealth awaits you very soon.", "If you feel you are right, stand firmly by your convictions.", "If winter comes, can spring be far behind?", "Keep your eye out for someone special.", "You are very talented in many ways.", "A stranger, is a friend you have not spoken to yet.", "A stranger, is a friend you have not spoken to yet.", "A new voyage will fill your life with untold memories.", "Your ability for accomplishment will follow with success.", "Nothing astonishes men so much as common sense and plain dealing.", "Its amazing how much good you can do if you dont care who gets the credit."};

            // Execution part

            int loop = 0;

            while(loop == 0)
            {       
                
                Console.WriteLine("");
                Console.WriteLine("Command list: 8ball, bal, shoplist, buy, bet, inventory, beg, fortunecookie, fish, sell, bakery, bake, stop");
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

                        
                        if(buyInput.Equals(buyCmds[0]) && bal >= 100 && !inventory.Contains("HitBlast's Refurbished M1 Mac"))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Succesfully bought " + shoplist[0] + "!") ;
                            bal = bal-100;
                            inventory = inventory.Append("HitBlast's Refurbished M1 Mac").ToArray();
                            Console.WriteLine("");

                            Console.WriteLine("Current balance: " + bal + currency);
                            Console.WriteLine("");

                        }
                        if(buyInput.Equals(buyCmds[1]) && bal >= 50 && !inventory.Contains("+100 Chetona"))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Succesfully bought " + shoplist[1] + "!") ;
                            bal = bal-50;
                            inventory = inventory.Append("+100 Chetona").ToArray();
                            Console.WriteLine("");
                            Console.WriteLine("Current balance: " + bal + currency);
                            Console.WriteLine("");

                        }
                        if(buyInput.Equals(buyCmds[2]) && bal >= 25 && !inventory.Contains("Bleach"))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Succesfully bought " + shoplist[2] + "!") ;
                            bal = bal-25;
                            inventory = inventory.Append("Bleach").ToArray();
                            Console.WriteLine("");
                            Console.WriteLine("Current balance: " + bal + currency);
                            Console.WriteLine("");

                        }
                        if(buyInput.Equals(buyCmds[3]) && bal >= 15 && !inventory.Contains("HFC Chicken"))
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

                //Fortune Cookie
                if(cmd.Equals(commandlist[8]))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to eat a Fortune Cookie?");
                    Console.WriteLine("Yes or No?");
                    Console.WriteLine("");
                    string answer = Console.ReadLine();

                    if(answer.Equals("Yes") || answer.Equals("yes"))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your fortune is:");
                        Console.WriteLine("");
                        Random rand = new Random();  
                        int index = rand.Next(fortuneTeller.Length);  
                        Console.WriteLine($"{fortuneTeller[index]}");
                    }
                    if(answer.Equals("No") || answer.Equals("no"))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You denied the Fortune Cookie.");
                        Console.WriteLine("Bad luck might strike on you...");
                    }
                }

                //Fish

                if(cmd.Equals(commandlist[9]))
                {
                    long[] fishPrices = {3, 4, 5, 7, 9, 12, 13, 2, 15, 17, 16, 19, 20, 22};

                    Console.WriteLine("");
                    Console.WriteLine("Where do you want to fish?");
                    Console.WriteLine("");
                    Console.WriteLine("Lake, River or Ocean?");
                    Console.WriteLine("");

                    string fishingPlace = Console.ReadLine();

                    if (fishingPlace.Equals("Lake") || fishingPlace.Equals("lake"))
                    {
                        string[] lakeFishes = {"Carp", "Black Bullhead", "Green Sunfish", "Crappie", "Channel Catfish", "Bluegill", "Largemouth Bass"};
                        Random randFish = new Random();  
                        int indexFish = randFish.Next(lakeFishes.Length);  
                        
                        string foundFish = lakeFishes[indexFish];

                        Console.WriteLine("");
                        Console.WriteLine("You found: " + foundFish);

                        if(inventory.Contains(foundFish))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You already own this fish! Selling the found fish.");
                            Random randPrice = new Random();  
                            long indexPrice = randPrice.Next(fishPrices.Length);  
                            bal = bal+indexPrice;
                            
                            Console.WriteLine("");
                            Console.WriteLine("Your current balance: " + bal + currency);
                        }
                        if(!inventory.Contains(foundFish))
                        {
                            inventory = inventory.Append(foundFish).ToArray();
                            Console.WriteLine("");
                            Console.WriteLine("The fish has been added to your inventory. To sell the fish, please use the sell command. \n Example: sell {fishName}, sell Garp");

                        }


                    }
                    if (fishingPlace.Equals("River") || fishingPlace.Equals("river"))
                    {
                        string[] riverFishes = {"Eel", "Common Carp", "Tench", "Bream", "Pike", "Chub", "Rainbow Trout"};
                        Random randFish2 = new Random();  
                        int indexFish2 = randFish2.Next(riverFishes.Length);  
                        
                        string foundFish2 = riverFishes[indexFish2];

                        Console.WriteLine("");
                        Console.WriteLine("You found: " + foundFish2);

                        if(inventory.Contains(foundFish2))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You already own this fish! Selling the found fish.");
                            Random randPrice = new Random();  
                            long indexPrice = randPrice.Next(fishPrices.Length);  
                            bal = bal+indexPrice;
                            
                            Console.WriteLine("");
                            Console.WriteLine("Your current balance: " + bal + currency);
                        }
                        if(!inventory.Contains(foundFish2))
                        {
                            inventory = inventory.Append(foundFish2).ToArray();
                            Console.WriteLine("");
                            Console.WriteLine("The fish has been added to your inventory. To sell the fish, please use the sell command. \n Example: sell {fishName}, sell Garp");

                        }


                    }
                    if (fishingPlace.Equals("Ocean") || fishingPlace.Equals("ocean"))
                    {
                        string[] oceanFishes = {"Green Chromis", "Firefish", "Mandarinfish", "Maroon Clownfish", "Tomato Clownfish", "Coral Beauty", "Flame Angelfish"};
                        Random randFish3 = new Random();  
                        int indexFish3 = randFish3.Next(oceanFishes.Length);  
                        
                        string foundFish3 = oceanFishes[indexFish3];

                        Console.WriteLine("");
                        Console.WriteLine("You found: " + foundFish3);

                        if(inventory.Contains(foundFish3))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You already own this fish! Selling the found fish.");
                            Random randPrice = new Random();  
                            long indexPrice = randPrice.Next(fishPrices.Length);  
                            bal = bal+indexPrice;
                            
                            Console.WriteLine("");
                            Console.WriteLine("Your current balance: " + bal + currency);
                        }
                        if(!inventory.Contains(foundFish3))
                        {
                            inventory = inventory.Append(foundFish3).ToArray();
                            Console.WriteLine("");
                            Console.WriteLine("The fish has been added to your inventory. To sell the fish, please use the sell command. \n Example: sell {fishName}, sell Garp");

                        }


                    }
                }
                string[] fishNames = {"Green Chromis", "Firefish", "Mandarinfish", "Maroon Clownfish", "Tomato Clownfish", "Coral Beauty", "Flame Angelfish", "Eel", "Common Carp", "Tench", "Bream", "Pike", "Chub", "Rainbow Trout", "Carp", "Black Bullhead", "Green Sunfish", "Crappie", "Channel Catfish", "Bluegill", "Largemouth Bass"};

                //Sell
                if(cmd.Equals(commandlist[10]) && inventory.Intersect(fishNames).Any())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Your inventory is: ");
                    Console.WriteLine(string.Join("\n", inventory));
                    Console.WriteLine("");
                    Console.WriteLine("What do you want to sell?");
                    Console.WriteLine("");

                    string sellingItem = Console.ReadLine();

                    if (sellingItem.Equals("Green Chromis") || sellingItem.Equals("Firefish") || sellingItem.Equals("Mandarinfish") ||  sellingItem.Equals("Maroon Clownfish") || sellingItem.Equals("Tomato Clownfish") || sellingItem.Equals("Coral Beauty") || sellingItem.Equals("Flame Angelfish") || sellingItem.Equals("Eel") || sellingItem.Equals("Common Carp") || sellingItem.Equals("Tench") || sellingItem.Equals("Bream") || sellingItem.Equals("Pike") || sellingItem.Equals("Chub") || sellingItem.Equals("Rainbow Trout") || sellingItem.Equals("Carp") || sellingItem.Equals("Black Bullhead") || sellingItem.Equals("Green Sunfish") || sellingItem.Equals("Crappie") || sellingItem.Equals("Channel Catfish") || sellingItem.Equals("Bluegill") || sellingItem.Equals("Largemouth Bass"))
                    {
                        long[] fishPrices = {3, 4, 5, 7, 9, 12, 13, 2, 15, 17, 16, 19, 20, 22};
                        Random price = new Random();  
                        long sellingPrice = price.Next(fishPrices.Length);  

                        Console.WriteLine("");
                        Console.WriteLine("Selling " + sellingItem);
                        bal = bal+sellingPrice;
                        Console.WriteLine("");
                        Console.WriteLine("Your current balance: " + bal + currency);
                        inventory = inventory.Where(x=> x != sellingItem).ToArray();
                        ;

                    }
                }    

                //Bakery

                bool ownsBakery = bool.Parse(File.ReadAllText(@path + @"\bakery.txt"));

                int bakeryPrice = 300;

                if(cmd.Equals(commandlist[11]) && ownsBakery == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to open a Bakery for 300$?");
                    Console.WriteLine("");
                    Console.WriteLine("Yes or No");
                    Console.WriteLine("");

                    string userInput = Console.ReadLine();

                    if(userInput.Equals("Yes") || userInput.Equals("yes"))
                    {
                        if(bal >= 300)
                        {
                            Console.WriteLine("Succesfully opened a Bakery for 300$.");
                            ownsBakery = true;
                            bal = bal-300;
                            Console.WriteLine("Your current balance: " + bal + currency);

                            StreamWriter writer2 = new StreamWriter(@path + @"\bakery.txt");
                            writer2.WriteLine(ownsBakery);
                            writer2.Close();

                        }
                        if(ownsBakery == true)
                        {

                            Console.WriteLine("");
                             Console.WriteLine("You already own a Bakery!");
                        }    


                    }
                    if(userInput.Equals("No") || userInput.Equals("no"))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You denied.");

                    }                    

                }

                //Bake
               if(cmd.Equals(commandlist[12]) && !ownsBakery == true)
               {
                Console.WriteLine("");
                Console.WriteLine("You do not have a bakery to bake cookies in!");
               }

                if(cmd.Equals(commandlist[12]) && ownsBakery == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to bake cookies for 2$? (Price for dough, chocolate, sugar, etc.)");
                    Console.WriteLine("");
                    Console.WriteLine("Yes or No?");
                    Console.WriteLine("");

                    string cookieInput = Console.ReadLine();

                    if(cookieInput.Equals("Yes") || cookieInput.Equals("yes") && inventory.Contains("2 Cookies"))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You already have 2 Cookies baked!");
                    }

                    if(cookieInput.Equals("Yes") || cookieInput.Equals("yes") && !inventory.Contains("2 Cookies"))
                    {
                        if(bal >= 2)
                        {
                            bal = bal-2;
                            inventory = inventory.Append("2 Cookies").ToArray();
                            Console.WriteLine("Baked 2 Cookies for 2$! They have been added to your inventory.");
                            Console.WriteLine("");
                            Console.WriteLine("Your current balance: " + bal + currency);
                        }
                    }

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
