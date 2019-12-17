using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Events
{
    public class StorageEventArgs
    {
        public string Message { get; }
        //public string Good { get; }
        public StorageEventArgs(string message)
        {
            Message = message;
            //Good = good;
        }
    }
}
