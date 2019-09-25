using System;
using System.Collections.Generic;
using System.Text;

namespace PortsAndAdapters.Hexagon.Ports.Driven.Sms
{
    public interface ISmsSender
    {
        void SendSms(string receiverNumber, string message);
    }
}
