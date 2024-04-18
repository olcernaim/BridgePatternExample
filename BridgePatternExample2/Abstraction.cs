using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternExample2
{
    public class Abstraction
    {
        Bridge _bridge;
        public Abstraction(Bridge bridge)
        {
            _bridge = bridge;
        }
         
        public string Operation()
        {
            return "Abstraction " + _bridge.OperationImp();
        }
    }
}
