using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Diablo_III_ladder_analytics.Classes
{
    class ThreadController
    {
        public void RunInSeparateThread<T>(MethodInvoker methodName, ThreadParameters<T> parametersList)
        {
            BackgroundWorker worker = new BackgroundWorker();

            worker.WorkerReportsProgress = true;  
        }

        public void Worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            
        }

    }

    class ThreadParameters<T>
    {
        int operationCode { get; set; }
        string operationName { get; set; }       
    }


}
