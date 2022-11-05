using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.QCM
{
    class QuestionChoixMultiple : Question
    {
        private List<Proposition> propositions = new();
        public int point { get; set; }

        public QuestionChoixMultiple(string enonce) : base(enonce)
        {
        }
        
        public void NouvelleProposition(String contenu,bool vrai)
        {
            propositions.Add(new Proposition(contenu,vrai));
        }

        public void SupprimerProposition(int index)
        {
            foreach (var prop in propositions)
            {
                if (prop.index == index)
                {
                    propositions.Remove(prop);
                }
            }
        }

        public List<Proposition> PropositionsList()
        {
            return propositions;
        }

        public void ChoisirProposition(int index)
        {
            foreach (var proposition in propositions)
            {
                if (proposition.index == index && proposition.vrai == true)
                {
                    point = 1;
                }
            }
        }

    }
}
