

namespace lab_02
{
    class Player : Person
    {
        string _position, _club; //jakie modyfikatory dostepu dobrac?
        int _scoreGoals;

        public string Position { get { return _position; } set { _position = value; } }
        public string Club { get { return _club; } set { _club = value; } }
        public int ScoreGoals { get { return _scoreGoals; } set { _scoreGoals = value; } }

        public Player() :base()
        {
            _position = string.Empty;
            _club = string.Empty;
            _scoreGoals = 0;
        }
        public Player(string FirstName, string LastName, DateTime DateOfBirth, string position, string club, int scoreGoals)
            : base(FirstName, LastName, DateOfBirth)
        {
            Position = position;
            Club = club;
            ScoreGoals = scoreGoals; 
        }

        public override string ToString() //overide bo napisujemy metode klasy pochodnej (polimorfizm)
        {
            return $"{base.ToString()}, Player | Position: {_position}, Club: {_club}, ScoreGoals: {_scoreGoals}";
        }

        public virtual void ScoreGoal()
        {
            _scoreGoals++;
        }
    }
}
