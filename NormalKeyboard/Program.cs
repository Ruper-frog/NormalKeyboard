using System;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Input;
using System.Xml.Schema;

namespace NormalKeyboard
{
    internal class Program
    {
        static void RunKeyboardClass(ref string readLine, int x_Axis, int y_Axis)
        {
            Keyboard KeyboardClass = new Keyboard(readLine, x_Axis, y_Axis);
            KeyboardClass.Call(ref readLine);
        }
        static void Main(string[] args)
        {
            string str = "";

            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            RunKeyboardClass(ref str, x, y);

            Console.WriteLine();

            Console.WriteLine(str);
        }
        //Console.CursorVisible = false;
    }
}
