using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string[] filePaths = { "logs/log1.txt", "logs/log2.txt", "logs/log3.txt" };

        
        Console.WriteLine("Starting to count characters in each file...");
        Task<string[]>[] readTasks = filePaths.Select(filePath => ReadFileAsync(filePath)).ToArray();
        string[][] fileContents = await Task.WhenAll(readTasks);

        Task<int>[] countTasks = fileContents.Select(content => GetCharacterCountAsync(content)).ToArray();
        int[] characterCounts = await Task.WhenAll(countTasks);
        Console.WriteLine("Finished counting characters in each file.");

        for (int i = 0; i < filePaths.Length; i++)
        {
            Console.WriteLine($"Character count in {filePaths[i]}: {characterCounts[i]}");
        }
    }

    static async Task<string[]> ReadFileAsync(string filePath)
    {
        Console.WriteLine($"Reading from {filePath}...");
        var lines = new List<string>();
        using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 4096, useAsync: true))
        using (var streamReader = new StreamReader(fileStream))
        {
            string line;
            while ((line = await streamReader.ReadLineAsync()) != null)
            {
                lines.Add(line);
            }
        }
        Console.WriteLine($"Finished reading from {filePath}.");
        return lines.ToArray();
    }

    static async Task<int> GetCharacterCountAsync(string[] content)
    {
        return await Task.Run(() =>
        {
            int count = content.Sum(line => line.Length);
            Console.WriteLine($"Character count: {count}");
            return count;
        });
    }
}

