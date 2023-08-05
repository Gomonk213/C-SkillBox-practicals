using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _7Practical
{
    struct Repository
    {
        public Worker[] Workers
        {
            get { return workers; }
        }
        private Worker[] workers;
        private int index; // Последний записанный id работника
        // fullPath = @".\Info\Data.txt"
        public Repository(string path)
        {
            index = 0;
            workers = new Worker[1];
            workers = GetAllWorkersFromFile(path);
        }
        /// <summary>
        /// Если файл существует, то - получение списка работников в локальный массив работников, иначе - инициализация репозитория
        /// и создание соответствующих директорий и необходимого файла
        /// </summary>
        /// <param name="fullPath">Полный путь к файлу</param>
        /// <returns>Массив работников</returns>
        public Worker[] GetAllWorkersFromFile(string fullPath)
        {
            string path = fullPath.Substring(0, fullPath.LastIndexOf("\\"));
            Directory.CreateDirectory(path);
            if (!File.Exists(fullPath))
            {
                StreamWriter sw=new StreamWriter(fullPath);
                sw.Close();
            }
            StreamReader sr = new StreamReader(fullPath);
            string[] record;
            Worker[] result = new Worker[workers.Length];
            while(!sr.EndOfStream)
            {
                record = sr.ReadLine().Split('#');
                Resize(index>=workers.Length);
                result[index] = new Worker(int.Parse(record[0]),
                                           Convert.ToDateTime(record[1]),
                                           record[2],
                                           int.Parse(record[3]), 
                                           int.Parse(record[4]), 
                                           Convert.ToDateTime(record[5]), 
                                           record[6]);
                index++;
            }
            sr.Close();
            return result;
        }
        /// <summary>
        /// Реинициализация репозитория на необходимом файле
        /// </summary>
        /// <param name="path">Путь к новому файлу для репозитория</param>  
        public void ChangePath(string path)
        {
            this=new Repository(path);
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
