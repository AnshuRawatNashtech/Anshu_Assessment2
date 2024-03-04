using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class AccountCreation : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Step 3: Account has been created and information has been stored in database.");
        }
    }
}
