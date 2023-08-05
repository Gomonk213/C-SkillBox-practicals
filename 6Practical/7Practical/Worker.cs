using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Practical
{
    struct Worker
    {
        #region Свойства
        public int Id {  get { return this.id; } set { this.id = value; } }

        public DateTime AddingTime { get { return this.addingTime; } set { this.addingTime = value; } }
        public string FullName { get { return this.fullName; } set { this.fullName = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public int Height { get { return this.height; } set { this.height = value; } }
        public DateTime DateBirth { get { return this.dateBirth; } set { this.dateBirth = value; } }
        public string PlaceBirth { get { return this.placeBirth; } set { this.placeBirth = value; } }
        #endregion
        #region Поля
        private int id;
        private string fullName;
        private int age;
        private int height;
        private DateTime dateBirth;
        private string placeBirth;
        private DateTime addingTime;
        #endregion 
        /// <summary>
        /// Конструктор объекта "Работник"
        /// </summary>
        /// <param name="Id">Уникальный номер</param>
        /// <param name="AddingTime">Время добавления записи</param>
        /// <param name="FullName">ФИО</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        /// <param name="DateBirth">Дата рождения</param>
        /// <param name="PlaceBirth">Место рождения</param>
        public Worker(int Id,DateTime AddingTime, string FullName, int Age, int Height,DateTime DateBirth,string PlaceBirth)
        {
            this.id = Id;
            this.fullName = FullName;
            this.age = Age;
            this.height = Height;
            this.dateBirth = DateBirth;
            this.placeBirth = PlaceBirth;
            this.addingTime = AddingTime;
        }
        /// <summary>
        /// Конструктор для несуществующих рабочих
        /// </summary>
        /// <param name="Id"></param>
        public Worker(int Id)
        {
            this.id = Id;
            this.fullName = "";
            this.age = 0;
            this.height = 0;
            this.dateBirth = DateTime.Now;
            this.placeBirth = "";
            this.addingTime = DateTime.Now;
        }
        public string Print()
        {
            return ($"{this.id,2}|{this.addingTime.ToString("dd-MM-yyyy HH:mm"),21}|{this.fullName,28}|{this.age,7}|{this.height,4}|{this.dateBirth.ToString("dd-MM-yyyy"),13}|{this.placeBirth,14}");
        }
    }
}
