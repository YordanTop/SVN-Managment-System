﻿using DataBaseLayer.Models;
using DataBaseLayer.DTOs;
using DataConverter.Convert;
using DataRetrieving.SVN;
using Svn;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Services.SvnService
{
    public class SvnService: IService
    {

        public SvnService() 
        {
        }


        public string PcDirectoryInfo(string repository, string directory)
        {
            SvnModificationData data = new SvnModificationData(repository, directory);
            return data.ModificationInfo;
        }

        public void ConvertSvnStatusToCsv(Dictionary<Pctoline,string> svnInfo, string fileName)
        {
            CsvConverter<SvnStatusFiles> csvConver = new CsvConverter<SvnStatusFiles>()
            {
                FileSavingPath = fileName,
            };


            List<SvnStatusFiles> files = new List<SvnStatusFiles>();
            foreach (var computerDir in svnInfo.Keys)
            {
                foreach (string row in svnInfo[computerDir].ToLines())
                {
                    //row 0 - descripes status
                    //row 1 - descripes name
                    string[] slicedInfo = row.Split(' ');
                    slicedInfo = slicedInfo.Where(s => !s.Equals(" ")).ToArray();

                    files.Add(new SvnStatusFiles()
                    {
                        ModificationStatus = slicedInfo.First(),
                        FileName = slicedInfo.Last(),
                        ComputerName = computerDir.PcDirectory
                    });
                }
            }
            csvConver.SaveCsvFile(files);
        }

        public void ConvertSvnStatusToCsv(string svnInfo, string fileName, string computerDir)
        {
                CsvConverter<SvnStatusFiles> csvConver = new CsvConverter<SvnStatusFiles>()
                {
                    FileSavingPath = fileName,
                };

                List<SvnStatusFiles> files = new List<SvnStatusFiles>();
                foreach (string row in svnInfo.ToLines())
                {
                    //row 0 - descripes status
                    //row 1 - descripes name
                    string[] slicedInfo = row.Split(' ');
                    slicedInfo = slicedInfo.Where(s => !s.Equals(" ")).ToArray();

                    files.Add(new SvnStatusFiles() 
                                                  {
                                                    ModificationStatus = slicedInfo.First(),
                                                    FileName = slicedInfo.Last(),
                                                    ComputerName = computerDir
                                                  });
                }
                csvConver.SaveCsvFile(files);
        }
    }
}
