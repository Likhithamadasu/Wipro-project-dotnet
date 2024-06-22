using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class parallel
{
    static async Task Main(string[] args)
    {
        string[] fileNames = { "log1.txt", "log2.txt", "log3.txt" };
        Task[] tasks = new Task[fileNames.Length];
        for (int i = 0; i < fileNames.Length; i++)
        {
            string currentFileName = fileNames[i];
            tasks[i] = Task.Run(() => AppendNumbersToFile(currentFileName));
        }
        await Task.WhenAll(tasks);
        Console.WriteLine("Data written to all files successfully.");
    }
    static async Task AppendNumbersToFile(string fileName)
    {
        using (StreamWriter writer = File.AppendText(fileName))
        {
            for (int i = 1; i < 100; i++)
            {
                await writer.WriteLineAsync(i.ToString());
            }
        }
    }
}
