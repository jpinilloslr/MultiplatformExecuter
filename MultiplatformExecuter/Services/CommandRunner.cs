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
            var shell = GetShell();
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = shell.fileName,
                    Arguments = $"{shell.commandOption} \"{command}\"",
                    CreateNoWindow = false,
                    UseShellExecute = false,
                }
            };
            process.Start();
            process.WaitForExit();
        }

        private static (string fileName, string commandOption) GetShell() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? ("powershell.exe", "/c")
                : ("/bin/bash", "-c");
    }
}
