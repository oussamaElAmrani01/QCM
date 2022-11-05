using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.QCM
{
    class Exam
    {
        public string nom { get; }
        public DateTime date_debut { get;}
        public int duree { get; }
        public List<QuestionChoixMultiple> questionsChoixMultiples = new();
        public List<QuestionOuverte> questionOuvertes = new();
        public int Note{ get; set; }

        public Exam(DateTime date_debut, int duree, string nom)
        {
            this.date_debut = date_debut;
            this.duree = duree;
            this.nom = nom;
        }

        public void AjouterQuestionChoixMultiple(QuestionChoixMultiple questionChoixMult)
        {
            questionsChoixMultiples.Add(questionChoixMult);
        }

        public void AfficherQuestionsChoixMultiple()
        {
            foreach (var question in questionsChoixMultiples)
            {
                Console.WriteLine(question.index + " " + question.enonce);

                foreach (var proposition in question.PropositionsList())
                {
                    Console.WriteLine(proposition.index + " " + proposition.contenu);
                }
            }
        }

        public void AjouterQuestionOuverte(QuestionOuverte questionOuvert)
        {
            questionOuvertes.Add(questionOuvert);
        }

        public void AfficherQuestionsOuverte()
        {
            foreach (var question in questionOuvertes)
            {
                Console.WriteLine(question.enonce);
            }
        }
    }
}
