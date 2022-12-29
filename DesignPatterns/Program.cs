using System;
// using DesignPatterns.BrushTool;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Visitor;
// using DesignPatterns.Command;
// using DesignPatterns.Iterator;
// using DesignPatterns.Mediator;
// using DesignPatterns.Observer;
// using DesignPatterns.State;
// using DesignPatterns.Strategy;
// using DesignPatterns.TemplateMethod;

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

// var customerService = new CustomerService();
// var addCustomer = new AddCustomerCommand(customerService);
// var button = new Button(addCustomer);

// button.Click();

#endregion

#region Observer Pattern

// var dataSource = new DataSource();
// dataSource.AddObserver(new Chart(dataSource));
// dataSource.AddObserver(new SpreatSheet(dataSource));

// dataSource.Value = 1;
// dataSource.Value = 3;

#endregion

#region Mediator Pattern

// var dialogBox = new ArticleDialogBox();
// dialogBox.SimulateUserInteraction();

#endregion

#region Chain of Responsibility
// Authentication ==> Logging ==> Compression
// var compressor = new Compressor(null);
// var logger = new Logger(compressor);
// var authenticator = new Authenticator(logger);

// var server = new WebServer(authenticator);
// server.Handle(new HttpRequest("Farshad", "123"));

#endregion

#region Visitor

var document = new HtmlDocument();
document.AddNode(new HeadingNode());
document.AddNode(new AnchorNode());
document.Execute(new HighLightOperation());
document.Execute(new PlainTextOperation());
#endregion

Console.ReadKey();