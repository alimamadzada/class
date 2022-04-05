using System;
using System.Collections.Generic;
using System.Text;
using static PracticeClasswork.Utility.Interface;
namespace PracticeClasswork
{
    class PrintFile<T>
    {
        public string FileName { get; set; }

        public static void Print(IPrintableFile file)
        {
            file.Print();
        }
    }
}
