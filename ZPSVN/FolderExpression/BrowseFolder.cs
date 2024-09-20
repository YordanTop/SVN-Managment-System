using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderExpression
{
    public static class BrowseFolder
    {

        public static string GetFolder()
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            DialogResult result = browserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browserDialog.SelectedPath))
            {
                return browserDialog.SelectedPath;
            }
            return null;
        } 
        public static string GetFile(string expectedFile)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult dialogResult = fileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                string file = fileDialog.FileName.Split('\\').Last();

                if (file != expectedFile)
                {
                    MessageBox.Show($"You must select a file \"{expectedFile}\".");
                    return null;
                }
            }
            return fileDialog.FileName;
        }

        public static string SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return "Unknown";
        }
    }
}
