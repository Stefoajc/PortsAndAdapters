using System;
using System.Collections.Generic;
using System.Text;
using PortsAndAdapters.Hexagon.Ports.Driven.Sms;

namespace PortsAndAdapters.DrivenAdapters.SmsAdapters
{
    public class TwillioSmsAdapter : ISmsSender
    {
        public void SendSms(string receiverNumber, string message) => throw new NotImplementedException();
    }
}
