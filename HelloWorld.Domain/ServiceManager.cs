using HelloWorld.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Domain
{
    /// <summary>
    /// Service Factory
    /// </summary>
    public class ServiceManager : IDisposable
    {
        public IMessageService MessageService
        {
            get
            {
                return new MessageService();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
        }
    }
}
