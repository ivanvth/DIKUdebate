namespace DIKUdebate {
    public class Program {
        static void Main(string[] args)
        {
            DIKUperson Dikustudent1 = new DIKUstudent("Albert", DIKUPreparation.ReadingSome);
            System.Console.WriteLine(Dikustudent1);

            DIKUstudent Dikustudent2 = new DIKUstudent("Berit", DIKUPreparation.ReadingSome);
            //System.Console.WriteLine(Dikustudent2);
            //System.Console.WriteLine("beDrained(10).... " + Dikustudent2.beDrained(10));
            System.Console.WriteLine(Dikustudent2);

            DIKUperson Dikustudent3 = new DIKUstudent("Debra", DIKUPreparation.ReadingNone);
            System.Console.WriteLine(Dikustudent3);

            DIKUperson Dikustudent4 = new DIKUstudent("Erik", DIKUPreparation.ReadingAll);
            System.Console.WriteLine(Dikustudent4);

            DIKUperson Dikustudent5 = new DIKUstudent("Franz", DIKUPreparation.ReadingNone);
            System.Console.WriteLine(Dikustudent5);

            DIKUperson Dikustudent6 = new DIKUstudent("George", DIKUPreparation.ReadingAll);
            System.Console.WriteLine(Dikustudent6);

            System.Console.WriteLine();

            DIKUprofessor Dikuprofessor = new DIKUprofessor("Caesar", DIKUPreparation.ReadingAll);
            //System.Console.WriteLine(Dikuprofessor);
            //System.Console.WriteLine("beDrained(10).... " + Dikuprofessor.beDrained(10));
            System.Console.WriteLine(Dikuprofessor);

            System.Console.WriteLine();

            //Dikustudent1.Argue(Dikustudent2);
            //System.Console.WriteLine(Dikustudent1);
            //System.Console.WriteLine(Dikustudent2);
            List<DIKUperson> students = new List<DIKUperson>();
            students.Add(Dikustudent1);
            students.Add(Dikustudent2);
            students.Add(Dikustudent3);
            students.Add(Dikustudent4);
            students.Add(Dikustudent5);
            students.Add(Dikustudent6);

            DIKUclassroom classroom = new DIKUclassroom();
            //DIKUperson winner1 = classroom.Discussion(Dikustudent1, Dikustudent2);
            //System.Console.WriteLine(winner1);
            //DIKUperson winner2 = classroom.Discussion(winner1, Dikuprofessor);
            //System.Console.WriteLine("First winner is: {0}, second winner is {1}", winner1, winner2);
            DIKUperson debateWinner = classroom.RunDebate(students);
            System.Console.WriteLine("ULTIMATE WINNER: {0}", debateWinner);
        }
    }
}