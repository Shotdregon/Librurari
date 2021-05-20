using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librurari.AppData
{
    class AppDataClass
    {
        public static libruariEntities context { get; } = new libruariEntities();
    }
}
