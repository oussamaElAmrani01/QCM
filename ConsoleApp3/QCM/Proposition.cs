using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.QCM
{
    class Proposition
    {
        public bool vrai { get; set; }
        public string contenu { get; set; }
        public int index { get; set; }
        public Certitude certidude { get; set; }

        public static int nombrePropositions = 0;

        internal Proposition(string contenu, bool vrai)
        {
            this.contenu = contenu;
            this.vrai = vrai;
            this.index = nombrePropositions;
            nombrePropositions++;
        }
    }
}
