using System;
using DesignPatterns.BrushTool;
using DesignPatterns.Iterator;
using DesignPatterns.State;

#region Memento Pattern

// using DesignPatterns.Memento;

// var document = new Document();
// var history = new DocumentHistory();

// document.Content = "Test Content 1";
// document.FontName = "Arial";
// document.FontSize = 14;

// history.Push(document.CreateState());

// Console.WriteLine(document);

// document.Content = "Test Content 2";
// document.FontSize = 16;

// Console.WriteLine(document);

// document.Restore(history.Pop());

// Console.WriteLine(document);

#endregion

#region State Pattern

// var eraser = new Canvas(new EraserTool());
// var brush = new Canvas(new BrushTool());

// Console.WriteLine(eraser.MouseUp());
// Console.WriteLine(eraser.MouseDown());
// Console.WriteLine(brush.MouseUp());
// Console.WriteLine(brush.MouseDown());

#endregion

#region Iterator Pattern

var productCollection = new ProductCollection();
productCollection.Add(new Product(1, "Milk"));
productCollection.Add(new Product(2, "Bread"));
productCollection.Add(new Product(3, "Meat"));

var iterator = productCollection.CreateIterator();

while (iterator.HasNext())
{
    System.Console.WriteLine(iterator.Current());
    iterator.Next();
}

#endregion



Console.ReadKey();