using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicios.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string ApplicationConnection { get; set; }
        public int ExpireTokenMinutes { get; set; }
        public int ExpireCacheMinutes { get; set; }
        public Boolean HabilitarCache { get; set; }
        

    }
}
