using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCodeTestTask
{
    public class HostGenerator
    {
        Random rnd = new Random();
        string[] firstLevel = 
        { 
            "md",
            "com", 
            "de", 
            "uk", 
            "ru", 
            "us",
            "tv", 
            "jp", 
            "net", 
            "biz", 
        }; 
        string[] secondLevel = 
        { 
            "microvirus",
            "visitwar", 
            "microsoft", 
            "habr", 
            "australia", 
            "card",
            "github", 
            "gnu", 
            "dropbox",
            "mdns",   
        }; 
        string[] thirdLevel = 
        { 
            "unlock",
            "visit", 
            "fruit", 
            "online", 
            "sales", 
            "info",
            "studio",
            "tea",
            "phone",
            "cup",
        }; 

        public string GenerateString()
        {
            string result = "";
            int value = rnd.Next(0, 10);
            int chance;
            result = firstLevel[value];
            chance = rnd.Next(0,10);
            if (chance > 2)
            {
                value = rnd.Next(0, 10);
                result = string.Join(".", secondLevel[value], result);
                chance = rnd.Next(0,10);

                if (chance > 6)
                {
                    value = rnd.Next(0, 10);
                    result = string.Join(".", thirdLevel[value], result);
                }
            }
            return result;
        }

        public string[] GenerateStringsArray(int requiredNumOfStrings)
        {
            string[] result = new string[requiredNumOfStrings];
            for (int i = 0; i < requiredNumOfStrings; i++)
            {
                result[i] = GenerateString();
            }
            return result;
        }
    }
}
