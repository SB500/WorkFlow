namespace IPolymorphism
{
    public class WorkFlowTwo : IWorkFlow
    {
        public void Execute(WorkFlow job)
        {
            System.Console.WriteLine("Execute: job two");
        }
    }
}
