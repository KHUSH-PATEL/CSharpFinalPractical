using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6
{
    public delegate void Notification();
    internal class ProcessBusinessLogic
    {
        public event Notification ProcessCompleted;

        /// <summary>
        /// Print Process Started and call OnProcessCompleted. 
        /// </summary>
        public void StartProcess()
        {
            Console.WriteLine("Process Started");
            OnProcessCompleted();
        }
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
