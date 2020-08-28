using System;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Resources;
using ConsoleApps.Properties;
using Microsoft.Extensions.FileProviders;

namespace ConsoleApps.Solutions
{
    public class Thirteen
    {
        public string LargeSum()
        {
            //// Read the list from a file
            //string filename = "ProblemTwelveNumberList.txt";

            //string line;
            //StreamReader sReader = new StreamReader(filename);

            //// .NET has built in support for large integers
            BigInteger result = new BigInteger();

            // Read from resources
            //var assembly = Assembly.GetEntryAssembly();
            ////var assemblyTypes = assembly.GetTypes();
            //var embeddedProvider = new EmbeddedFileProvider(assembly);

            ////var temp = Resources.ProblemThirteenNumberList.Split();
            ////string[] names = assembly.GetManifestResourceNames();

            //using (var reader = embeddedProvider.GetFileInfo("ConsoleApps.Resources.ProblemThirteenNumberList.txt").CreateReadStream())
            //{
            //    StreamReader sReader = new StreamReader(reader);
            //    string line;

            //    while ((line = sReader.ReadLine()) != null)
            //    {
            //        result += BigInteger.Parse(line);
            //    }
            //}

            var numbers = Resources.ProblemThirteenNumberList.Split(new [] {"\r\n"}, StringSplitOptions.None);

            foreach (string item in numbers)
            {
                result += BigInteger.Parse(item);
            }

            return result.ToString().Substring(0, 10);
        }
    }
}
