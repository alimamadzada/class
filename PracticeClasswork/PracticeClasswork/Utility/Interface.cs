using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeClasswork.Utility
{
    class Interface
    {
        public interface IPrintableFile
        {
            public string FileName { get; set; }
            void Print();
        }
    }
}
