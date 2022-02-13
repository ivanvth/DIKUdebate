namespace DIKUdebate
{
    public class DIKUperson
    {
        protected string Name {get; set;}
        protected int MaxIntellect {get; set;}
        protected int Intellect {get; set;}
        protected int StrengthOfArgument {get; set;}
        
        protected int CounterArgument {get; set;}
        protected int CriticalArgument {get; set;}
        protected DIKUPreparation Preparation {get; set;}

        protected Random rand = new Random();
        public DIKUperson(string name) {
            Name = name;
        }

        public virtual void GetExperience() {
            System.Console.WriteLine(this + " gained experience!");
            StrengthOfArgument += 2;
            MaxIntellect += (Preparation == DIKUPreparation.ReadingNone) ? 20 : 10;
            CounterArgument += (Preparation == DIKUPreparation.ReadingAll || Preparation == DIKUPreparation.ReadingSome) ? 6 : 3;
            CriticalArgument += (Preparation == DIKUPreparation.ReadingAll) ? 6 : 3;
            Intellect = MaxIntellect;
        }
        public void Argue(DIKUperson opponent) {
            int attackStrength = StrengthOfArgument;
            if (CriticalArgument > rand.Next(101)) {
                attackStrength *= 2;
                System.Console.WriteLine("{0} strikes an argument at {1} for {2} points of draining.", Name, opponent.Name, attackStrength);
            } else {
                System.Console.WriteLine("{0} strikes an argument at {1} for {2} points of draining.", Name, opponent.Name, attackStrength);
            }
            opponent.BeDrained(attackStrength);
        }
        public virtual bool BeDrained(int amount) {
            if (CounterArgument > rand.Next(101)) {
                System.Console.WriteLine(Name + " dodged the drain!");
                return false;
            } else {
                Intellect -= amount;
                return true;
            }
        }

        public virtual bool HasLost() {
            return Intellect <= 0;
        }

        override public string ToString() {
            return String.Format("{0}: MaxIntellect: {1} [{2}]", Name, MaxIntellect, this.GetType());
        }
    }
}