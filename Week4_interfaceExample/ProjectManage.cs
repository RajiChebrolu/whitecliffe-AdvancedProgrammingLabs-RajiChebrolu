using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_interfaceExample
{
    internal class ProjectManage: IWorker, ILeader
    {
        public void PerformWork()
        {
            Console.WriteLine("Project Manager is performing his work.");
        }
        public void LeadTeam()
        {
            Console.WriteLine("Project Manager is leading the team.");
        }
        public void MakeReports()
        {
            Console.WriteLine("Project Manager is making reports of his team.");
        }
    }
}
