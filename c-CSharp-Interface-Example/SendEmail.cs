using System;

namespace Interface
{
    class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email");
        }
    }
}