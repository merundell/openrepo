using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceProcess;
using PingService;

namespace ConsoleApplication1
{
    public partial class MyServiceHost : ServiceBase
    {
        ServiceHost host;

        public MyServiceHost()
        {
            //InitializeComponent();
        }

        public void Start()
        {
            OnStart(null);
        }

        public void Stop()
        {
            OnStop();
        }

        protected override void OnStart(string[] args)
        {
            Type serviceType = typeof(PingResponder);
            host = new ServiceHost(serviceType);
            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null) host.Close();
        }
    }
}
