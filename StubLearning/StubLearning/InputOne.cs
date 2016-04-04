using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubLearning
{
    public class InputOne : IInput
    {
        public string input()
        {
            return "Always random";
        }
    }
}
