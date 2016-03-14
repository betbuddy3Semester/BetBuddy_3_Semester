using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LibraryTripleOfInt;
using TripleOfInt;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        ThreeIntClass MethodThreeIntClass(ThreeIntClass objectOne, ThreeIntClass objectTwo);

        [OperationContract]
        ThreeIntClass NewTriple(int one, int two, int three);
    }
}
