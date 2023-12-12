using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Practical
{
    class Assistant : IGettingInfo
    {
        public Assistant() { }

        public string GetUserRecord (User user) 
        {
            return user.ToString().Replace(user.Passport, "**********");
        }
        public string GetName (User user)
        {
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.Editor = "Assistant";
            user.Edited = "Name";
            user.TypeOfEditing = "Watching";
            return user.Name;
        }
        public string GetSurname (User user)
        {
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.Editor = "Assistant";
            user.Edited = "Surname";
            user.TypeOfEditing = "Watching";
            return user.Surname;
        }
        public string GetPhoneNumber (User user)
        {
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.Editor = "Assistant";
            user.Edited = "Phone Number";
            user.TypeOfEditing = "Watching";
            return user.PhoneNumber;
        }
        public string GetPassport(User user)
        {
            user.EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            user.Editor = "Assistant";
            user.Edited = "Passport";
            user.TypeOfEditing = "Watching";
            return "**********";
        }

    }
}
