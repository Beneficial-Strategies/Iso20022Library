// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the legal act framework.
/// </summary>
/// <remarks>
/// Per MCP, a versioned restriction of ExternalLegalFrameworkCode.
/// Length facet from MCP: minLength=1, maxLength=6
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_JGjp8Jg4Ee6uVIkU2PD78Q")]
[Description(@"Specifies the legal act framework.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalLegalFramework1Code>))]
public readonly struct ExternalLegalFramework1Code : IIsoExternalCode, IEquatable<ExternalLegalFramework1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalLegalFramework1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalLegalFramework1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalLegalFramework1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalLegalFramework1Code"/>.</summary>
    public static implicit operator ExternalLegalFramework1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalLegalFramework1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalLegalFramework1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalLegalFramework1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalLegalFramework1Code a, ExternalLegalFramework1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalLegalFramework1Code a, ExternalLegalFramework1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalLegalFramework1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalLegalFramework1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalLegalFramework1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalLegalFramework1Code b) => a != b.Value;
}
