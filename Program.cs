namespace SimpleCodeTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int numOfStrings = 1000;
            int numOfBlockedStrings = 10;

            string[] testStrings;
            string[] blockedTestStrings=new string[numOfBlockedStrings];
            HostGenerator generator = new HostGenerator();
            
            testStrings = generator.GenerateStringsArray(numOfStrings);
            testStrings=testStrings.ToList().Distinct().ToArray();
            foreach (var str in testStrings)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            
            for (int i = 0; i < numOfBlockedStrings; i++)
            {
                blockedTestStrings[i]=testStrings[i];
            }
            foreach (var str in blockedTestStrings)
            {
                Console.WriteLine(str);
            }

            int[] allowedHosts = Solution.solution(testStrings, blockedTestStrings);
            */

            string[] a = 
            { 
                "unlock.microvirus.md",
                "visitwar.com", 
                "visitwar.de", 
                "fruonline.co.uk", 
                "australia.open.com", 
                "credit.card.us",
            };                                                                                                                  
            string[] b = 
            { 
                "com",
                "microvirus.md",
                "visitwar.de",
                "piratebay.co.uk",
                "list.stolen.credit.card.us",
            };

            int[] allowedHosts = Solution.solution(a, b);
            Console.WriteLine("Indexes of allowed domains:");
            for (int i = 0; i < allowedHosts.Length; i++)
                Console.Write(allowedHosts[i] + " ");

            Console.WriteLine();
            Console.WriteLine(Solution.counter);
        }                                                                                                                                                                                           
    }
}                                                          