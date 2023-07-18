using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8v2
{
    internal interface Repository
    {
        public string ChangeInfoClient(string whatChanged, string typeOfChanged);

        public void SaveChangedInfo(string changedInfo);
    }
}
