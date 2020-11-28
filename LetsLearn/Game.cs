using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsLearn
{
    public class Game
    {
        #region var init
        /// <summary>
        /// Keeps track of the game type
        /// </summary>
        public int gameType { get; set; }

        /// <summary>
        /// Random number 1
        /// </summary>
        private int ranNum1;

        /// <summary>
        /// Random number 2
        /// </summary>
        private int ranNum2;

        /// <summary>
        /// The add string that we store the addition result into
        /// </summary>
        public string addString;

        /// <summary>
        /// Boolean to keep track of if the users answer is correct or not
        /// </summary>
        public bool correctAnswer = false;

        /// <summary>
        /// Keeps track of how many answers the user got correct
        /// </summary>
        public int correctCount = 0;

        /// <summary>
        /// Keeps track of how many answers the user got wrong
        /// </summary>
        public int incorrectCount = 0;



        /// <summary>
        /// Random number init
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// A public var to store the private ranNum1
        /// </summary>
        public int oper1;

        /// <summary>
        /// A public var to store the private ranNum2
        /// </summary>
        public int oper2;

        /// <summary>
        /// Storing the answer to the math operation
        /// </summary>
        public int ans;

        /// <summary>
        /// Final time it took to finish
        /// </summary>
        public string finalTime;

        #endregion var init

        public void setTime(string t)
        {
            finalTime = t;
        }
        #region math operations
        /// <summary>
        /// The addition method
        /// </summary>
        public void mathAdd()
        {
            ranNum1 = randomNumberGenerator();
            ranNum2 = randomNumberGenerator();

            oper1 = ranNum1;
            oper2 = ranNum2;

            ans = oper1 + oper2;
        }

        /// <summary>
        /// The subtraction method
        /// </summary>
        public void mathSubtract()
        {
            ranNum1 = randomNumberGenerator();
            ranNum2 = randomNumberGenerator();

            if (ranNum1 > ranNum2)
            {
                oper1 = ranNum1;
                oper2 = ranNum2;
            }
            else
            {
                oper1 = ranNum2;
                oper2 = ranNum1;
            }

            ans = oper1 - oper2;

        }

        /// <summary>
        /// The multiplication method
        /// </summary>
        public void mathMultiply()
        {
            ranNum1 = randomNumberGenerator();
            ranNum2 = randomNumberGenerator();

            oper1 = ranNum1;
            oper2 = ranNum2;

            ans = oper1 * oper2;
        }

        /// <summary>
        /// The division method
        /// </summary>
        public void mathDivide()
        {
            ranNum1 = randomNumberGenerator();
            ranNum2 = randomNumberGenerator();

            oper1 = (ranNum1 * ranNum2);
            oper2 = ranNum1;


            ans = oper1 / oper2;
            // 3 * 7 = 21 / 3 = 7

        }

        #endregion math operations

        /// <summary>
        /// Generates random numbers 
        /// </summary>
        /// <returns></returns>
        public int randomNumberGenerator()
        {
            return random.Next(1, 10);
        }

        public void checkMath(int userAns)
        {
           

            if (gameType == 1)
            {
                if(ans == userAns)
                {
                    correctAnswer = true;
                    correctCount++;
                }
                else
                {
                    correctAnswer = false;
                    incorrectCount++;
                }
            }
            else if (gameType == 2)
            {
                if (ans == userAns)
                {
                    correctAnswer = true;
                    correctCount++;
                }
                else
                {
                    correctAnswer = false;
                    incorrectCount++;
                }
            }
            else if(gameType == 3)
            {
                if (ans == userAns)
                {
                    correctAnswer = true;
                    correctCount++;
                }
                else
                {
                    correctAnswer = false;
                    incorrectCount++;
                }
            }
            else
            {
                if (ans == userAns)
                {
                    correctAnswer = true;
                    correctCount++;
                }
                else
                {
                    correctAnswer = false;
                    incorrectCount++;
                }
            }
        }// end checkMath

    }
}
