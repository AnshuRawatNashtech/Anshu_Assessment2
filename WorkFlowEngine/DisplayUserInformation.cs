using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class DisplayUserInformation : IActivity
    {
        void IActivity.Execute()
        {
            Console.WriteLine("Step 4: Stored information has been fetched and able to display on website.");
        }
    }
}
