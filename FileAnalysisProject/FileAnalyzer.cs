using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalysisProject
{
    internal class FileAnalyzer
    {
        private AnalysisResult AnalysisResult;
        public AnalysisResult GetResult() { return AnalysisResult; }
        public void SetResult(AnalysisResult result) {  AnalysisResult = result; }
        

    }
}
