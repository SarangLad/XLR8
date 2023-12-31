using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLR8.Model;

namespace XLR8.Reposetory
{
    public static class ExecuteRepository
    {
        public static void ExecuteCommand(MyCommandOptions options)
        {
            if (options.Verbose)
            {
                Console.WriteLine("Verbose mode enabled");
            }

            // Your command-specific logic here
            Console.WriteLine($"Executing command with input file: {options.InputFile}");
        }

        public static void HandleParsingErrors(IEnumerable<Error> errors)
        {
            // Handle parsing errors, display help, etc.
            Console.WriteLine("Invalid command. Use --help for usage information.");
        }
    }
}
