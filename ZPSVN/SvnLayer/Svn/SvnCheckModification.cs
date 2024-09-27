using Svn;

namespace DataRetrieving.SVN
{
    public class SvnCheckModification:SvnProgramExecution
    {
        public char GetQuestionArg;

        public char GetModification;
        public char GetQuestionMark;
        public char ExclamationMark;
        public string ErrorProblem;

        public string SvnModificationInfo;

        public SvnCheckModification(string pathToSvnExe, string workingDirectory):base(pathToSvnExe, workingDirectory)
        {
            ParseOutput(base.GetInfo("status"));
        }

        private void ParseOutput(string output)
        {
            foreach (string item in output.ToLines())
            {
                // to do for M , ! , ? and others and make if else statement
                if (item[0].ToString() == "?")
                {
                    GetQuestionMark = item[0];

                }else if (item[0].ToString() == "M"){
                    GetModification = item[0];

                }else if (item[0].ToString() == "!")
                {
                    ExclamationMark = item[0];
                }
                else
                {
                    ErrorProblem = item;
                }
            }
        }

    }
}

