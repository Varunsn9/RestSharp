using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp.Generic.Main
{
    public class IPathConstants : BaseClass
    {

        public static string currentDirectory = Directory.GetCurrentDirectory();
        public static string parentDirectory = Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName;
        public static string IcsvPath = Path.Combine(parentDirectory, "RestSharp","Main_Resources","CsvData.csv");
        //should be const for data source
        public const string excelPath = @"D:\VisualStudioRepos\AzureDevOps\RestSharp\RestSharp\Main_Resources\VTiger.xlsx";
        public const string csvPath = @"D:\VisualStudioRepos\AzureDevOps\RestSharp\RestSharp\Main_Resources\CsvData.csv";
    }

}
