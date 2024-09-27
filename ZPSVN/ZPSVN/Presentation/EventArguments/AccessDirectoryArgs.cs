using System;

namespace ZPSVN.Presentation.EventArguments
{
    public class AccessDirectoryArgs : EventArgs
    {
        private string _repository;
        public string Repository
        {
            get { return _repository; }
            set
            {
                _repository = value;
            }
        }

        private string _directory;
        public string Directory
        {
            get { return _directory; }
            set
            {
                _directory = value;
            }
        }
        public AccessDirectoryArgs(string pathToSvn, string directory)
        {
            _repository = pathToSvn;
            _directory = directory;
        }
    }
}
