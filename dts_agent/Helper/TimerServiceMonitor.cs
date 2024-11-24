using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using dts_logger.Logger;

namespace dts_agent.Helper
{
    public class TimerServiceMonitor
    {
        private static ManagementEventWatcher processStopEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStopTrace");

        public static void Initialize()
        {
            processStopEvent.EventArrived += CheckIfTimerServiceStopped;
            processStopEvent.Start();
        }

        private static void CheckIfTimerServiceStopped(object sender, EventArrivedEventArgs e)
        {
            string processName = Convert.ToString(e.NewEvent.Properties["ProcessName"].Value);

            if (processName.ToLower().Contains("timerservice"))
            {
                CodedLogger.LogClearText("[Agent] Timer service stopped. Shutting down");

#if RELEASE

                StationUtil.Shutdown();
#endif
            }
        }
    }
}