using System;

namespace Interface
{
    internal class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video");
        }
    }
}