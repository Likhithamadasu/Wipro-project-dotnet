using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class Delay
{
    static async Task Main(string[] args)
    {
        string[] fileNames = { "log1.txt", "log2.txt", "log3.txt" };
        Task[] tasks = new Task[fileNames.Length];
        for (int i = 0; i < fileNames.Length; i++)
        {
            string currentFileName = fileNames[i];
            tasks[i] = Task.Run(() => AppendNumbersToFileWithDelay(currentFileName));
        }
        await Task.WhenAll(tasks);
        Console.WriteLine("Data written to all files successfully.");
    }
    static void  AppendNumbersToFileWithDelay(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, append: true))
        {
            for (int i = 1; i < 100; i++)
            {
                 writer.WriteLine(i.ToString());
                Thread.Sleep(200);
            }
        }
    }
}
