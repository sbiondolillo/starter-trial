using System.CommandLine;
using Core;
using Xunit;

namespace Specs.Unit;

public sealed class GreetCommandTests
{
    private static (int ExitCode, string Output) Run(params string[] args)
    {
        using var output = new StringWriter();
        int exitCode = GreetCommand.Create().Parse(args).Invoke(new InvocationConfiguration { Output = output });
        return (exitCode, output.ToString());
    }

    [Fact]
    public void ShoutUpperCasesTheGreeting()
    {
        (int exitCode, string? output) = Run("Ada", "--shout");
        Assert.True(exitCode is 0);
        Assert.Equal("HELLO, ADA!", output.TrimEnd());
    }

    [Fact]
    public void WithoutShoutTheGreetingKeepsItsCase()
    {
        (int exitCode, string? output) = Run("Ada");
        Assert.True(exitCode is 0);
        Assert.Equal("Hello, Ada!", output.TrimEnd());
    }
}
