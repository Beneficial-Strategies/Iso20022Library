// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Universal Payment Identification Code. Identifier used by the New York Clearing House to mask confidential data such as bank accounts and bank routing numbers.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXlUAdp-Ed-ak6NoX_4Aeg_-1872488862")]
[Description(@"Universal Payment Identification Code. Identifier used by the New York Clearing House to mask confidential data such as bank accounts and bank routing numbers.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<UPICIdentifier>))]
public readonly struct UPICIdentifier : IIsoSimpleValue<string>, IEquatable<UPICIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[0-9]{8,17}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public UPICIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(UPICIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out UPICIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="UPICIdentifier"/>.</summary>
    public static implicit operator UPICIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(UPICIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(UPICIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is UPICIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(UPICIdentifier a, UPICIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(UPICIdentifier a, UPICIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(UPICIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(UPICIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, UPICIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, UPICIdentifier b) => a != b.Value;
}
