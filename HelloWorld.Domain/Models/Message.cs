using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Domain.Models
{
    [Serializable()]
    public class Message : IMessage
    {
        public string Value { get; set; }
    }
}
