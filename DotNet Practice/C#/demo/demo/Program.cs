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
            Task<string[][]> readTasks = Task.WhenAll(fileNames.Select(fileName => ReadFileLinesAsync(fileName)));
        string[][] fileContents = await readTasks;
        for (int i = 0; i < fileNames.Length; i++)
        {
            Console.WriteLine($"Contents of {fileNames[i]}");
            foreach (var line in fileContents[i])
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

        }
        Task[] writeTasks = new Task[fileNames.Length];
        for (int i = 0;i < fileNames.Length; i++)
        {
            string currentFileName = fileNames[i];
            writeTasks[i] = Task.Run(() => AppendNumbersToFileWithDelay(currentFileName));
        }
            await Task.WhenAll(writeTasks);
            Console.WriteLine("Data written to all files successfully.");
        }
        static async Task<string[]>ReadFileLinesAsync(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            var lines = new System.Collections.Generic.List<string>();
            while((line = await reader.ReadLineAsync()) != null)
            {
                lines.Add(line);
            }
            return lines.ToArray();
        }

        }

        static void AppendNumbersToFileWithDelay(string fileName)
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


