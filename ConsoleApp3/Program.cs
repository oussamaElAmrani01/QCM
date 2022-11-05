using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.QCM;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Exam uml = new Exam(new DateTime(10/10/2001),30,"uml");

            QuestionChoixMultiple q1 = new QuestionChoixMultiple("1+1");
            q1.NouvelleProposition("5", false);
            q1.NouvelleProposition("4",false);
            q1.NouvelleProposition("2",true);

            uml.AjouterQuestionChoixMultiple(q1);
            uml.AfficherQuestionsChoixMultiple();

            Etudiant e1 = new Etudiant("Oussama El-Amrani","N1111111");

            e1.PasserExam(uml);

            e1.ExamNote();
        }
    }
}
