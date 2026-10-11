using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

internal static class ArgumentNullExceptionHelper
{
    public static void ThrowIfNull(
        object? argument,
        [CallerArgumentExpression(nameof(argument))] string? paramName = null)
    {
#if NET462
        if (argument is null)
            throw new ArgumentNullException(paramName);
#else
        ArgumentNullException.ThrowIfNull(argument, paramName);
#endif
    }
}
