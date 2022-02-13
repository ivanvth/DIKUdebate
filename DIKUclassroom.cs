namespace DIKUdebate {
    public class DIKUclassroom {
        public DIKUperson RunDebate(List<DIKUperson> persons) {
            List<DIKUperson> winners = new List<DIKUperson>();
            while (persons.Count + winners.Count > 1) {
                while (persons.Count >= 2) {
                    DIKUperson person1 = persons[0];
                    DIKUperson person2 = persons[1];
                    persons.RemoveRange(0,2);
                    winners.Add(Discussion(person1, person2));
                }
                if (persons.Count > 0) {
                    winners.Add(persons[0]);
                }
                persons = winners;
                winners = new List<DIKUperson>();
            }
            return persons[0];
        }
         public DIKUperson Discussion(DIKUperson person1, DIKUperson person2) {
            Console.WriteLine("Debate til drained!");
            int round = 1;
            DIKUperson current = person1;
            DIKUperson inactive = person2;
            while (!person1.HasLost() && !person2.HasLost()) {
                Console.WriteLine ("ROUND: {0}", round);
                current.Argue(inactive);
                var temp = current;
                current = inactive;
                inactive = temp;
                round++;
            }
            DIKUperson winner = (person1.HasLost()) ? person2 : person1;
            Console.WriteLine("The winner is: {0} ", winner);
            winner.GetExperience();
            return winner;
        }
    }
}