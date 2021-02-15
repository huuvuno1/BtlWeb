using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace BtlWeb.Utils
{
    public class FileIO
    {
        public static string readFileJson(string fileName)
        {
            FileStream file = new FileStream(@"C:\Users\s2huu\source\repos\BtlWeb\BtlWeb\Repository\DBJson\user.json", FileMode.Open);
            StreamReader reader = new StreamReader(file, Encoding.UTF8);
            string value = reader.ReadToEnd();
            return value;
        }

        public static string writeFileJson(string fileName)
        {
            return "";
        }
    }
}