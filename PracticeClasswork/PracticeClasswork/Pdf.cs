using System;
using System.Collections.Generic;
using System.Text;
using static PracticeClasswork.Utility.Interface;

namespace PracticeClasswork
{
    class Pdf : IPrintableFile
    {
        public Pdf(string name,int PageCount)
        {
            FileName = name;
            this.PageCount=PageCount;
        }
        public int PageCount { get; set; }
        public string FileName { get; set; }

        public void Print()
        {
            Console.WriteLine($"{FileName} printed, Page count = {PageCount}");
        }
    }
}
