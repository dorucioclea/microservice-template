using System.Text.RegularExpressions;

namespace Genocs.Microservice.Template.Infrastructure.Common.Extensions;

public static class RegexExtensions
{
    private static readonly Regex Whitespace = new(@"\s+");

    public static string ReplaceWhitespace(this string input, string replacement)
    {
        return Whitespace.Replace(input, replacement);
    }
}