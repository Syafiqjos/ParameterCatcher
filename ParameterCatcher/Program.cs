using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ParameterCatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string Parameter;
            Parameter = string.Join(" ", args);
            string[] arr = {Parameter};

            Console.WriteLine(Parameter);
            File.WriteAllLines(@"D:\]DovahkiiND[\ParameterCatcher\ParameterCatcher\ParameterCatcher\bin\Release\output.txt", arr);
            Console.ReadLine();
        }
    }
}
