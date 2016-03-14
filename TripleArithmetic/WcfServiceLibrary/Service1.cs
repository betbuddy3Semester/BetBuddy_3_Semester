using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TripleOfInt;
using LibraryTripleOfInt;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public ThreeIntClass MethodThreeIntClass(ThreeIntClass objectOne, ThreeIntClass objectTwo)
        {
            return new Library().AddOfInt(objectOne, objectTwo);
        }

        public ThreeIntClass NewTriple(int one, int two, int three)
        {
            return new ThreeIntClass(one, two, three);
        }
    }
}
