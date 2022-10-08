using System;

namespace Interfaces___Exercise_1
{
    internal class ChangeStatus4 : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to “Processing”");
        }
    }
}
