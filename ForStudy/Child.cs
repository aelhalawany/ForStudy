using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy
{
    public class Child :IParent
    {
       
        public int ID
        {
            get; set;
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }


        void cal ()
        {
            
        }


        public void Create(string Name)
        {
            throw new NotImplementedException();
        }

        public void Update(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
