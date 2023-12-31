using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLR8.Model
{
    public class MyCommandOptions
    {
        [Option('v', "verbose", Required = false, HelpText = "Enable verbose mode")]
        public bool Verbose { get; set; }

        [Value(0, MetaName = "input", HelpText = "Input file")]
        public string InputFile { get; set; }
    }
}
