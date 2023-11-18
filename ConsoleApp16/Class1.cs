using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Scoropechatanie
    {
        public Scoropechatanie()
        {
            x = 0;
            y = 0;
            Console.WriteLine(text);
        }
        private const string text = "Сейчас из решетки доставки лабораторного оборудования появится грузовой куб. В этом испытании грузовой куб станет вашим верным спутником. Заботьтесь о нем, как о друге. Испытания часто вызывают такие побочные эффекты, как мнительность, галлюцинации и одушевление неодушевленных предметов. Экспериментальный центр напоминает вам о том, что грузовой куб не может угрожать перерезать вам горло и даже не умеет говорить.";
        public static int x = 0;
        public static int y = 0;
        public bool Test()
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Green;
                ConsoleKeyInfo key = Console.ReadKey();
                while (key.KeyChar != text[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(x, y);
                    Console.Write(text[i]);
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Green;
                    key = Console.ReadKey();
                }
                x++;
                if (x == Console.WindowWidth)
                {
                    y++;
                    x = 0;
                }
            }
            return true;
        }
    }
}
