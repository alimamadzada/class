using System;
using System.Collections.Generic;
using System.Text;
using static PracticeClasswork.Utility.Interface;
namespace PracticeClasswork
{
    class Word : IPrintableFile
    {
        public Word(string name,int WordCount)
        {
            FileName = name;
            this.WordCount = WordCount;
        }
        public int WordCount { get; set; }
        public string FileName { get; set; }

        public void Print()
        {
            Console.WriteLine($"{FileName} printed, WordCount = {WordCount}");
        }
    }
}
