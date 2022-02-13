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

        public virtual void getExperience() {
            System.Console.WriteLine(this + " gained experience!");
            StrengthOfArgument += 2;
            
            if (Preparation == DIKUPreparation.ReadingNone) {
                MaxIntellect += 20;
            } else {
                MaxIntellect += 10;
            }
            
            if (Preparation == DIKUPreparation.ReadingAll || Preparation == DIKUPreparation.ReadingSome) {
                CounterArgument += 6;
            } else {
                CounterArgument += 3;
            }

            if (Preparation == DIKUPreparation.ReadingAll) {
                CriticalArgument += 6;
            } else {
                CriticalArgument += 3;
            }

            Intellect = MaxIntellect;
        }
        public void Argue(DIKUperson opponent) {
            int attackStrength = StrengthOfArgument;
            if (CriticalArgument > rand.Next(101)) {
                System.Console.WriteLine("{0} strikes an argument at {1} for {2} points of draining.", Name, opponent.Name, StrengthOfArgument * 2);
                attackStrength *= 2;
            } else {
                System.Console.WriteLine("{0} strikes an argument at {1} for {2} points of draining.", Name, opponent.Name, StrengthOfArgument);
            }
            opponent.beDrained(attackStrength);
        }
        public virtual bool beDrained(int amount) {
            if (CounterArgument > rand.Next(101)) {
                System.Console.WriteLine(Name + " dodged the drain!");
                return false;
            } else {
                Intellect -= amount;
                return true;
            }
        }

        public virtual bool HasLost() {
            if (Intellect <= 0) {
                return true;
            }
            return false;
        }

        override public string ToString() {
            return String.Format("{0}: Intellect: {1} [{2}]", Name, Intellect, this.GetType());
        }
    }
}