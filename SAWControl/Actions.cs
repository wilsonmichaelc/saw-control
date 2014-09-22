using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAWControl
{
    class Actions
    {
        public static char[] status = { 's', 't', 'a', 't', 'u', 's', '\r' };
        public static char[] errors = { 'e', 'r', 'r', 'o', 'r', 's', '\r' };

        public static char[] enable_remote = { 'r', 'e', 'm', ' ', '1', '\r' };
        public static char[] disable_remote = { 'r', 'e', 'm', ' ', '0', '\r' };

        public static char[] enable_one = { 'e', 'n', 'a', 'b', '1', ' ', '1', '\r' };
        public static char[] disable_one = { 'e', 'n', 'a', 'b', '1', ' ', '0', '\r' };

        public static char[] enable_two = { 'e', 'n', 'a', 'b', '2', ' ', '1', '\r' };
        public static char[] disable_two = { 'e', 'n', 'a', 'b', '2', ' ', '0', '\r' };

        public static char[] enable_pulse = { 'p', 'u', 'l', 's', 'e', ' ', '1', '\r' };
        public static char[] disable_pulse = { 'p', 'u', 'l', 's', 'e', ' ', '0', '\r' };

        public static void checkStatus()
        {
            if (Globals.port.IsOpen)
            { 
                Globals.port.Write(status, 0, status.Length); 
            }
        }

        public static void checkErrors()
        {
            if (Globals.port.IsOpen)
            {
                Globals.port.Write(errors, 0, status.Length);
            }
        }

        public static void enableRemote()
        {
            if (Globals.port.IsOpen) { 
                Globals.port.Write(enable_remote, 0, enable_remote.Length);
                Globals.REM = true;
            }
        }

        public static void disableRemote()
        {
            if (Globals.port.IsOpen) { 
                Globals.port.Write(disable_remote, 0, disable_remote.Length);
                Globals.REM = false;
            }
        }

        public static void enableOne()
        {
            if (Globals.port.IsOpen) { 
                Globals.port.Write(enable_one, 0, enable_one.Length);
                Globals.EN1 = true;
            }
        }

        public static void disableOne()
        {
            if (Globals.port.IsOpen) { 
                Globals.port.Write(disable_one, 0, disable_one.Length);
                Globals.EN1 = false;
            }
        }

        public static void enableTwo()
        {
            if (Globals.port.IsOpen) { 
                Globals.port.Write(enable_two, 0, enable_two.Length);
                Globals.EN2 = true;
            }
        }

        public static void disableTwo()
        {
            if (Globals.port.IsOpen) { 
                Globals.port.Write(disable_two, 0, disable_two.Length);
                Globals.EN2 = false;
            }
        }

        public static void enablePulse()
        {
            if (Globals.port.IsOpen) { 
                Globals.port.Write(enable_pulse, 0, enable_pulse.Length);
                Globals.PUL = true;
            }
        }

        public static void disablePulse()
        {
            if (Globals.port.IsOpen) { 
                Globals.port.Write(disable_pulse, 0, disable_pulse.Length);
                Globals.PUL = false;
            }
        }

        public static void enableDual()
        {
            if (Globals.port.IsOpen)
            {
                Globals.port.Write(enable_one, 0, enable_one.Length);
                Globals.EN1 = true;
                Globals.port.Write(enable_two, 0, enable_two.Length);
                Globals.EN2 = true;
            }
        }

        public static void disableDual()
        {
            if (Globals.port.IsOpen)
            {
                Globals.port.Write(enable_one, 0, disable_one.Length);
                Globals.EN1 = true;
                Globals.port.Write(disable_two, 0, disable_two.Length);
                Globals.EN2 = false;
            }
        }

        public static void togglePulsed()
        {
            if (Globals.PUL)
            {
                disablePulse();
            }
            else
            {
                enablePulse();
            }
        }

        public static void toggleDual()
        {
            if (Globals.EN1 && Globals.EN2)
            {
                disableDual();
            }
            else
            {
                enableDual();
            }
        }

        public static void setPower(string power)
        {
            Globals.PWR = int.Parse(power);
            string tmp = "pwr " + power + "\r";
            char[] pwr = tmp.ToCharArray();
            Globals.port.Write(pwr, 0, pwr.Length);
        }

        public static void processStatusMessage(string response)
        {
            string[] status = response.Split(' ');

            foreach (string s in status)
            {
                if (s.StartsWith("REM"))
                {
                    Globals.REM = Boolean.Parse(s.Split('=')[1]);
                }
                else if (s.StartsWith("EN1"))
                {
                    Globals.EN1 = Boolean.Parse(s.Split('=')[1]);
                }
                else if (s.StartsWith("EN2"))
                {
                    Globals.EN2 = Boolean.Parse(s.Split('=')[1]);
                }
                else if (s.StartsWith("PUL"))
                {
                    Globals.PUL = Boolean.Parse(s.Split('=')[1]);
                }
                else if (s.StartsWith("FL1"))
                {
                    Globals.FL1 = Boolean.Parse(s.Split('=')[1]);
                }
                else if (s.StartsWith("FL2"))
                {
                    Globals.FL2 = Boolean.Parse(s.Split('=')[1]);
                }
                else if (s.StartsWith("OT1"))
                {
                    Globals.OT1 = Boolean.Parse(s.Split('=')[1]);
                }
                else if (s.StartsWith("OT2"))
                {
                    Globals.OT2 = Boolean.Parse(s.Split('=')[1]);
                }
                else if (s.StartsWith("PWR"))
                {
                    Globals.PWR = int.Parse(s.Split('=')[1]);
                }
            }
        }

    }
}
