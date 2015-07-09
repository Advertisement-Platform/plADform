using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MyRESTService;

namespace WindowsServiceHost
{
    public partial class MyServiceHost : ServiceBase
    {
        private ServiceHost _serviceHost = null;
        public MyServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _serviceHost = new ServiceHost(typeof(RestService));
            _serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (_serviceHost != null)
            {
                _serviceHost.Close();
                _serviceHost = null;
            }
        }
    }
}
