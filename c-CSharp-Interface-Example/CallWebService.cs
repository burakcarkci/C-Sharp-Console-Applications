using System;

namespace Interface
{
    internal class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service");
        }
    }
}