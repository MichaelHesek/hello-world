using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Domain.Services
{
    public abstract class BaseService : IBaseService, IDisposable
    {
        private ServiceManager _serviceManager = new ServiceManager();
        /// <summary>
        /// Service Factory
        /// </summary>
        public ServiceManager ServiceManager
        {
            get { return _serviceManager; }
        }

        private ModelManager _modelManager = new ModelManager();

        /// <summary>
        /// Model Factory
        /// </summary>
        public ModelManager ModelManager
        {
            get { return _modelManager; }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                }
            }
            this._disposed = true;
        }
    }
}
