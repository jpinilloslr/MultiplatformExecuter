using System;
using System.Collections.Generic;
using System.Text;

namespace MultiplatformExecuter.Data
{
    public class Template
    {
        public IEnumerable<Parameter> Parameters { get; set; }
        public IEnumerable<string> Run { get; set; }
    }
}
