﻿using System.IO.Ports;
namespace Domotica
{
    class Casa
    {
        private static SerialPort Arduino = new SerialPort("COM9", 9600);

        public void EnviarCaracter(string dato)
        {
            Arduino.Open();
            Arduino.Write(dato);
            Arduino.Close();
        }

    }

}


