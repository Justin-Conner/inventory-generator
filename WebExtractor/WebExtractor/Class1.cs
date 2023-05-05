using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using HtmlAgilityPack;

class Program
{
    static void Main(string[] args)
    {
        // Load the webpage HTML content
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/");

        // Select all the p tags in the HTML document
        HtmlNodeCollection? pnodes = doc.DocumentNode.SelectNodes("//p");
        HtmlNodeCollection? h1nodes = doc.DocumentNode.SelectNodes("//h1");
        HtmlNodeCollection? h2nodes = doc.DocumentNode.SelectNodes("//h2");

        // Extract the inner text of each p tag and store it in a list of strings
        List<string> ptexts = new List<string>();
        foreach (HtmlNode node in pnodes)
        {
            ptexts.Add(node.InnerText);
        }
        List<string> h1texts = new List<string>();
        foreach (HtmlNode node in  h1nodes)
        {
            h1texts.Add(node.InnerText);

        }
        List<string> h2texts = new List<string>();
        foreach (HtmlNode node in  h2nodes)
        {
            h2texts.Add(node.InnerText);

        }

        // Write the list of strings to a CSV file
        using (StreamWriter writer = new StreamWriter("output.csv"))
        {
            foreach (string text in ptexts)
            {
                writer.WriteLine(text);
            }
        }
        using (StreamWriter writer = new StreamWriter("output.csv"))
        {
            foreach (string text in h1texts)
            {
                writer.WriteLine(text);
            }
        }
        using (StreamWriter writer = new StreamWriter("output.csv"))
        {
            foreach (string text in h2texts)
            {
                writer.WriteLine(text);
            }
        }

        Console.WriteLine("CSV file written successfully!");
    }
}