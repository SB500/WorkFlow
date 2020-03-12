using System;

namespace IPolymorphism
{
    public class WorkFlowOne : IWorkFlow
    {
        public void Execute(WorkFlow job)
        {
            Console.WriteLine("Execute: job one ");
        }
    }
}
