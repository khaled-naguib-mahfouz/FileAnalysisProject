using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalysisProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome, please enter folder path to analyze");
            string inputFolder = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);
            if (! directoryInfo.Exists ) {
                Console.WriteLine("folder doesn't exist");
                return;
            }
           var filenames = directoryInfo.GetFiles();
            IFileAnalysis fileAnalysis = null;
            foreach ( var filename in filenames )
            {
                if(filename.IsTextFile())
                {
                    fileAnalysis = new TextFileAnalyzer();
                }
                else if (filename.IsCsvFile()){
                     
                    fileAnalysis =new CSVFileAnalyzer();
                }
                var results = ((FileAnalyzer)fileAnalysis).GetResult();
                Console.WriteLine($"file name : {filename.Name}");
                Console.WriteLine($"word count : {results.WordCount}");
                Console.WriteLine($"charactr count : {results.CharacterCount}");
                Console.WriteLine($"line count : {results.LineCount}");

            }
        }
    }
}
