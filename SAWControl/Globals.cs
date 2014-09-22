using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SAWControl
{
    class Globals
    {
        public static bool REM = false;
        public static bool EN1 = false;
        public static bool EN2 = false;
        public static bool PUL = false;
        public static bool FL1 = false;
        public static bool FL2 = false;
        public static bool OT1 = false;
        public static bool OT2 = false;

        public static int PWR = 0;
        public static int timerTemp = 0;
        public static int timerFault = 0;

        public static bool _continue = true;
        public static bool _firstRun = true;
        public static bool _printStatus = false;
        public static bool _printErrors = false;
        public static bool _connected = false;

        public static int startTime = DateTime.Now.Millisecond;

        public static SerialPort port = null;
    }
}
