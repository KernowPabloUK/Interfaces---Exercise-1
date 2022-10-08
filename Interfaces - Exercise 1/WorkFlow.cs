using System.Collections.Generic;
namespace Interfaces___Exercise_1
{
    internal class WorkFlow : IActivities
    {
        internal List<IActivities> activiyList = new List<IActivities>();
        public void Execute()
        {
            


            UploadVideo1 activity1 = new UploadVideo1();
            ContactWebService2 activity2 = new ContactWebService2();
            EmailOwner3 activity3 = new EmailOwner3();
            ChangeStatus4 activity4 = new ChangeStatus4();

            activity1.Execute();
            activity2.Execute();
            activity3.Execute();
            activity4.Execute();
        }
    }
}
