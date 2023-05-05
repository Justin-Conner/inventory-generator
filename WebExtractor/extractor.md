To extract the content of a webpage using C# and convert it to a CSV file, you can use the following steps:


Use the 
HtmlAgilityPack package to load the webpage HTML content and parse it.

Use the 
SelectNodes method to select all the 
p tags in the HTML document.

Loop through the selected 
p tags, extract their inner text, and store it in a list of strings.

Use the 
System.IO namespace to create a new CSV file and write the list of strings to the file.

Here's an example code snippet that demonstrates these steps:

csharp

Copy code
using System; using System.Collections.Generic; using System.IO; using HtmlAgilityPack;class Program { static void Main(string[] args) { // Load the webpage HTML contentHtmlWeb web = new HtmlWeb(); HtmlDocument doc = web.Load("https://www.example.com"); // Select all the p tags in the HTML document HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//p"); // Extract the inner text of each p tag and store it in a list of strings List<string> texts = new List<string>(); foreach (HtmlNode node innodes) { texts.Add(node.InnerText); } // Write the list of strings to a CSV file using(StreamWriter writer = new StreamWriter("output.csv")) { foreach (string text in texts) { writer.WriteLine(text); } } Console.WriteLine("CSV file written successfully!"); } }

In this example, the 
HtmlAgilityPack package is used to load the webpage HTML content and parse it. The

SelectNodes method is then used to select all the 
p tags in the HTML document, and their inner text is extracted and stored in a list of strings. Finally, the

StreamWriter class is used to create a new CSV file, and the list of strings is written to the file using a

foreach loop.

