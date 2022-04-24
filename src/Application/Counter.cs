using FizzBuzz.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application
{
    
    public class Counter
    {
        private readonly FizzBuzzGame _game;

        public Counter()
        {
            _game = new FizzBuzzGame();
        }

        public void Game()
        {
            for (int irritatedNumber = 0; irritatedNumber < 1000000; irritatedNumber++)
            {
                _game.DivisibleTest(irritatedNumber);
            }
            throw new GameFinishedException();

        }

    }

    public class GameFinishedException : Exception
    {

    }
}
