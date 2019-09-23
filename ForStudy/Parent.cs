using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy
{
    public static class Parent
    {
        private static int PrivateId { get; set; }

        public static int PublicId { get; set; }

        //protected static int ProtectedId { get; set; }

        public static int StringCount(this string str,int x)
        {
            return str.Length;
        }
    }
}
