using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    internal class GameResult
    {
        private int _scorePlayer1;
        private int _scorePlayer2;

        public int GetScorePlayer1()
        {
            return _scorePlayer1;
        }

        public void SetScorePlayer1(int scorePlayer1)
        {
            _scorePlayer1 = scorePlayer1;
        }

        public int GetScorePlayer2()
        {
            return _scorePlayer2;
        }

        public void SetScorePlayer2(int scorePlayer2)
        {
            _scorePlayer2 = scorePlayer2;
        }

        public GameResult()
        {
            this._scorePlayer1 = 0;
            this._scorePlayer2 = 0;
        }
    }
}
