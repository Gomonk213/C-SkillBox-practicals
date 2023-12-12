using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Practical
{
    internal interface ISettingInfo
    {
         void SetName(User user, string name);
         void SetSurname(User user, string surname);
         void SetPhoneNumber(User user, string phoneNumber);
         void SetPassport(User user, string passport);
    }
}
