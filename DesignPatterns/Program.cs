using System;
using DesignPatterns.BrushTool;
using DesignPatterns.Command;
using DesignPatterns.Iterator;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.TemplateMethod;

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

// var productCollection = new ProductCollection();
// productCollection.Add(new Product(1, "Milk"));
// productCollection.Add(new Product(2, "Bread"));
// productCollection.Add(new Product(3, "Meat"));

// var iterator = productCollection.CreateIterator();

// while (iterator.HasNext())
// {
//     System.Console.WriteLine(iterator.Current());
//     iterator.Next();
// }

#endregion

#region Strategy Pattern

// var chatClient = new ChatClient(new AESEncryption());
// var chatClient2 = new ChatClient(new DESEncryption());

// chatClient.Send("Some Text");
// chatClient2.Send("Some Text");

#endregion

#region Template Method Pattern

// var task = new GenerateReportTask();
// task.Execute();

#endregion

#region Command Pattern

var customerService = new CustomerService();
var addCustomer = new AddCustomerCommand(customerService);
var button = new Button(addCustomer);

button.Click();

#endregion

Console.ReadKey();