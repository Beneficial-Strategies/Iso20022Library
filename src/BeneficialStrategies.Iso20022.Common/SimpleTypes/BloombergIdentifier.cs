// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// An identifier of a security assigned by the Bloomberg organisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYLJ49p-Ed-ak6NoX_4Aeg_1324881682")]
[Description(@"An identifier of a security assigned by the Bloomberg organisation.")]
[Obsolete("Marked obsolete in the ISO 20022 specification.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<BloombergIdentifier>))]
public readonly struct BloombergIdentifier : IIsoSimpleValue<string>, IEquatable<BloombergIdentifier>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 35;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> or
    /// <see cref="Iso20022FormatViolation.TooLong"/> when length is outside [1..35].
    /// </exception>
    public BloombergIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(BloombergIdentifier), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(BloombergIdentifier), value, MaxLength);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out BloombergIdentifier result)
    {
        if (value is { Length: >= MinLength and <= MaxLength }) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="BloombergIdentifier"/>.</summary>
    public static implicit operator BloombergIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(BloombergIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(BloombergIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is BloombergIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(BloombergIdentifier a, BloombergIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(BloombergIdentifier a, BloombergIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(BloombergIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(BloombergIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, BloombergIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, BloombergIdentifier b) => a != b.Value;
}
