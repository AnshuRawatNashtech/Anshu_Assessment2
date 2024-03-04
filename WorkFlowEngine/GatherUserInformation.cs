using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class GatherUserInformation : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Step 1: Information about user has been gathered from sources.");
        }
    }
}
