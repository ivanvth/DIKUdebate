namespace DIKUdebate
{
    public class DIKUprofessor : DIKUperson
    {
        public DIKUprofessor(string name, DIKUPreparation preparation) : base(name) {
            Preparation = preparation;
            MaxIntellect = 300;
            Intellect = 300;
            StrengthOfArgument = 30;
            CounterArgument = 20;
            CriticalArgument = 20;
        }

        public override void GetExperience()
        {
            System.Console.WriteLine("My power cannot be increased further.");
        }
        public override bool BeDrained(int amount) {
            if (CounterArgument > rand.Next(101)) {
                System.Console.WriteLine(Name + " dodged the drain!");
                return false;
            } else {
                Intellect -= amount / 2;
                return true;
            }
        }

        public override bool HasLost() {
            System.Console.WriteLine("I can not be defeated muahaha!");
            return false;
        }
    }
}