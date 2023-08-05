using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _7Practical
{
    struct Repository
    {
        private Worker[] workers;
        private int index; // Последний записанный id работника
        // path = @".\Info\Data.txt"
        private Repository(string path)
        {
            index = 0;
            workers = new Worker[1];
            workers = GetAllWorkers(path);
        }
        public Worker[] GetAllWorkers(string path)
        {
            StreamReader sr = new StreamReader(path);
            string[] record;
            
            Worker[] result = new Worker[workers.Length];
            while(!sr.EndOfStream)
            {
                record = sr.ReadLine().Split('#');
                Resize(index>=workers.Length);
                result[index]= new Worker(int.Parse(record),)
            }
        }
        private void Resize(bool flag)
        {
            if(flag)
            {
                Array.Resize(ref workers, workers.Length*2);
            }
        }
    }
}
