using System;
using System.Collections.Generic;
using System.Text;
using static PracticeClasswork.Utility.Interface;
namespace PracticeClasswork
{
    class Excel : IPrintableFile
    {
        public Excel(string name, int ColumnCount, int RowCount)
        {
            FileName = name;
            this.ColumnCount = ColumnCount;
            this.RowCount = RowCount;
        }
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
        public string FileName { get; set; }

        public void Print()
        {
            Console.WriteLine($"{FileName} printed, ColumnCount = {ColumnCount}, RowCount = {RowCount}");
        }
    }
}
