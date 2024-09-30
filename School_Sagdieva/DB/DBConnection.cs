using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Sagdieva.DB
{
    internal class DBConnection
    {
        public static School_Entities se = new School_Entities();

        public static Client loggedClient;
    }
}
