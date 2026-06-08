// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Swiss Interbank Clearing (SIC) Code. Identifies Swiss financial institutions domestically on the Swiss national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXIoFtp-Ed-ak6NoX_4Aeg_-870707964")]
[Description(@"Swiss Interbank Clearing (SIC) Code. Identifies Swiss financial institutions domestically on the Swiss national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<SwissSICIdentifier>))]
public readonly struct SwissSICIdentifier : IIsoSimpleValue<string>, IEquatable<SwissSICIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^SW[0-9]{6,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public SwissSICIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(SwissSICIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out SwissSICIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="SwissSICIdentifier"/>.</summary>
    public static implicit operator SwissSICIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(SwissSICIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(SwissSICIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is SwissSICIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(SwissSICIdentifier a, SwissSICIdentifier b) => a.Equals(b);
    public static bool operator !=(SwissSICIdentifier a, SwissSICIdentifier b) => !a.Equals(b);
    public static bool operator ==(SwissSICIdentifier a, string? b) => a.Value == b;
    public static bool operator !=(SwissSICIdentifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, SwissSICIdentifier b) => a == b.Value;
    public static bool operator !=(string? a, SwissSICIdentifier b) => a != b.Value;
}
