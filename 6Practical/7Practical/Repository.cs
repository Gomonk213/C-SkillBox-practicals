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
            set { workers = value; }
        }
        public string Fpath 
            {
                get{return this.fpath;}
            }
        private Worker[] workers;
        private int index; // Последний записанный id работника
        private string fpath; // Путь текущего файла
        public Repository(string path)
        {
            index = 0;
            this.fpath = ".\\" + path;
            workers = new Worker[1];
            GetAllWorkersFromFile(".\\" + path);
        }
        /// <summary>
        /// Если файл существует, то - получение списка работников в локальный массив работников, иначе - инициализация репозитория
        /// и создание соответствующих директорий и необходимого файла. В случае некорректной записи в файле - очистка файла
        /// </summary>
        /// <param name="fullPath">Полный путь к файлу</param>
        /// <returns>Массив работников</returns>
        private void GetAllWorkersFromFile(string fullPath)
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
            while (!sr.EndOfStream)
            {
                record = sr.ReadLine().Split('#');
                // Проверка на корректность записи
                if (record.Length!=7)
                {
                    Console.WriteLine("Запись некорректна, файл очищен");
                    sr.Close();
                    StreamWriter sw = new StreamWriter(fullPath);
                    sw.Close();
                    break;
                }
                if (int.Parse(record[0]) == 0)
                    continue;
                Resize(index >= workers.Length);
                workers[index] = new Worker(int.Parse(record[0]),
                                           Convert.ToDateTime(record[1]),
                                           record[2],
                                           int.Parse(record[3]), 
                                           int.Parse(record[4]), 
                                           Convert.ToDateTime(record[5]), 
                                           record[6]);
                index++;
            }
            sr.Close();
        }
        /// <summary>
        /// Функция, синхронизирующая локальный репозиторий с файлом
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public void CopyRepoToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path,false);
            foreach(Worker worker in workers)
            {
                sw.WriteLine(worker.Print().Replace('|','#'));
            }
            sw.Close();
        }
        public void PrintWorkers()
        {
            Console.WriteLine("ID|Время создания записи|            Ф.И.О           |Возраст|Рост|Дата рождения|Место рождения");
            for (int i = 0; i<index;i++)
            {
                Console.WriteLine(workers[i].Print());
            }
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
                Array.Resize(ref workers, workers.Length+1);
            }
        }
        /// <summary>
        /// Поиск работника по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Либо работника с необходимым id, либо с id = -1</returns>
        public Worker GetWorkerById(int id)
        {
            int i;
            for( i = 0; i<workers.Length-1 && workers[i].Id!=id;i++) {}
            if (workers[i].Id == id) { return workers[i]; }
            Console.WriteLine("Работник с таким ID не найден в репозитории");
            return new Worker(-1);
        }
        public void AddWorker()
        {
            int Id = index + 2;
            DateTime dateAdding = DateTime.Now;
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату рождения");
            DateTime dateBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите место рождения");
            string placeBirth = Console.ReadLine();
            Resize(index >= workers.Length);
            workers[index]= new Worker(Id, dateAdding,name,age,height, dateBirth, placeBirth);
            index++;
            CopyRepoToFile(fpath);//синхронизация файла и репозитория
            Console.WriteLine("Запись успешно добавлена");
        }
        public void DeleteWorker(int id)
        {
            StreamWriter sw = new StreamWriter(fpath, false);
            foreach (Worker worker in workers)
            {
                if(worker.Id != id)
                    sw.WriteLine(worker.Print().Replace('|', '#'));
            }
            sw.Close();
            this = new Repository(fpath);
        }
        public void PrintWorkersBetweenDates(DateTime from, DateTime to)
        {
            Console.WriteLine("ID|Время создания записи|            Ф.И.О           |Возраст|Рост|Дата рождения|Место рождения");
            foreach (Worker worker in workers )
            {
                if(worker.AddingTime>from && worker.AddingTime<to)
                    Console.WriteLine(worker.Print());
            }
        }
    }
}
