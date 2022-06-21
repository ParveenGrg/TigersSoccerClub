using System;

namespace TigersSoccerClub
{
    class Program
    {
        static void Main(string[] args)
        {
            double kidsJersey = 150;
            double adultJersey = 230;
            Console.Write(Messages.welcome);
            Console.Write(Messages.numberPlayers);
            int numberPlayers = Convert.ToInt32(Console.ReadLine());
            while (numberPlayers < 1 || numberPlayers > 4)
            {
                Console.Write(ErrorMessages.playerLimit);
                Console.Write(Messages.numberPlayers);
                numberPlayers = Convert.ToInt32(Console.ReadLine());
            }
            string[] names = new string[numberPlayers];
            string[] types = new string[numberPlayers];
            string[] yesno = new string[numberPlayers];
            double[] price = new double[numberPlayers];
            for (int i = 0; i < numberPlayers; i++)
            {
                Console.Write("\n----------------------------------------------------------");
                Console.Write(Messages.playerName);
                names[i] = Console.ReadLine();
                Console.Write(Messages.registrationType);
                types[i] = Console.ReadLine();
                Console.Write(Messages.jersey);
                yesno[i] = Console.ReadLine();
                if (types[i].Equals("Kids"))
                {
                    price[i] = kidsJersey - kidsJersey * 5 / 100;
                    if (yesno[i].Equals("yes"))
                    {
                        price[i] = price[i] + 100;
                    }
                }
                if (types[i].Equals("Adult"))
                {
                    price[i] = adultJersey - adultJersey * 5 / 100;
                    if (yesno[i].Equals("yes"))
                    {
                        price[i] = price[i] + 120;
                    }
                }

                Console.Write("\n The total price from " + names[i] + " is $" + price[i]);
            }
            double Max = price[0];
            int Maxindex = 0;
            double Min = price[0];
            int Minindex = 0;
            for (int i = 0; i < numberPlayers; i++)
            {
                if (price[i] > Max)
                {
                    Max = price[i];
                    Maxindex = i;
                }
                if (price[i] < Min)
                {
                    Min = price[i];
                    Minindex = i;
                }
            }
            Console.Write(Messages.summary);
            Console.Write("\n----------------------------------------------------------");
            Console.Write("\nName \t\t type \t\t Jersey \t\t Cost");
            for (int i = 0; i < numberPlayers; i++)
            {
                Console.Write("\n" + names[i] + "\t\t" + types[i] + "\t\t" + yesno[i] + "\t\t\t$" + price[i]);
            }
            Console.Write("\n----------------------------------------------------------");
            Console.Write("\n Player spending most is " + names[Maxindex]);
            Console.Write("\n Player spending least is " + names[Minindex]);
        }
    }
}
