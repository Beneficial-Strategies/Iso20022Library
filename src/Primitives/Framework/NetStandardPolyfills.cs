// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

#if NETSTANDARD2_0
// netstandard2.0 has no ArgumentNullException.ThrowIfNull (.NET 6). The types write it as ArgumentNullException.ThrowIfNull(value),
// and in this build the name means the polyfill below, which has the same method; nothing else of the exception is used here.
global using ArgumentNullException = BeneficialStrategies.Iso20022.Framework.ArgumentNullExceptionPolyfill;

namespace BeneficialStrategies.Iso20022.Framework;

internal static class ArgumentNullExceptionPolyfill
{
    public static void ThrowIfNull(object? argument, [System.Runtime.CompilerServices.CallerArgumentExpression(nameof(argument))] string? paramName = null)
    {
        if (argument is null)
            throw new System.ArgumentNullException(paramName);
    }
}
#endif
