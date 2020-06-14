using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termproject
{
    public class Game
    {
        private Profile player;
        private Profile goalie;
        private DateTime date;
        private int duration;
        private int playerScore;
        private int goalieScore;

        public DateTime Date { get => date; set => date = value; }
        public int Duration { get => duration; set => duration = value; }
        public int PlayerScore { get => playerScore; set => playerScore = value; }
        public int GoalieScore { get => goalieScore; set => goalieScore = value; }
        internal Profile Player { get => player; set => player = value; }
        internal Profile Goalie { get => goalie; set => goalie = value; }
    }
}
