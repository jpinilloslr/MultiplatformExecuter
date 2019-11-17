using MoreLinq;
using MultiplatformExecuter.Data;
using Newtonsoft.Json;
using System.IO;

namespace MultiplatformExecuter
{
    class Program
    {

        static void Main(string[] args)
        {
            var commandRunner = new CommandRunner();
            var templateJson = File.ReadAllText("template.json");
            var template = JsonConvert.DeserializeObject<Template>(templateJson);
            template.Run.ForEach(command => commandRunner.Run(command));
        }
    }
}
