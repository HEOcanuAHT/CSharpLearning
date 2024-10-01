using System.Linq.Expressions;
using System.Security.Cryptography;

namespace TicTacToe
{
    internal class Program
    {
        static int[,] field = new int[3,3];
        static bool isGameOver = false;
        static bool isTurnX = true;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            while (!isGameOver) 
            {
                PrintField();
                CalcTurn();
            }  
        }
        static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("Используйте numpad. Ходят " + (isTurnX ? "X" : "O"));
            
            for (int i = 2; i >= 0; i--)
            {
                if (i == 1) Console.WriteLine("---+---+---");
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (j == 1) Console.Write("|");
                    Console.Write(" {0} ", field[i, j] == 0 ? " " : field[i, j] == 3 ? "O" : "X");
                    if (j == 1) Console.Write("|");
                }
                Console.WriteLine();
                if (i == 1) Console.WriteLine("---+---+---");
            }
        }

        static void CalcTurn()
        {
            try
            {
                var turn = (Convert.ToInt32(Console.ReadLine()) - 1);
                var x = turn / 3;
                var y = turn % 3;

                if (field[x, y] != 0) return;
                field[x, y] = isTurnX ? 5 : 3;
                CheckConditions();
                isTurnX = !isTurnX;
            } catch { return; };

        }
        static void CheckConditions()
        {
            // обойти поле на момент выигрыша и наличие свободных мест
            bool isFreeFields = false;

            int sumDiag1 = 0, sumDiag2 = 0, sumRow = 0, sumCol = 0;
            
            for (int i = 0; i < field.GetLength(0); i++)
            {
                sumRow = 0;
                sumCol = 0;
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    sumRow += field[i, j];
                    sumCol += field[j, i];
                    
                    if (i==j) sumDiag1 += field[i, j];
                    if (i+j == 2) sumDiag2 += field[i, j];

                    if (field[i, j] == 0 | field[j, i] == 0) isFreeFields = true;
                }
                if ((sumRow == 15) | (sumCol == 15) | (sumRow == 9) | (sumCol == 9))
                {
                    isGameOver = true;
                    PrintField();
                    Console.WriteLine("Игра окончена, победили " + (isTurnX ? "X" : "O"));
                    return;
                }
            }
            if ((sumDiag1 == 15) | (sumDiag2 == 15) | (sumDiag1 == 9) | (sumDiag2 == 9))
            {
                isGameOver = true;
                PrintField();
                Console.WriteLine("Игра окончена, победили " + (isTurnX ? "X" : "O"));
                return;
            }
            if (!isFreeFields)
            {
                isGameOver = true;
                PrintField();
                Console.WriteLine("Игра окончена, ничья!");
                return;
            }
        }
    }
}
