using ConsoleApp2.Models;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Word w1 = new Word(17);
            PrintFile p1 = new PrintFile();
            p1.Print(w1);
        }
    }
}
