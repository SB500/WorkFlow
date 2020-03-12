using System.Collections.Generic;

namespace IPolymorphism
{
    public class WorkFlowEngine
    {
        private readonly IList<IWorkFlow> _workFlows;

        public WorkFlowEngine()
        {
            _workFlows = new List<IWorkFlow>();
        }

        public void WorkFlowBuilder(IWorkFlow workflow)
        {
            _workFlows.Add(workflow);
        }

        public void Execute()
        {
            foreach (var workflow in _workFlows)
            {
                workflow.Execute(new WorkFlow());
            }
        }
    }
}
