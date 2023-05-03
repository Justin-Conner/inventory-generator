using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the total number of records: ");
        int numRecords = Convert.ToInt32(Console.ReadLine());

        List<string> lines = new List<string>();

        // Generate CSV header this should match the add inventory view fields
        lines.Add("Supplier,Product,Description ");

        // Generate random product data
        Random rand = new Random();
        //create a new array for each new lines you add with column header names which is the variable ex: "suppliers
        string[] suppliers = { "Apple Inc.", "Samsung Electronics Co., Ltd.", "Sony Corporation", "LG Electronics Inc.", "Microsoft Corporation", "Panasonic Corporation", "Toshiba Corporation", "Philips N.V.", "Huawei Technologies Co., Ltd.", "Lenovo Group Limited", "ASUSTek Computer Inc.", "Acer Inc.", "Dell Technologies Inc.", "HP Inc.", "Xiaomi Corporation", "OPPO Electronics Corp.", "Vivo Communication Technology Co. Ltd.", "Nokia Corporation", "HTC Corporation", "OnePlus Technology (Shenzhen) Co., Ltd." };
        string[] products = { "smartphone", "tablet", "smartwatch", "laptop", "desktop computer", "printer", "router", "modem", "external hard drive", "flash drive", "digital camera", "mirrorless camera", "DSLR camera", "camcorder", "headphones", "earbuds", "Bluetooth speaker", "soundbar", "television", "4K TV", "OLED TV", "LED TV", "QLED TV", "home theater system", "DVD player", "Blu-ray player", "streaming device", "gaming console", "virtual reality headset", "drones", "smart home hub", "smart bulbs", "smart thermostat", "smart plug", "wireless charger", "portable charger", "power bank", "smartphone case", "tablet case", "laptop case", "gaming laptop", "gaming desktop", "mechanical keyboard", "gaming mouse", "monitor", "projector", "webcam" };
        string[] descriptions = { "Description 1", "Description 2", "Description 3", "Description 4", "Description 5", "Description 6", "Description 7", "Description 8", "Description 9", "Description 10", "Description 11", "Description 12", "Description 13", "Description 14", "Description 15", "Description 16", "Description 17", "Description 18", "Description 19", "Description 20" };

        for (int i = 0; i < numRecords; i++)
        {
            //create a new index for each new array
            int supplierIndex = rand.Next(suppliers.Length);
            int productIndex = rand.Next(products.Length);
            int descriptionIndex = rand.Next(descriptions.Length);
            //create a new entry in the string line below to match the rest of the column headers
            string line = string.Format("{0},{1},{2}", suppliers[supplierIndex], products[productIndex], descriptions[descriptionIndex]);
            lines.Add(line);
        }

        // Write data to CSV file
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string csvFilePath = Path.Combine(desktopPath, "inventory.csv");
        File.WriteAllLines(csvFilePath, lines);

        Console.WriteLine("CSV file generated successfully and saved to desktop.");
    }
}
