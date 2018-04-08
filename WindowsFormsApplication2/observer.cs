using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class observer
    {
        
        SQLhandler sql = new SQLhandler();
        
        public observer()
        {

        }

        public int[] dbpoll(string question)
        {
            int z = 0;

            
           
                timer();
                return sql.dbread(question);      
            


        }//end dbpoll class

        public void timer()//delays polling
        {
            int i = 0;
            while (i < 10000)
            {
                i++;
            }

        }
    }//end class
}//end namespace
