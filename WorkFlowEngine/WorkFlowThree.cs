namespace IPolymorphism
{
    public class WorkFlowThree : IWorkFlow
    {
        public void Execute(WorkFlow job)
        {
            System.Console.WriteLine("Execute: job Three");
        }
    }
}
