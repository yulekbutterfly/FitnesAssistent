using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesAssistent.DB
{
     class AppData
    {
        public static Entities context { get;} = new Entities();
    }
}
