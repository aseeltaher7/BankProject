using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class IDGENERATOR
    {
        
        static int id = 0;
        string storeId;
        DateTime date = DateTime.Now;
       
        public string generate()
        {
            string gid = DateTime.Now.ToString("yyyy");
            storeId = gid + ++id;
            Console.Write(gid+ ++id);
            return storeId;
            
        }
        
    }
}
