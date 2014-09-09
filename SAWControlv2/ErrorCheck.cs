using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAWControl
{
    class ErrorCheck
    {
        public static void Check(IProgress<string> progress)
        {
            while (Globals._continue)
            {
                while (Globals.port.IsOpen)
                {
                        Actions.checkErrors();
                        //System.Threading.Thread.Sleep(500);
                }
            }
        }
    }
}
