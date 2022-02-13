namespace DIKUdebate {
    public class DIKUstudent : DIKUperson {
        private int Semester {get; set;}
        public DIKUstudent(string name, DIKUpreparation preparation) : base(name) {
            Preparation = preparation;
            Semester = 1;
            MaxIntellect = 30;
            Intellect = 30;
            StrengthOfArgument = 3;
            CounterArgument = 10;
            CriticalArgument = 10;
        }

        public override void GetExperience() {
            Semester += 1;
            base.GetExperience();
        }
    }
}