namespace DIKUdebate {
    public class Program {
        static void Main(string[] args)
        {
            DIKUperson dikustudent1 = new DIKUstudent("Albert", DIKUPreparation.ReadingSome);
            DIKUstudent dikustudent2 = new DIKUstudent("Berit", DIKUPreparation.ReadingSome);
            DIKUperson dikustudent3 = new DIKUstudent("Debra", DIKUPreparation.ReadingNone);
            DIKUperson dikustudent4 = new DIKUstudent("Erik", DIKUPreparation.ReadingAll);
            DIKUperson dikustudent5 = new DIKUstudent("Franz", DIKUPreparation.ReadingNone);
            DIKUperson dikustudent6 = new DIKUstudent("George", DIKUPreparation.ReadingAll);
            DIKUprofessor dikuprofessor = new DIKUprofessor("Caesar", DIKUPreparation.ReadingAll);

            List<DIKUperson> students = new List<DIKUperson>();
            students.Add(dikustudent1);
            students.Add(dikustudent2);
            students.Add(dikustudent3);
            students.Add(dikustudent4);
            students.Add(dikustudent5);
            students.Add(dikustudent6);

            DIKUclassroom classroom = new DIKUclassroom();
            DIKUperson debateWinner = classroom.RunDebate(students);
            System.Console.WriteLine("ULTIMATE WINNER: {0}", debateWinner);
        }
    }
}