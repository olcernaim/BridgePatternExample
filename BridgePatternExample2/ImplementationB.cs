using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternExample2
{
    public class ImplementationB : Bridge
    {
        public string OperationImp()
        {
            return "Implementation B";
        }
    }
}
