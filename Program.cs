namespace DIKUdebate {
    public class Program {
        static void Main(string[] args) {
            DIKUperson dikustudent1 = new DIKUstudent("Albert", DIKUpreparation.ReadingSome);
            DIKUstudent dikustudent2 = new DIKUstudent("Bertha", DIKUpreparation.ReadingSome);
            DIKUperson dikustudent3 = new DIKUstudent("Caesar", DIKUpreparation.ReadingNone);
            DIKUperson dikustudent4 = new DIKUstudent("Debrah", DIKUpreparation.ReadingAll);
            DIKUperson dikustudent5 = new DIKUstudent("Erik", DIKUpreparation.ReadingNone);
            DIKUperson dikustudent6 = new DIKUstudent("Franz", DIKUpreparation.ReadingAll);

            DIKUprofessor dikuprofessor1 = new DIKUprofessor("George", DIKUpreparation.ReadingAll);
            DIKUprofessor dikuprofessor2 = new DIKUprofessor("Hansi", DIKUpreparation.ReadingAll);

            List<DIKUperson> students = new List<DIKUperson>();
            students.Add(dikustudent1);
            students.Add(dikustudent2);
            students.Add(dikustudent3);
            students.Add(dikustudent4);
            students.Add(dikustudent5);
            students.Add(dikustudent6);

            List<DIKUperson> persons = new List<DIKUperson>(students);
            persons.Add(dikuprofessor1);

            DIKUclassroom classroom = new DIKUclassroom();
            DIKUperson studentWinner = classroom.RunDebate(students);
            DIKUperson personWinner = classroom.RunDebate(persons);

            System.Console.WriteLine("ULTIMATE WINNER Bout #1: {0}", studentWinner);
            System.Console.WriteLine("ULTIMATE WINNER Bout #2: {0}", personWinner);
        }
    }
}