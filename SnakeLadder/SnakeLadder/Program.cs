using SnakeLadder;
using System;

namespace SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem");

            //method is non-static so we need to instantiate method
            //InitialPositionUC1 obj = new InitialPositionUC1();
            //obj.SnakeLadder();

            //DieRollUC2 objA = new DieRollUC2();
            //objA.SnakeLadder();

            //CheckOpationUC3 obj = new CheckOpationUC3();
            //obj.SnakeLadder();

            //WinningPostionUC4 obj=new WinningPostionUC4();
            //obj.SnakeLadder();

            //ExactWinningPostionUC5 exactWinningPostion = new ExactWinningPostionUC5();
            //exactWinningPostion.SnakeLadder();

            ReportPositionUC6 reportPosition = new ReportPositionUC6();
            reportPosition.SnakeLadder();
        }
    }
}