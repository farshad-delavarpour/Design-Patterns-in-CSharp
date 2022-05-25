#region Iterator

using DesignPatterns.Iterator;

var history = new BrowseHistory();

history.Push("a");
history.Push("b");
history.Push("c");

var iterator = history.CreateIterator();

while (iterator.HasNext())
{
    var url = iterator.Current();
    Console.WriteLine(url);
    iterator.Next();
}

Console.ReadKey();

#endregion
