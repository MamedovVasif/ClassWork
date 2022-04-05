using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Word:IPirantableFile
    {
        public int WordCount { get; set; }
        public string FileName { get; set; }

        public Word(int WordCount)
        {
            this.WordCount = WordCount;
        }

        public void Print()
        {
            Console.WriteLine($"{FileName}        {WordCount}") ;
        }
    }
}
