// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Universally Unique IDentifier (UUID) version 4, as described in IETC RFC 4122.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TQIBwHrVEeidVZmeoasaWQ")]
[Description(@"Universally Unique IDentifier (UUID) version 4, as described in IETC RFC 4122.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<UUIDv4Identifier>))]
public readonly struct UUIDv4Identifier : IIsoSimpleValue<string>, IEquatable<UUIDv4Identifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public UUIDv4Identifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(UUIDv4Identifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out UUIDv4Identifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="UUIDv4Identifier"/>.</summary>
    public static implicit operator UUIDv4Identifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(UUIDv4Identifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(UUIDv4Identifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is UUIDv4Identifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(UUIDv4Identifier a, UUIDv4Identifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(UUIDv4Identifier a, UUIDv4Identifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(UUIDv4Identifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(UUIDv4Identifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, UUIDv4Identifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, UUIDv4Identifier b) => a != b.Value;
}
