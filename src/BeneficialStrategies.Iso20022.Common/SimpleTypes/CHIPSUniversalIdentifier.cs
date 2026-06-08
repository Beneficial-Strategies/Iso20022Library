// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// CHIPS Universal Identification. Identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXIoEdp-Ed-ak6NoX_4Aeg_-870708024")]
[Description(@"CHIPS Universal Identification. Identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<CHIPSUniversalIdentifier>))]
public readonly struct CHIPSUniversalIdentifier : IIsoSimpleValue<string>, IEquatable<CHIPSUniversalIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^CH[0-9]{6,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public CHIPSUniversalIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(CHIPSUniversalIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out CHIPSUniversalIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="CHIPSUniversalIdentifier"/>.</summary>
    public static implicit operator CHIPSUniversalIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(CHIPSUniversalIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(CHIPSUniversalIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is CHIPSUniversalIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(CHIPSUniversalIdentifier a, CHIPSUniversalIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(CHIPSUniversalIdentifier a, CHIPSUniversalIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(CHIPSUniversalIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(CHIPSUniversalIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, CHIPSUniversalIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, CHIPSUniversalIdentifier b) => a != b.Value;
}
