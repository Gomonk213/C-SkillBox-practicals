using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Practical
{
    internal interface ISettingInfo
    {
        public void SetName(User user, string name);
        public void SetSurname(User user, string surname);
        public void SetPhoneNumber(User user, string phoneNumber);
        public void SetPassport(User user, string passport);
    }
}
