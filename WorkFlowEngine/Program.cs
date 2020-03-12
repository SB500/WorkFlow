using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPolymorphism
{
    

    class Program
    {
        static void Main(string[] args)
        {
            var _workflowengine = new WorkFlowEngine();
            _workflowengine.WorkFlowBuilder(new WorkFlowOne());
            _workflowengine.WorkFlowBuilder(new WorkFlowTwo());
            _workflowengine.WorkFlowBuilder(new WorkFlowThree());
            _workflowengine.Execute();
        }
    }
}
