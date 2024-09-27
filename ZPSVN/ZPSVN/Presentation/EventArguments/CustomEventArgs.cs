using System;

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
