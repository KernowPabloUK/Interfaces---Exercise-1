using System;

namespace Interfaces___Exercise_1
{
    internal class WorkFlowEngine
    { 
        internal void Run()
        {
            WorkFlow workflow = new WorkFlow();
            workflow.Execute();
        }
    }
}
