using System;

namespace PracticeClasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Word w = new Word("Lesson.docx",25);
            PrintFile.Print(w);
        }
    }
}
