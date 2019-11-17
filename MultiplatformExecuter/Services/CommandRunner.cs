using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace MultiplatformExecuter
{
    public class CommandRunner
    {
        public void Run(string command)
        {
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = GetShell(),
                    Arguments = $"/c \"{command}\"",
                    CreateNoWindow = false,
                    UseShellExecute = false,
                }
            };
            process.Start();
            process.WaitForExit();
        }

        private static string GetShell() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? "powershell.exe"
                : "/bin/bash";
    }
}
