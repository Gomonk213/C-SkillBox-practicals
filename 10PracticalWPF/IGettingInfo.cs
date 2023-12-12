using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Practical
{
    interface IGettingInfo
    {
        string GetUserRecord(User user);
        string GetName(User user);
        string GetSurname(User user);
        string GetPhoneNumber(User user);
        string GetPassport(User user);
    }
}
