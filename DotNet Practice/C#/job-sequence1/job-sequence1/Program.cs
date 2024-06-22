using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job_sequence1
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                // Create a list of jobs with JobId, Profit, and Deadline
                List<Job> jobs = new List<Job>
            {
                new Job('A', 50, 2),
                new Job('B', 40, 2),
                new Job('C', 90, 1),
                new Job('D', 10, 3),
                new Job('E', 5, 3),
                new Job('F', 11, 2),
                new Job('G', 70, 1),
                new Job('H', 15, 4)
            };

                // Create an instance of JobSequencing and find the job sequence to maximize profit
                JobSequencing jobSequencing = new JobSequencing();
                jobSequencing.GetMaxProfit(jobs, 4);
            }
        }

        
        public class SortJobByProfit : IComparer<Job>
        {
            public int Compare(Job x, Job y)
            {
                return y.Profit.CompareTo(x.Profit);
            }
        }

        
        public class Job
        {
            public char JobId { get; set; }
            public int Profit { get; set; }
            public int Deadline { get; set; }

            public Job(char id, int profit, int deadline)
            {
                JobId = id;
                Profit = profit;
                Deadline = deadline;
            }
        }

        
        public class JobSequencing
        {
            public void GetMaxProfit(List<Job> jobs, int maxDeadline)
            {
                
                jobs.Sort(new SortJobByProfit());

               
                char[] jobSequence = new char[maxDeadline];
                
                bool[] slotFilled = new bool[maxDeadline];
                
                int totalProfit = 0;

                
                for (int i = 0; i < jobSequence.Length; i++)
                {
                    jobSequence[i] = '-';
                }

                
                foreach (Job job in jobs)
                {
                    
                    for (int j = Math.Min(maxDeadline, job.Deadline) - 1; j >= 0; j--)
                    {
                        
                        if (!slotFilled[j])
                        {
                            jobSequence[j] = job.JobId;
                            slotFilled[j] = true;
                            totalProfit += job.Profit;
                            break;
                        }
                    }
                }

                // Print the job sequence to maximize profit
                Console.WriteLine("Job sequence to maximize profit:");
                foreach (char jobId in jobSequence)
                {
                    if (jobId != '-')
                    {
                        Console.Write(jobId + " ");
                    }
                }

                // Print the total profit
                Console.WriteLine("\nTotal Profit: " + totalProfit);
            }
        }
}

