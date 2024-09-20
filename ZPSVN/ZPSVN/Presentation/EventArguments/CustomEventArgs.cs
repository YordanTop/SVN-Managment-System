using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPSVN.Presentation.EventArguments
{
    public class CustomEventArgs : EventArgs
    {
        public object CustomObject { get; set; }

        public CustomEventArgs(object customObject)
        {
            CustomObject = customObject;
        }
    }
}
