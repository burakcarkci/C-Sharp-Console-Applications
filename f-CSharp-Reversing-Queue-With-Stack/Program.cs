namespace ReversingQueue
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            var reverse = new ReversingQueueWithStack();
            reverse.EnQueue(1);
            reverse.EnQueue(2);
            reverse.EnQueue(3);
            reverse.EnQueue(4);
            reverse.RemoveFromQueue();
            reverse.AddBackToQueue();
            reverse.PrintQueue();
        }
    }
}