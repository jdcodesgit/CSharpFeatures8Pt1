using System;
using System.IO;

namespace CSharp8FeaturesPt1
{
    internal class UsingDeclarations
    {
        internal static void ReadContentOld(string filePath)
        {
            using(var reader = new StreamReader(filePath))
            {
                foreach(var line in reader.ReadLine())
                {
                    if(!string.IsNullOrWhiteSpace(line.ToString()))
                    {
                        Console.WriteLine(line);
                    }
                }
            }//StreamReader disposed here
        }

        internal static void ReadContentNew(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            foreach (var line in reader.ReadLine())
            {
                if (!string.IsNullOrWhiteSpace(line.ToString()))
                {
                    Console.WriteLine(line);
                }
            }
            //StreamReader disposed here
        }
    }
}
