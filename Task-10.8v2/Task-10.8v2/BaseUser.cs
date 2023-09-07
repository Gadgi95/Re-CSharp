using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{
    public abstract class BaseUser
    {
        public abstract void ReadInfoClients(long phone);

        public abstract void SetPhoneNumber(long phone);

        public abstract string ChangeInfoClient(string whatChanged, string typeOfChanged);

        public abstract void SaveChangedInfo(string changedInfo);

        public abstract string GetClientInfo(long  phone);

    }
}
