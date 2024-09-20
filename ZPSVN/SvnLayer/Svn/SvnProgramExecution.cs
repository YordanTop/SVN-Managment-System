using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRetrieving.SVN
{
    public class SvnProgramExecution
    {
        private readonly string _pathToSvnExe;

        private readonly string _workingDirectory;
        public SvnProgramExecution(string pathToSvnExe, string workingDirectory) 
        {
            _pathToSvnExe = pathToSvnExe;
            _workingDirectory = workingDirectory;
        }

        private string ExecuteProgram(string fileName, string arguments)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = fileName,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                Arguments = arguments,
                WorkingDirectory = _workingDirectory,
                CreateNoWindow = true
            });
            
            string text = process?.StandardOutput.ReadToEnd();
            process?.WaitForExit();
            if (process == null)
            {
                // TODO: sushto taka ako nqma nikakvi greshki a e druga greshkata.
                throw new InvalidOperationException(process?.StandardError.ReadToEnd());
            }

            return text;
        }

        protected string GetInfo(string command)
        {
            string output = ExecuteProgram(_pathToSvnExe, command);
            return output;
        }
    }
}
