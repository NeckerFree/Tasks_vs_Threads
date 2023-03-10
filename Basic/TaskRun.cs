namespace Basic
{
    internal class TaskRun
    {
        internal void DoWork(int order, int durationMs)
        {
            Thread.Sleep(durationMs);
            Console.WriteLine($"Task {order} executed");
        }
        
    }
}
