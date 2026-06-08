// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// An identifier of a security assigned by the Bloomberg organisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vwu6IVonEeaGcYxFfqiPNw")]
[Description(@"An identifier of a security assigned by the Bloomberg organisation.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Bloomberg2Identifier>))]
public readonly struct Bloomberg2Identifier : IIsoSimpleValue<string>, IEquatable<Bloomberg2Identifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^(BBG)[BCDFGHJKLMNPQRSTVWXYZ\d]{8}\d$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public Bloomberg2Identifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(Bloomberg2Identifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Bloomberg2Identifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Bloomberg2Identifier"/>.</summary>
    public static implicit operator Bloomberg2Identifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Bloomberg2Identifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Bloomberg2Identifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Bloomberg2Identifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Bloomberg2Identifier a, Bloomberg2Identifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Bloomberg2Identifier a, Bloomberg2Identifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Bloomberg2Identifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Bloomberg2Identifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Bloomberg2Identifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Bloomberg2Identifier b) => a != b.Value;
}
