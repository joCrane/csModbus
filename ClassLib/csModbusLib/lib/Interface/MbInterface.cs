﻿using System.Diagnostics;

// http://www.simplymodbus.ca/index.html

namespace csModbusLib
{
    public abstract class MbInterface
    {
        protected bool IsConnected;

        public MbInterface() { }

        public abstract bool Connect ();
        public abstract void DisConnect();
        public abstract bool ReceiveHeader(DeviceType dtype, MbRawData MbData);

        public abstract void SendFrame(MbRawData TransmitData, int Length);

        public virtual void ReceiveBytes(MbRawData RxData, int count)  { }
        public virtual void EndOfFrame(MbRawData RxData) { }

        public bool ReConnect()
        {
            DisConnect();
            return Connect();
            // TODO error checking
        }

    }
}
