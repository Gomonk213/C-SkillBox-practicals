using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10Practical
{
    internal class Manager:Assistant,IGettingInfo, ISettingInfo
    {

        public new string GetName(User user)
        {
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.Editor = "Manager";
            user.Edited = "Name";
            user.TypeOfEditing = "Watching";
            return user.Name;
        }
        public new string GetSurname(User user)
        {
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.Editor = "Manager";
            user.Edited = "Surname";
            user.TypeOfEditing = "Watching";
            return user.Surname;
        }
        public new string GetPhoneNumber(User user)
        {
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.Editor = "Manager";
            user.Edited = "Phone Number";
            user.TypeOfEditing = "Watching";
            return user.PhoneNumber;
        }
        public new string GetPassport(User user)
        {
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.Editor = "Manager";
            user.Edited = "Passport";
            user.TypeOfEditing = "Watching";
            return user.Passport;
        }
        public void SetName(User user, string newName)
        {
            
            user.Name = newName;
            user.Editor = "Manager";
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.TypeOfEditing = "Editing";
            user.Edited = "Name";
        }
        public void SetSurname(User user, string newSurname)
        {
            
            user.Surname = newSurname;
            user.Editor = "Manager";
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.TypeOfEditing = "Editing";
            user.Edited = "Surname";
        }
        public void SetPhoneNumber(User user, string newNumber)
        {
            /*while (String.IsNullOrEmpty(newNumber))
            {
                    Console.WriteLine("Недопустимая фамилия, введите другую");
               
            } внести это туда, где используется функция
            */ 
            user.PhoneNumber = newNumber;
            user.Editor = "Manager";
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.TypeOfEditing = "Editing";
            user.Edited = "PhoneNumber";
        }
        public void SetPassport(User user, string newPassport)
        {
            user.Passport = newPassport;
            user.Editor = "Manager";
            user.EditTime= DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.TypeOfEditing = "Editing";
            user.Edited = "Passport";
        }
        public User AddNewRecord (string name, string surname, string phoneNumber, string passport)
        {
            User user = new User(name,surname, phoneNumber, passport);
            user.Editor = "Manager";
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.TypeOfEditing = "Adding";
            user.Edited = "All";
            return user;
        }
    }
}
