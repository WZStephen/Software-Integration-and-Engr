using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebApplication1
{
    public class utilities
    {
        public static List<KeyValuePair<string, int>> NameNode(string data, int totalThreads)
        {
            List<string>[] thread_tmp = new List<string>[totalThreads];
            List<List<KeyValuePair<string, int>>> threadResults = new List<List<KeyValuePair<string, int>>>();
            List<KeyValuePair<string, int>> finalie = new List<KeyValuePair<string, int>>();

            Thread[] inProcessThread = new Thread[totalThreads];

            Dictionary<string, int> combine = new Dictionary<string, int>();


            for (int i = 0; i < totalThreads; i++){
                thread_tmp[i] = new List<string>();
            }

            int total_count = 0;
            foreach (string n in data.Split(' ')){
                if (n != "\n" && n != "" && n != "\t"){
                    thread_tmp[total_count % totalThreads].Add(n);
                    total_count++;
                }
            }

            // assign the tasks to threads
            for (int i = 0; i < totalThreads; i++){
                int tmp = i;
                Thread one_thread = new Thread(() => TaskTracker(thread_tmp[tmp], threadResults));
                one_thread.Start();
                inProcessThread[i] = one_thread;
            }

            for (int i = 0; i < totalThreads; i++){
                inProcessThread[i].Join();
            }

            // Combine the results
            foreach (List<KeyValuePair<string, int>> item in threadResults){
                foreach (KeyValuePair<string, int> pair in item){
                    int count;
                    if (combine.TryGetValue(pair.Key, out count)){
                        combine[pair.Key] += pair.Value;
                    }
                    else{
                        combine[pair.Key] = pair.Value;
                    }
                  
                }
            }

            // add all pairs to a finalized list
            foreach (KeyValuePair<string, int> pair in combine)
            {
                finalie.Add(pair);
            }
            return finalie;
        }

        public static void TaskTracker(List<string> inputs, List<List<KeyValuePair<string, int>>> globalList)
        {
            List<KeyValuePair<string, int>> total_pairs = new List<KeyValuePair<string, int>>();
            Dictionary<string, int> Shuffle = new Dictionary<string, int>();
            List<KeyValuePair<string, int>> reduce = new List<KeyValuePair<string, int>>();

            // Map
            foreach (string input in inputs){
                total_pairs.Add(new KeyValuePair<string, int>(input, 1));
            }

            // Reduce
            foreach (KeyValuePair<string, int> one_pair in total_pairs){
                int count;
                if (Shuffle.TryGetValue(one_pair.Key, out count)){
                    Shuffle[one_pair.Key]++;
                }
                else{
                    Shuffle[one_pair.Key] = 1;
                }
            }

            foreach (KeyValuePair<string, int> single in Shuffle)
            {
                reduce.Add(single);
            }
            globalList.Add(reduce);

        }
    }
}