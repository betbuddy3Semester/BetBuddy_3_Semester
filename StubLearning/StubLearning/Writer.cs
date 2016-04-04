using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StubLearning.InputOne;
using static StubLearning.InputTwo;

namespace StubLearning
{
    public class Writer
    {
        public static void Main(string[] args)
        {
           Console.WriteLine(new Writer().WriteInput(new InputOne().input()));
        }

        public string WriteInput(string input)
        {
            return input;
        }
    }
}
