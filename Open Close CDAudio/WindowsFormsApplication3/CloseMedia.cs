using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace close
{
    class CloseMedia
    {

        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(String command, StringBuilder buffer, Int32 bufferSize, IntPtr hwndCallback);

        public static void Open()
        {
            // Open the door
            mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
        }

        public static void Close()
        {
            // Close the door
            mciSendString("set CDAudio door closed", null, 0, IntPtr.Zero);
        }

    }
}
