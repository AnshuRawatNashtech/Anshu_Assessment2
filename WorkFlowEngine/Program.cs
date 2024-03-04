using WorkFlowEngine;

//provide steps for work flow
List<IActivity> workflowSteps = new List<IActivity>
{
            new GatherUserInformation(),
            new ValidateInformation(),
            new AccountCreation(),
            new DisplayUserInformation()
};

WorkFlow executeAllSteps = new WorkFlow();
executeAllSteps.Run(workflowSteps);