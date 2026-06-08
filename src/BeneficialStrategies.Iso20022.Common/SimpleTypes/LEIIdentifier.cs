// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Legal Entity Identifier is a code allocated to a party as described in ISO 17442 Financial Services - Legal Entity Identifier (LEI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_h7Yn9yjAEeKnA5P_jl2DUw")]
[Description(@"Legal Entity Identifier is a code allocated to a party as described in ISO 17442 Financial Services - Legal Entity Identifier (LEI).")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<LEIIdentifier>))]
public readonly struct LEIIdentifier : IIsoSimpleValue<string>, IEquatable<LEIIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z0-9]{18,18}[0-9]{2,2}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public LEIIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(LEIIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out LEIIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="LEIIdentifier"/>.</summary>
    public static implicit operator LEIIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(LEIIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(LEIIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is LEIIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(LEIIdentifier a, LEIIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(LEIIdentifier a, LEIIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(LEIIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(LEIIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, LEIIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, LEIIdentifier b) => a != b.Value;
}
