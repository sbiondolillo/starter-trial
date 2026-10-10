namespace Core;

/// <summary>The greeting the console program prints.</summary>
public static class Greeter
{
    public static string Greet(string name) => $"Hello, {name}!";

    /// <summary>The greeting of <paramref name="name"/>, in upper case when <paramref name="shout"/> is <c>true</c>.</summary>
    public static string Greet(string name, bool shout) => shout ? Greet(name).ToUpperInvariant() : Greet(name);
}
