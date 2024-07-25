using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalysisProject
{
    internal class TextFileAnalyzer : FileAnalyzer,IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
           String fileString= File.ReadAllText(fileInfo.FullName, Encoding.UTF8);
           AnalysisResult result = new AnalysisResult();
            var words=fileString.Split(new char[]{' ','\n','\r' });
            result.WordCount = words.Length;
            result.CharacterCount = fileString.Length;
            var lines = fileString.Split(new char[] {  '\n' });
            result.LineCount = lines.Length;
            SetResult(result);
        }
    }
}
