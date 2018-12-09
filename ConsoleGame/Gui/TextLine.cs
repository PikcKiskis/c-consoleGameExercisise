﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9.GUI
{
    class TextLine : GuiObject
    {
        private string data;


        public TextLine(int x, int y, int width, string data) : base(x, y, width, 0)
        {
            this.data = data;
        }

        public void Render()
        {
            Console.SetCursorPosition(x, y);
            if (width > data.Length)
            {
                int offset = (width - data.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }

            Console.Write(data);
        }
    }
}
