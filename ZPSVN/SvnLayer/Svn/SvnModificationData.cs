using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRetrieving.SVN
{
    public class SvnModificationData : SvnProgramExecution
    {
        //Status:       File:
        private string modificationInfo;
        public string ModificationInfo 
        {
            get {  return modificationInfo; }
            set
            {
                if (modificationInfo == null || modificationInfo.Equals(String.Empty))
                {
                    modificationInfo = "Everything is patched.\r\n";
                    modificationInfo = value;
                }

                modificationInfo = "Status:       File:\r\n"+value;
            }
        }
        public SvnModificationData(string pathToSvnExe, string workingDirectory) : base(pathToSvnExe, workingDirectory)
        {
            modificationInfo = base.GetInfo("status");
        }
    }
}
