using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public interface IActivity
    {
        //provide implementation of activity executed
        void Execute();
    }
}
