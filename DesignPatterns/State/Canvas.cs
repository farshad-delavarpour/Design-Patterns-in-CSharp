using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Canvas
    {
        public ITool? CurrentTool { get; set; }

        public void MouseDown()
        {
            CurrentTool?.MouseDown();
        }

        public void MouseUp()
        {
            CurrentTool?.MouseUp();
        }

    }
}
