using System;
using DesignPatterns.Adapter;
using DesignPatterns.Adapter.fxFilter;
// using DesignPatterns.BrushTool;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Composite;
using DesignPatterns.Composite.Example2;
using DesignPatterns.Decorator;
using DesignPatterns.Decorator.Example2;
using DesignPatterns.Facade;
using DesignPatterns.Flyweight;
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

// var document = new HtmlDocument();
// document.AddNode(new HeadingNode());
// document.AddNode(new AnchorNode());
// document.Execute(new HighLightOperation());
// document.Execute(new PlainTextOperation());

#endregion

#region Composite

#region Example1

// Group group1 = new();
// group1.Add(new Shape("Shape 1"));
// group1.Add(new Shape("Shape 2"));

// Group group2 = new();
// group2.Add(new Shape("Shape 3"));
// group2.Add(new Shape("Shape 4"));

// Group group3 = new();
// group3.Add(group1);
// group3.Add(group2);

// group3.Render();

#endregion

#region Example2
// Team team1 = new();
// team1.Add(new Truck());
// team1.Add(new HumanResource());
// team1.Add(new HumanResource());

// Team team2 = new();
// team1.Add(new Truck());
// team1.Add(new HumanResource());
// team1.Add(new HumanResource());

// Team team3 = new();
// team3.Add(team1);

// team3.Deploy();
#endregion

#endregion

#region Adapter

// ImageView imageView = new(new Image());
// imageView.Apply(new CaramelFilter(new Caramel()));

#endregion

#region Decorator
#region Example1

// EncryptedCloudStream encryptedCloudStream = new(new CompressedCloudStream(new CloudStream()));
// encryptedCloudStream.Write("Some Other Data");

#endregion
#region Example2

// Editor editor = new();
// editor.OpenProject();

#endregion
#endregion

#region Facade

// TwitterAPI twitterApi = new("appKey", "secretKey");
// var recentTweets = twitterApi.GetRecentTweets();

#endregion

#region Flyweight

PointService pointService = new(new PointIconFactory());
var points = pointService.GetPoints();
foreach (var point in points)
    point.Draw();

#endregion


Console.ReadKey();