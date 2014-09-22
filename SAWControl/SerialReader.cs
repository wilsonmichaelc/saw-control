using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAWControl
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
                        MessageBox.Show("SAWControl", "Connection Timed Out!\n" + tx.ToString() , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
