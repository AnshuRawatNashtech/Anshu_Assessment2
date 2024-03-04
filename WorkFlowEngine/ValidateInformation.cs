using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class ValidateInformation : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Step 2: Provided Information has been validated.");
        }
    }
}
