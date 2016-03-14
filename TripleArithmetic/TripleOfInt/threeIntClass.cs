using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TripleOfInt
{
    [DataContract]
    public class ThreeIntClass
    {
        [DataMember]
        public int NumberOne { get; private set; }
        [DataMember]
        public int NumberTwo { get; private set; }
        [DataMember]
        public int NumberThree { get; private set; }

        public ThreeIntClass(int numberOne, int numberTwo, int numberThree)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
            NumberThree = numberThree;
        }
    }
}