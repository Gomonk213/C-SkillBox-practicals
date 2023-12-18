using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Practical
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }
        public string EditTime { get; set; }
        public string Edited { get; set; }
        public string TypeOfEditing { get; set; }
        public string Editor { get; set; }

        public string ForAssistant { get; } = "******";


        static Random rand = new Random();
        static List<string> dbPassport=new List<string>();
        
        /// <summary>
        /// Конструктор ручного ввода
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="passport">Серия и номер паспорта</param>
        public User (string name, string surname, string phoneNumber, string passport)
        {
            if (name == String.Empty)
            {
                name = Guid.NewGuid().ToString().Substring(0, 6);

            }
            if (surname == String.Empty)
            {
                surname = Guid.NewGuid().ToString().Substring(0, 6);
            }
            if(phoneNumber==String.Empty)
            {
                phoneNumber="7915"+Convert.ToString(rand.Next(1000000,10000000));
            }
            if(passport==String.Empty)
            {
                passport = "4516" + Convert.ToString((rand.Next(100000,1000000)));
            }
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            dbPassport.Add(passport);
            Passport = passport;
            EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            Edited = "All";
            TypeOfEditing = "Adding";
            Editor = "User";
        }

        /// <summary>
        /// Конструктор с автопараметрами
        /// </summary>
        public User(): this("", "", "", "")
        {
        }

        public override string ToString()
        {
            return String.Format("Name: {0,6} | Surname: {1,6} | PhoneNumber: {2,11} | Passport: {3,10} | EditTime:{4,16} | Edited: {5,10} | TypeOfEditing: {6,8} | Editor: {7,9} |",
                this.Name,
                this.Surname,
                this.PhoneNumber,
                this.Passport,
                this.EditTime,
                this.Edited,
                this.TypeOfEditing,
                this.Editor
                ) ;
        }
        public class SortByName : IComparer<User>
        {
            public int Compare(User x, User y)
            {
                return String.Compare(x.Name, y.Name);
            }
        }
        public class SortBySurname : IComparer<User>
        {
            public int Compare(User x,User y)
            {
                return String.Compare(x.Surname, y.Surname);
            }
        }
    }
}
