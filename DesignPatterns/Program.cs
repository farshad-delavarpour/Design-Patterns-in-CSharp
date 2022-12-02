using System;
using DesignPatterns.BrushTool;
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

var eraser = new Canvas(new EraserTool());
var brush = new Canvas(new BrushTool());

Console.WriteLine(eraser.MouseUp());
Console.WriteLine(eraser.MouseDown());
Console.WriteLine(brush.MouseUp());
Console.WriteLine(brush.MouseDown());

#endregion




Console.ReadKey();