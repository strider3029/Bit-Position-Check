using System;
using System.IO;

namespace BitPositionCheck
{
    class BitPositionCheck
    {
        static int Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (null == line) continue;

                    string[] numberBlocks = line.Split(',');

                    int n  = Int32.Parse(numberBlocks[0].Trim());
                    int p1 = Int32.Parse(numberBlocks[1].Trim());
                    int p2 = Int32.Parse(numberBlocks[2].Trim());

                    string binaryN = Convert.ToString(n, 2);

                    Console.WriteLine((binaryN[binaryN.Length - p1] == binaryN[binaryN.Length - p2]) ? "true" : "false");
                }
            }

            Console.ReadKey();
            return 0;
        }
    }
}
