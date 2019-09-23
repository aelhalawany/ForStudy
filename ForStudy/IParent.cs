using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy
{
    interface IParent
    {
        int ID { get; set; }

        string Name { set; get; }

        void Create(string Name);

        void Update(int ID);

    }
}
