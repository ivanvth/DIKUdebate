namespace DIKUdebate {
    public class Program {
        static void Main(string[] args)
        {
            DIKUperson dikustudent1 = new DIKUstudent("Albert", DIKUPreparation.ReadingSome);
            System.Console.WriteLine(dikustudent1);

            DIKUstudent dikustudent2 = new DIKUstudent("Berit", DIKUPreparation.ReadingSome);
            //System.Console.WriteLine(dikustudent2);
            //System.Console.WriteLine("beDrained(10).... " + dikustudent2.beDrained(10));
            System.Console.WriteLine(dikustudent2);

            DIKUperson dikustudent3 = new DIKUstudent("Debra", DIKUPreparation.ReadingNone);
            System.Console.WriteLine(dikustudent3);

            DIKUperson dikustudent4 = new DIKUstudent("Erik", DIKUPreparation.ReadingAll);
            System.Console.WriteLine(dikustudent4);

            DIKUperson dikustudent5 = new DIKUstudent("Franz", DIKUPreparation.ReadingNone);
            System.Console.WriteLine(dikustudent5);

            DIKUperson dikustudent6 = new DIKUstudent("George", DIKUPreparation.ReadingAll);
            System.Console.WriteLine(dikustudent6);

            System.Console.WriteLine();

            DIKUprofessor dikuprofessor = new DIKUprofessor("Caesar", DIKUPreparation.ReadingAll);
            //System.Console.WriteLine(Dikuprofessor);
            //System.Console.WriteLine("beDrained(10).... " + Dikuprofessor.beDrained(10));
            System.Console.WriteLine(dikuprofessor);

            System.Console.WriteLine();

            //dikustudent1.Argue(dikustudent2);
            //System.Console.WriteLine(dikustudent1);
            //System.Console.WriteLine(dikustudent2);
            List<DIKUperson> students = new List<DIKUperson>();
            students.Add(dikustudent1);
            students.Add(dikustudent2);
            students.Add(dikustudent3);
            students.Add(dikustudent4);
            students.Add(dikustudent5);
            students.Add(dikustudent6);

            DIKUclassroom classroom = new DIKUclassroom();
            //DIKUperson dinner1 = classroom.Discussion(dikustudent1, dikustudent2);
            //System.Console.WriteLine(winner1);
            //DIKUperson winner2 = classroom.Discussion(winner1, Dikuprofessor);
            //System.Consdle.WriteLine("First winner is: {0}, second winner is {1}", winner1, winner2);
            DIKUperson debateWinner = classroom.RunDebate(students);
            System.Console.WriteLine("ULTIMATE WINNER: {0}", debateWinner);
        }
    }
}