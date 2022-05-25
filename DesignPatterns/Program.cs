#region Iterator

//using DesignPatterns.Iterator;

//var history = new BrowseHistory();

//history.Push("a");
//history.Push("b");
//history.Push("c");

//var iterator = history.CreateIterator();

//while (iterator.HasNext())
//{
//    var url = iterator.Current();
//    Console.WriteLine(url);
//    iterator.Next();
//}

//Console.ReadKey();

#endregion

#region Strategy

using DesignPatterns.Strategy;

var imageStorage = new ImageStorage();

imageStorage.Store("testFileName", new PngCompressor(), new BlackAndWhiteFilter());
imageStorage.Store("testFileName", new JpegCompressor(), new BlackAndWhiteFilter());

#endregion


Console.ReadKey();