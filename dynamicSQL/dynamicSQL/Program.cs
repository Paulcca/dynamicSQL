using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dynamicSQL.Repository;

namespace dynamicSQL
{
    class Program
    {
        static void Main(string[] args)
        {


            LookupContext db = new LookupContext();

         var t =   db.Lookups.FirstOrDefault();

        }
    }
}
