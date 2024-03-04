using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class WorkFlow
    {
        public void Run(List<IActivity> workflowActivities)
        {
            if (workflowActivities.Count>0) {
            
               foreach(var activity in workflowActivities)
               {
                    activity.Execute();

               }
            
            }

        }
    }
}
