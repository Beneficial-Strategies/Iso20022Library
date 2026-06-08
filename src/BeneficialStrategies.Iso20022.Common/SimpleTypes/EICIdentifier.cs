// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Energy identification coding scheme.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PBKoEA3cEeW9YKj3GUmIEw")]
[Description(@"Energy identification coding scheme.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<EICIdentifier>))]
public readonly struct EICIdentifier : IIsoSimpleValue<string>, IEquatable<EICIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z0-9\-]{16}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public EICIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(EICIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out EICIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="EICIdentifier"/>.</summary>
    public static implicit operator EICIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(EICIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(EICIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is EICIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(EICIdentifier a, EICIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(EICIdentifier a, EICIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(EICIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(EICIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, EICIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, EICIdentifier b) => a != b.Value;
}
