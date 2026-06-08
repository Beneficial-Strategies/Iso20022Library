// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Unique Transaction Identifier (UTI). Unique number allocated to a financial transaction as described in ISO 23897:2020.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_96JccAoBEeuy-oB3GWSNWw")]
[Description(@"Unique Transaction Identifier (UTI). Unique number allocated to a financial transaction as described in ISO 23897:2020.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<UTIIdentifier>))]
public readonly struct UTIIdentifier : IIsoSimpleValue<string>, IEquatable<UTIIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public UTIIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(UTIIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out UTIIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="UTIIdentifier"/>.</summary>
    public static implicit operator UTIIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(UTIIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(UTIIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is UTIIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(UTIIdentifier a, UTIIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(UTIIdentifier a, UTIIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(UTIIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(UTIIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, UTIIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, UTIIdentifier b) => a != b.Value;
}
