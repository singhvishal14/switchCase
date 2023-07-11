using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode,lang,Choice;
            do { 
            Console.WriteLine("Enter Country Code");
            cCode = Console.ReadLine();
            switch(cCode)
            {
                case "uk":
                case "us":
                    {
                        lang = "English";
                        break;
                    }
                case "af":
                    {
                        lang = "Dari,Pashto";
                        break;
                    }
                case "in":
                    { 
                        lang = "Hindi,English,Tamil and Telgu";
                        break;
                    }
                case "uae":
                case "om":
                case "ksa":
                case "egypt":
                    {
                        lang = "Arabic";
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Sorry!! Your Country {cCode} is not found");
                        lang = "Not Found!!!!!!!";
                        break;
                    }
            }
            Console.WriteLine("Country Code: \t " + cCode + "\n Language(s): \t"  + lang);
            Console.WriteLine("Do you wanna continue if yes press y \n To exit press any key");
            Choice = Console.ReadLine().ToLower(); 
            
        }
        while (Choice == "y");
    }
}
}
