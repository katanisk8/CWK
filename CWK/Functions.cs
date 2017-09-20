using System.Diagnostics;
using System.Windows.Forms;

namespace CWK
{
    class Functions
    {
        public enum WhatToDo
        {
            ShutDown,
            Hibernate,
            Sleep
        }

        public static void Function(WhatToDo WhatToDo)
        {
            switch (WhatToDo)
            {
                case WhatToDo.ShutDown:
                    var shutDownProcess = new ProcessStartInfo("shutdown", "/s /t 0");
                    shutDownProcess.CreateNoWindow = true;
                    shutDownProcess.UseShellExecute = false;
                    Process.Start(shutDownProcess);
                    break;
                case WhatToDo.Hibernate:
                    Application.SetSuspendState(PowerState.Hibernate, true, true);
                    break;
                case WhatToDo.Sleep:
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }
    }
}
