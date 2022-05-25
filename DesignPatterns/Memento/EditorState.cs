using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class EditorState
    {
        public EditorState(string content)
        {
            Content = content;
        }

        public string Content { get; set; }
    }
}
