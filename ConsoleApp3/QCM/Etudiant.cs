using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.QCM
{
    class Etudiant
    {
        public string NomComplet { get;}
        public string Cne { get;}
        public Dictionary<string, double> examsNote = new();
        // TO do: attribut :un type de liste contient deux column id d'exam et la note

        public Etudiant(string nomComplet, string cne)
        {
            NomComplet = nomComplet;
            Cne = cne;
        }

        public void PasserExam(Exam exam)
        {
            double note = 0;
            int nombreQuestion = exam.questionsChoixMultiples.Count;

            for (int i = 0; i < nombreQuestion; i++)
            {
                char indexQuestion;
                int indexProposition;
                Console.Write("Entrer l'index de la question");
                string consoleQuestion = Console.ReadLine();
                char.TryParse(consoleQuestion, out indexQuestion);

                Console.Write("Entrer l'index de la proposition");
                string consoleProposition = Console.ReadLine();
                int.TryParse(consoleProposition, out indexProposition);

                if (exam.questionsChoixMultiples.Find(x => x.index == indexQuestion).PropositionsList()
                        .Find(x => x.index == indexProposition).vrai == true)
                {
                    note++;
                }
            }

            note = note * (20 / nombreQuestion);
            examsNote.Add(exam.nom,note);
        }

        public void ExamNote()
        {
            Console.WriteLine($"Les exams et les note de {NomComplet}");

            foreach (KeyValuePair<string,double> examNote in examsNote)
            {
                Console.WriteLine($"exam {examNote.Key} note {examNote.Value}");
            }
        }
    }
}
