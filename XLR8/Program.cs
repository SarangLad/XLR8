// See https://aka.ms/new-console-template for more information
using CommandLine;
using XLR8.Model;
using XLR8.Reposetory;


//parse the command line arguments and execute the appropriate command.
Parser.Default.ParseArguments<MyCommandOptions>(args)
        .WithParsed(options => ExecuteRepository.ExecuteCommand(options))
        .WithNotParsed(errors => ExecuteRepository.HandleParsingErrors(errors));


