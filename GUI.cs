using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Control_Text_Version
{
    class GUI
    {
        private static bool isTitleShowed;
        public static void Output(bool lineBreak, params object[] objects)
        {
            foreach (Object obj in objects)
                if (lineBreak)
                    Console.WriteLine(obj);
                else
                    Console.Write(obj);                  
        }

        public static PlayerDecisionEnum WriteChoice(params string[] options)
        {
            int startY = isTitleShowed? 5 : 6;
            const int startX = 12;
            const int optionsPerLine = 2;
            const int spacingPerLine = 5;

            PlayerDecisionEnum currentDecision = 0;

            ConsoleKey key;

            Console.CursorVisible = false;

            do
            {
                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(startX + i % optionsPerLine * spacingPerLine, startY + i / optionsPerLine);

                    if (i == (int)currentDecision)
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write(options[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if ((int)currentDecision % optionsPerLine > 0)
                                currentDecision--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if ((int)currentDecision % optionsPerLine < optionsPerLine - 1)
                                currentDecision++;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;
            isTitleShowed = true;

            return currentDecision;
        }
    }
}
