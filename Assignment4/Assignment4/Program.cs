namespace Section_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////
            //  Ticket Variables    //
            /////////////////////////
            int childtickets;
            int adulttickets;
            int seniortickets;
            double totalticketcost = 0;
            double totalconcessioncost = 0;
            System.Console.WriteLine("Welcome to the megaplex, please use our state of the art computer to complete your order. Enjoy!");
            System.Console.WriteLine("");

            System.Console.WriteLine("                             -Tickets-                ");
            System.Console.WriteLine("");
            System.Console.WriteLine("How many child tickets?");
            childtickets = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many Adult Tickets?");
            adulttickets = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many Senior Tickets?");
            seniortickets = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Will this be a Matinee or Evening show? (Yes/No) *Leaving blank will automatically assign you to an Evening Show.");

            string movieTime = System.Console.ReadLine();

            if (movieTime == "Yes")
            {
                System.Console.WriteLine("You have selected *Matinee*.");
                double childPrice = 3.99;
                double adultPrice = 5.99;
                double seniorPrice = 4.50;
                totalticketcost += childtickets * childPrice;
                totalticketcost += adulttickets * adultPrice;
                totalticketcost += seniortickets * seniorPrice;

            }

            else if (movieTime == "No")
            {
                System.Console.WriteLine("You have selected *Evening*.");
                double childPrice = 6.99;
                double adultPrice = 10.99;
                double seniorPrice = 8.50;
                totalticketcost += childtickets * childPrice;
                totalticketcost += adulttickets * adultPrice;
                totalticketcost += seniortickets * seniorPrice;
            }

            else
            {
                System.Console.WriteLine("You have been automatically assigned an *Evening* showing.");
            }
            ///////////////////////////
            //  Food Variables      //
            /////////////////////////

            int totalTicketCount = childtickets + adulttickets + seniortickets;

            double smallsodacost = 3.50;
            double largesodacost = 5.99;
            double hotdogcost = 3.99;
            double popcorncost = 4.50;
            double candycost = 1.99;

            int smallsodaCount = 0;
            int largesodaCount = 0;
            int hotdogCount = 0;
            int popcornCount = 0;
            int candyCount = 0;
            System.Console.WriteLine("");
            System.Console.WriteLine("                             -Food-                ");
            System.Console.WriteLine("");
            System.Console.WriteLine("Number of Small Sodas?");
            smallsodaCount = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Number of Large Sodas?");
            largesodaCount = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Number of Hotdogs?");
            hotdogCount = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Number of Popcorn?");
            popcornCount = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Number of Candy?");
            candyCount = int.Parse(System.Console.ReadLine());

            totalconcessioncost += smallsodaCount * smallsodacost;
            totalconcessioncost += largesodaCount * largesodacost;
            totalconcessioncost += hotdogCount * hotdogcost;
            totalconcessioncost += popcornCount * popcorncost;
            totalconcessioncost += candyCount * candycost;

            double firstDiscount = 0;
            double secondDiscount = 0;
            double thirdDiscount = 0;

            if (popcornCount >= 1 && largesodaCount >= 1 && totalTicketCount >= 1)
            {
                if (popcornCount <= largesodaCount && popcornCount <= totalTicketCount)
                {
                    firstDiscount = 2 * popcornCount;
                }
                else if (largesodaCount <= popcornCount && largesodaCount <= totalTicketCount)
                {
                    firstDiscount = 2 * largesodaCount;
                }
                else
                {
                    firstDiscount = 2 * totalTicketCount;
                }
            }


            if (totalTicketCount >= 3)
            {
                if (movieTime == "2")
                {
                    if (popcornCount >= 1)
                    {
                        secondDiscount = 4.50;
                    }
                }
            }

            if (candyCount >= 4)
            {
                thirdDiscount = (candyCount / 4) * 1.99;
            }

            double discountAmount = firstDiscount + secondDiscount + thirdDiscount;
            double totalcost = (totalticketcost + totalconcessioncost) - discountAmount;
            System.Console.WriteLine("");
            System.Console.WriteLine("Your total cost is: $" + totalcost);
            System.Console.WriteLine("");
            System.Console.WriteLine("Enjoy Your Movie!");
            System.Console.WriteLine("");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

        }
    }
}