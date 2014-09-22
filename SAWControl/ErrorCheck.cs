using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SAWControl
{
    class ErrorCheck
    {
        public static void Check(IProgress<string> progress)
        {
            while (Globals._continue)
            {
                if (Globals.port.IsOpen)
                {
                    try
                    {
                        Actions.checkErrors();
                        Thread.Sleep(2000);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to complete error check.", "SAWControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
