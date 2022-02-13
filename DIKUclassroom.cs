namespace DIKUdebate
{
    public class DIKUclassroom
    {
        public DIKUperson RunDebate(List<DIKUperson> persons) {
            List<DIKUperson> contestants = persons;
            List<DIKUperson> winners = new List<DIKUperson>();
            int fight = 0;
            while (contestants.Count + winners.Count > 1) {
                while (contestants.Count >= 2) {
                    DIKUperson person1 = contestants[0];
                    DIKUperson person2 = contestants[1];
                    contestants.RemoveRange(0,2);
                    winners.Add(Discussion(person1, person2));
                    fight++;
                    System.Console.WriteLine(fight);
                }
                if (contestants.Count > 0) {
                    winners.Add(contestants[0]);
                }
                contestants = winners;
                winners = new List<DIKUperson>();
            }
            return contestants[0];
        }
         public DIKUperson Discussion(DIKUperson person1, DIKUperson person2) {
            Console.WriteLine("Debate til drained!");
            int round = 1;
            DIKUperson current = person1;
            DIKUperson inactive = person2;
            // Argue until someone is too drained
            // of Intellect to keep on.
            while (!person1.HasLost() && !person2.HasLost())
            {
                Console.WriteLine ("ROUND: {0}", round);
                current.Argue(inactive);
                var temp = current;
                current = inactive;
                inactive = temp;
                round++;
            }
            DIKUperson winner = (person1.HasLost()) ? person2 : person1;
            Console.WriteLine ("The winner is: {0} ", winner);
            // Make the winning student get experience
            // Then return the winning student .
            winner.getExperience();
            return winner;
        }
    }
}