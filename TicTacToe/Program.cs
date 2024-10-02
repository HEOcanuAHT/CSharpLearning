using homeworkLib;

namespace TicTacToe
{
    internal class Program
    {
        static int[,] field = new int[3, 3];
        static bool isTurnX = true;
        static bool isGameOver = false;
        static string winer = "";

        static void Main(string[] args)
        {
            while (!isGameOver) 
            {
                PrintField();
                CalcTurn();
            }
            
            PrintField();
            Console.WriteLine("Игра окончена, " + (winer.Length == 0 ? "ничья!" : "победили " + winer));
            Console.WriteLine("Нажмите esc чтобы выйти");
            ConsoleKeyInfo presed = new();
            
            while (presed.Key != ConsoleKey.Escape)
                presed = Console.ReadKey();

        }
        static void PrintField()
        {
            Console.Clear();
            
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
            int turn = IO.GetNumber("Используйте numpad. Ходят " + (isTurnX ? "X" : "O"), 1, 9) -1;
            var x = turn / 3;
            var y = turn % 3;

            if (field[x, y] != 0) return;

            field[x, y] = isTurnX ? 5 : 3;
               
            CheckConditions();
            isTurnX = !isTurnX;
        }

        static void CheckConditions()
        {
            // обойти поле на момент выигрыша и наличие свободных мест
            bool isFreeFields = false;
            
            int sumDiag1 = 0, sumDiag2 = 0, sumRow, sumCol;

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

                    if (field[i, j] == 0 || field[j, i] == 0) isFreeFields = true;
                }
                if (sumRow == 15 || sumCol == 15 || sumRow == 9 || sumCol == 9)
                {
                    isGameOver = true;
                    winer = (isTurnX ? "X" : "O");
                    break;
                }
            }

            if (sumDiag1 == 15 || sumDiag2 == 15 || sumDiag1 == 9 || sumDiag2 == 9)
            {
                isGameOver = true;
                winer = (isTurnX ? "X" : "O");
            }
            else if (!isFreeFields) 
                isGameOver = true;
        }
    }
}
