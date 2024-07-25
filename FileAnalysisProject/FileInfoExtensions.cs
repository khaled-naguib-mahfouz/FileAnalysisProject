using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalysisProject
{
    public static class FileInfoExtensions
    {
        public static bool IsTextFile(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == ".txt")
            {
                return true;
            }
            return false;
        }
        public static bool IsCsvFile(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == ".csv")
            {
                return true;
            }
            return false;
        }
    }
}
