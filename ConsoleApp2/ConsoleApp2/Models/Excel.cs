using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Excel:IPirantableFile
    {
        public int ColoumnCount { get; set; }
        public int RowCount { get; set; }
        public string FileName { get; set; }

        public Excel(int ColoumnCount,int RowCount)
        {
            this.ColoumnCount = ColoumnCount;
            this.RowCount = RowCount;
        }

        public void Print()
        {
           // Console.WriteLine(""); ;
        }
    }
}
