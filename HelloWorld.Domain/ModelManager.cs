using HelloWorld.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Domain
{
    /// <summary>
    /// Model Factory
    /// </summary>
    public class ModelManager : IDisposable
    {
        public IMessage Message
        {
            get
            {
                return new Message();
            }
        }

        public void Dispose()
        {
        }
    }
}
