using System;

namespace Interfaces___Exercise_1
{
    internal class EmailOwner3 : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing");
        }
    }
}
