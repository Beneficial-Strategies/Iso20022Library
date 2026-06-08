// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// New Zealand Bank/Branch Code. Identifies New Zealand institutions on the New Zealand national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXIoENp-Ed-ak6NoX_4Aeg_-870708035")]
[Description(@"New Zealand Bank/Branch Code. Identifies New Zealand institutions on the New Zealand national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<NewZealandNCCIdentifier>))]
public readonly struct NewZealandNCCIdentifier : IIsoSimpleValue<string>, IEquatable<NewZealandNCCIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^NZ[0-9]{6,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public NewZealandNCCIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(NewZealandNCCIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out NewZealandNCCIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="NewZealandNCCIdentifier"/>.</summary>
    public static implicit operator NewZealandNCCIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(NewZealandNCCIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(NewZealandNCCIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is NewZealandNCCIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(NewZealandNCCIdentifier a, NewZealandNCCIdentifier b)  => a.Equals(b);
    public static bool operator !=(NewZealandNCCIdentifier a, NewZealandNCCIdentifier b)  => !a.Equals(b);
    public static bool operator ==(NewZealandNCCIdentifier a, string? b)  => a.Value == b;
    public static bool operator !=(NewZealandNCCIdentifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, NewZealandNCCIdentifier b)  => a == b.Value;
    public static bool operator !=(string? a, NewZealandNCCIdentifier b)  => a != b.Value;
}
