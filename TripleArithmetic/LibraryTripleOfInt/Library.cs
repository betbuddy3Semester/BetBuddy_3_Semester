using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleOfInt;

namespace LibraryTripleOfInt
{
    public class Library
    {
        public ThreeIntClass AddOfInt(ThreeIntClass objectOne, ThreeIntClass objectTwo)
        {
            var one = addNumbers(objectOne.NumberOne, objectTwo.NumberOne);
            var two = addNumbers(objectOne.NumberTwo, objectTwo.NumberTwo);
            var three = addNumbers(objectOne.NumberThree, objectTwo.NumberThree);

            return new ThreeIntClass(one, two, three);
        }

        public int addNumbers(int one, int two)
        {
            return one + two;
        }
    }
}
