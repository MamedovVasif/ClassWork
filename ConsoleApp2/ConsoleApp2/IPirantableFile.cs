﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IPirantableFile
    {
        public string FileName { get; set; }
        public void Print();
    }
}
