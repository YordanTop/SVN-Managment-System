using Svn;
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;


namespace DataRetrieving.SVN
{
    public class SvnInfoCommands:SvnProgramExecution
    {
        public string Path { get; set; }

        public string Url { get; set; }

        public string RelativeUrl { get; set; }

        public string RepositoryRoot { get; set; }

        public string RepositoryUuid { get; set; }

        public string Revision { get; set; }

        public string NodeKind { get; set; }

        public string LastChangedAuthor { get; set; }

        public string LastChangedRev { get; set; }

        public string LastChangedDate { get; set; }

        public string Schedule { get; set; }

        public string LockToken { get; set; }

        public string LockOwner { get; set; }

        public string LockCreated { get; set; }

    
        public SvnInfoCommands(string pathToSvnExe, string workingDirectory):base(pathToSvnExe,workingDirectory)
        {
            ParseOutput(base.GetInfo("info"));
        }

        private string GetPropertyNameFromExpression<T>(Expression<Func<T, string>> propertyExpression)
        {
            MemberExpression memberExpression;
            if ((memberExpression = propertyExpression.Body as MemberExpression) == null || memberExpression.Member.MemberType != MemberTypes.Property)
            {
                return null;
            }

            return memberExpression.Member.Name;
        }

        private void SetPropertyValueAfterLineSubString(string line, Expression<Func<SvnInfoCommands, string>> expression, string path)
        {
            if (line.StartsWith(path, StringComparison.OrdinalIgnoreCase))
            {
                string value = line.Substring(path.Length);
                string propertyNameFromExpression = GetPropertyNameFromExpression(expression);
                if (propertyNameFromExpression != null)
                {
                    typeof(SvnInfoCommands).GetProperty(propertyNameFromExpression)?.SetValue(this, value);
                }
            }
        }

        
        private void ParseOutput(string output)
        {
            foreach (string item in output.ToLines())
            {
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.Path, "Path: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.Url, "URL: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.RelativeUrl, "Relative URL: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.RepositoryRoot, "Repository Root: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.RepositoryUuid, "Repository UUID: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.Revision, "Revision: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.NodeKind, "Node Kind: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.LastChangedAuthor, "Last Changed Author: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.LastChangedRev, "Last Changed Rev: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.LastChangedDate, "Last Changed Date: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.Schedule, "Schedule: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.LockToken, "Lock Token: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.LockOwner, "Lock Owner: ");
                SetPropertyValueAfterLineSubString(item, (SvnInfoCommands x) => x.LockCreated, "Lock Created: ");
             
            }
        }

    }
}

