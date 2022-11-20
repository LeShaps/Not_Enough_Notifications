using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.IO;

namespace NeN_Update_Checker
{
    public partial class Service1 : ServiceBase
    {
        readonly Timer Timer = new Timer();

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer.Elapsed += OnElapsedTime;
            Timer.Interval = 60000;
            Timer.Enabled = true;
        }

        private void OnElapsedTime(object sender, ElapsedEventArgs e)
        {
            //TODO: Send end of timer notification to Addons
        }

        protected override void OnStop()
        {
            //TODO: Send end of timer notification to Addon, in case of abrupt end
        }
    }
}
