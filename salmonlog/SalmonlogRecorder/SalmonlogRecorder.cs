using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using SalmonlogNotifyPluginBase;

namespace SalmonlogRecorder
{
    [SalmonlogPluginExport("SalmonlogRecorder", "v0.1")]
    public class SalmonlogRecorder : ISalmonlogNotifyPluginBase
    {
        public void NotifyDead()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} called.");
        }

        public void NotifyPersonalResult()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} called.");
        }

        public void NotifyResultSummary()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} called.");
        }

        public void NotifyStageName()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} called.");
        }

        public void OnSalmonFinished()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} called.");
        }

        public void OnSalmonStarted()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} called.");
        }
    }
}
