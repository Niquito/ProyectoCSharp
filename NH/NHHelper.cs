
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.NH
{
    public class Helper
    {
        private static ISessionFactory sf { get; set; }
        static Helper() {
            sf = new Configuration().Configure().BuildSessionFactory();
        }

        public static ISession GetSession() {
            return sf.OpenSession();
        }
    }
}
