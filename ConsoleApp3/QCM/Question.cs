using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.QCM
{
    abstract class Question
    {
        public static char indexGlobal = 'A';
        public char index { get; }
        public string enonce { get; set; }
        
        public Question(string enonce)
        {
            this.enonce = enonce;
            index = indexGlobal;
            indexGlobal++;
        }
    }
}
