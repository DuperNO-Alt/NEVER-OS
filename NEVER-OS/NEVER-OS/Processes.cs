using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NEVER_OS
{
    internal class Processes
    {
        public static bool Taskbar(uint x, uint y, int taskbarheight, Canvas canvas)
        {
            try
            {
                int yStart = (int)y - taskbarheight;
                canvas.DrawFilledRectangle(Color.LightGray, 0, yStart, (int)x, (int)y);
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
