using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal
{
    public class InternalServerInterface : MarshalByRefObject
    {
        public void Init()
        {

        }
         
        public void HookRecoil(bool hook, int multiplier)
        {

        }

        public void Test()
        {
            Console.WriteLine("Internal Server Interface called");
        }

        public void Ping() { }
    }
}
