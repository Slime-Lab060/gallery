using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{

    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }

        public static void ShowSpinner()
        {
            var counter = 0;
            for (int i = 0; i < 18; i++)
            {
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                counter++;
                Thread.Sleep(100);
            }
        }

        public static void ColorfulAnimation()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Clear();

                    // steam
                    Console.Write("       . . . . o o o o o o", Color.LightGray);
                    for (int s = 0; s < j / 2; s++)
                    {
                        Console.Write(" o", Color.LightGray);
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);
                    Console.WriteLine(margin + "                _____      o", Color.LightGray);
                    Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.", Color.DeepSkyBlue);
                    Console.WriteLine(margin + "      [________]_|__|________)< ", Color.DeepSkyBlue);
                    Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_", Color.Blue);
                    Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);

                    Thread.Sleep(50);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] Colors // すべての色を列挙
            = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            bool endApp = false;
            // Display title as the C# console calculator app.

            String str = @"
                       .d,
                      .Wkk,
                     .qkkkq;
                    .kkkkkkq[
                   Jkkqkkqkkqn
                 .XkkkqkkkkkkkL
                .kqkkkkqkkkqkkkh
               .kkkqkkqkkkkqkkkkh.
              Jkkkkkkkkqkkkkkkqkkh.
            .XkkkkqkkkqkkkqkkkkkkkH.
           .kkqkkkqkkkkqkkkqkkkkkkkH,
          .kkkqkkkkqkkqkkkkkkqkqkkkkH,
         .....(-(-((((-/~(<<;;;<<<<<<<.
       .W;?MMMMMMMMMMMMMe?kkkkkkkkkkkkq;
      .kkkl?MMMMMMMMMMMMMp(kkkkkkkkkkkkq[
     (kkkqkn(MMMMMMMMMMMMMb-kkkkkkkqkkkkqn
   .dkkkkkkkL,MMMMMNMMNMMMMb,HkqkkkkkkkkkqL
  .Wkqkkqkqkkh,MMMMMMMMMMMMMh,Hkkqkkqkkqkkkh
 .qkkkqkkqkkkkh,MMMMMMMMMMMMMN,Wkkkkkkkkkkkkh.
  4kkkkkkkkkkkqh,MMNMMNMMNMMMMN,4kkqkkqkkkkkkh.
   4kqkkkqkkqkkkW,WMMMMMMMMMMMMN,4kkkkkkqkkqkkH.
    4qkkqkkkkkqkkH,WMMMMMMNMMMMMN,4kkqkkkkkkkkkH,
     TqkkkqkkkqkkkH,UMMNMMMMNMMMMM,Tkkkkkqkkqkkq=
      ?kkqkkkkqkkkkk,TMMMMMMMMMMMMM,jkkqkkkkkkH^
       ?kkqkkkkkkkkkk;?MMMMMMNMMMMMMe?kkkkqkkK!
        (qkkkqqkkkqkkkl?MMNMMMMNMMMMMp(kkkkqY
         -kkkkqkkkqkkqkn(MMMMMMMMMMMMMb(kkk=
          ,HkkkkkkkqkkkkL,MMMMMMMNMMMMMb,W'
            `````````````` ~~~~~~~~~~~~~ ";

            Console.WriteLine("\u001b[94m                       .d,");
            Console.WriteLine("                      .Wkk,");
            Console.WriteLine("                     .qkkkq;");
            Console.WriteLine("                    .kkkkkkq[");
            Console.WriteLine("                   Jkkqkkqkkqn");
            Console.WriteLine("                 .XkkkqkkkkkkkL");
            Console.WriteLine("                .kqkkkkqkkkqkkkh");
            Console.WriteLine("               .kkkqkkqkkkkqkkkkh.");
            Console.WriteLine("              Jkkkkkkkkqkkkkkkqkkh.");
            Console.WriteLine("            .XkkkkqkkkqkkkqkkkkkkkH.");
            Console.WriteLine("           .kkqkkkqkkkkqkkkqkkkkkkkH,");
            Console.WriteLine("          .kkkqkkkkqkkqkkkkkkqkqkkkkH,");
            Console.WriteLine("         .....(-(-((((-/~(<<;;;<<<<<<<.");
            Console.WriteLine("       .W;,\u001b[34mMMMMMMMMMMMMMe\u001b[94m?kkkkkkkkkkkkq;");
            Console.WriteLine("      .kkkl,\u001b[34mMMMMMMMMMMMMMp\u001b[94m(kkkkkkkkkkkkq[");
            Console.WriteLine("     (kkkqkn,\u001b[34mMMMMMMMMMMMMMb\u001b[94m-kkkkkkkqkkkkqn");
            Console.WriteLine("   .dkkkkkkkL,\u001b[34mMMMMMNMMNMMMMb,\u001b[94mHkqkkkkkkkkkqL");
            Console.WriteLine("  .Wkqkkqkqkkh,\u001b[34mMMMMMMMMMMMMMh,\u001b[94mHkkqkkqkkqkkkh");
            Console.WriteLine(" .qkkkqkkqkkkkh,\u001b[34mMMMMMMMMMMMMMN,\u001b[94mWkkkkkkkkkkkkh.");
            Console.WriteLine("  4kkkkkkkkkkkqh,\u001b[34mMMNMMNMMNMMMMN,\u001b[94m4kkqkkqkkkkkkh.");
            Console.WriteLine("   4kqkkkqkkqkkkW,\u001b[34mWMMMMMMMMMMMMN,\u001b[94m4kkkkkkqkkqkkH.");
            Console.WriteLine("    4qkkqkkkkkqkkH,\u001b[34mWMMMMMMNMMMMMN,\u001b[94m4kkqkkkkkkkkkH,");
            Console.WriteLine("     TqkkkqkkkqkkkH,\u001b[34mUMMNMMMMNMMMMM,\u001b[94mTkkkkkqkkqkkq=");
            Console.WriteLine("      ?kkqkkkkqkkkkk,\u001b[34mTMMMMMMMMMMMMM,\u001b[94mjkkqkkkkkkH^");
            Console.WriteLine("       ?kkqkkkkkkkkkk;\u001b[34m?MMMMMMNMMMMMMe\u001b[94m?kkkkqkkK!");
            Console.WriteLine("        (qkkkqqkkkqkkkl\u001b[34m?MMNMMMMNMMMMMp\u001b[94m(kkkkqY");
            Console.WriteLine("         -kkkkqkkkqkkqkn\u001b[34m(MMMMMMMMMMMMMb\u001b[94m(kkk=");
            Console.WriteLine("          ,HkkkkkkkqkkkkL,\u001b[34mMMMMMMMNMMMMMb,\u001b[94mW'");
            Console.WriteLine("            `````````````` \u001b[34m~~~~~~~~~~~~~\u001b[0m");
            Console.WriteLine("\u001b[94m"+str+"\u001b[0m");

            while (!endApp)
            {
                //Console.ForegroundColor = bg;
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                // Declare variables and set to empty.
                string numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("a - Add");
                Console.WriteLine("s - Subtract");
                Console.WriteLine("m - Multiply");
                Console.WriteLine("d - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");

                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.


            }
            var task = Delay(Colors);
            Console.WriteLine(task.Result);
            static async Task<int> Delay(ConsoleColor[] colors)
            {
                int a=0;

                for (int i = 0; i <= 5; i++)
                {
                    foreach (ConsoleColor bg in colors)
                    {
                        Console.Beep(262, 100);

                        await Task.Delay(50);
                        Console.BackgroundColor = bg;
                        Console.WriteLine();

                    }
                    a += i;
                }
                return a;
            }
            Console.ResetColor();
            Console.Clear();
            Calculator.ShowSpinner();
            Calculator.ColorfulAnimation();
            Console.WriteLine("Enterキーを押してください。");
            Console.ReadKey();
            return;
        }
    }
}