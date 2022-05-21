using System;

namespace LookAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            if (args.Length != 2)
            {
                Console.WriteLine("Please provide an argument [-l|-r] and a number");
                return;
            }
            else
            {
                if (!(args[0].Equals("-l") || args[0].Equals("-r")))
                {
                    Console.WriteLine("Please provide an argument [-l|-r]");
                    return;
                }

                if (!int.TryParse(args[1], out number))
                {
                    Console.WriteLine("Could not parse provided number");
                    return;
                }

                if (number < 0)
                {
                    Console.WriteLine("Please provide a positive number");
                    return;
                }
            }

            LookAndSay las = new LookAndSay(number);
            int result;
            try
            {
                switch (args[0])
                {
                    case "-l":
                        result = las.ConvertToLookAndSay();
                        break;
                    case "-r":
                        result = las.ConvertToNumber();
                        break;
                    default:
                        throw new Exception("Unsuported operation");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"The following error occured: {e.Message}");
                return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
