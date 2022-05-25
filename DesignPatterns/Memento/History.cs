using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class History
    {
        private readonly List<EditorState> States = new();

        public void Push(EditorState state)
        {
            States.Add(state);  
        }

        public EditorState Pop()
        {
            var lastState = States.Last();
            States.Remove(lastState);

            return lastState;
        }
    }
}
