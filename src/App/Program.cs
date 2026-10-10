using Core;
using System.CommandLine;

RootCommand root = GreetCommand.Create();
ParseResult parse = root.Parse(args);
return await parse.InvokeAsync().ConfigureAwait(false);
