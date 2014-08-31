using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAWControlv2
{
    class SerialReader
    {
        public static void Read(IProgress<string> progress)
        {
            while (Globals._continue)
            {
                while (Globals.port.BytesToRead > 0)
                {
                    try
                    {
                        if (Globals.port.IsOpen)
                        {
                            progress.Report(Globals.port.ReadTo("\r"));
                        }
                    }
                    catch (TimeoutException tx)
                    {
                        progress.Report(null);
                    }

                    int now = DateTime.Now.Millisecond;
                    if ((DateTime.Now.Millisecond - Globals.startTime) > 800)
                    {
                        Actions.checkStatus();
                    }
                }
            }
        }
    }
}
