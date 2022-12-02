using System;

# region Memento

using DesignPatterns.Memento;

var document = new Document();
var history = new DocumentHistory();

document.Content = "Test Content 1";
document.FontName = "Arial";
document.FontSize = 14;

history.Push(document.CreateState());

Console.WriteLine(document);

document.Content = "Test Content 2";
document.FontSize = 16;

Console.WriteLine(document);

document.Restore(history.Pop());

Console.WriteLine(document);

#endregion


Console.ReadKey();