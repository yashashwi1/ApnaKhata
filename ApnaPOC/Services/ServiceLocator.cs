using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaPOC.Services
{
    internal class ServiceLocator
    {
        private string interceptorServiceUrl;

        public ServiceLocator(string interceptorServiceUrl)
        { 
            this.interceptorServiceUrl = interceptorServiceUrl;
        }

        public string GetServiceBaseUrl()
        {
            return this.interceptorServiceUrl;
        }
    }
}
