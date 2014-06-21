using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modbus_RS232
{
    abstract public class ModbusController
    {
        static public byte lrc(byte[] b)
        {
            byte lrc = 0;
            for (int i = 0; i < b.Length; i++)
                lrc ^= b[i];
            return lrc;
        }
    }
}
