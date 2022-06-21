using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigersSoccerClub
{
    class Messages
    {
        public static string welcome = "\t\t\t\tWelcome to Tiger Soccers Club";
        public static string numberPlayers = "\nEnter the number of players per registration : ";
        public static string playerName = "\nEnter player name : ";
        public static string registrationType = "\nRegistration type : ";
        public static string jersey = " Enter yes/no to indicate whether you want a jersey : ";
        public static string totalPrice = " The total price from";
        public static string summary = "\n\n\t\t\t\t Summary of Registrations";
        public static string mostSpending = " The player spending most is ";
        public static string leastSpending = " The player spending least is ";
    }
    class ErrorMessages
    {
        public static string playerLimit = "The number of players must be between 1 to 4";
    }
}
