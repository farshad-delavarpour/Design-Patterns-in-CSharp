using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        private List<string> Urls { get; } = new List<string>();

        public void Push(string url) =>
            Urls.Add(url);

        public string Pop()
        {
            var lastUrl = Urls.LastOrDefault();
            if (lastUrl != null)
                Urls.Remove(lastUrl);
            return lastUrl;
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator : IIterator<string>
        {
            private readonly BrowseHistory _history;
            private int _index;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }

            public string Current()
            {
                return _history.Urls[_index];
            }

            public bool HasNext()
            {
                return _index < _history.Urls.Count;
            }

            public void Next() => _index++;
        }
    }


}
