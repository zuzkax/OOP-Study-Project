namespace lab_02
{
    class FootballPlayer : Player
    {
      public FootballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
        : base(firstName, lastName, dateOfBirth, position, club, scoredGoals) { }

        public override void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Football player score goal");
        }
    }
}
