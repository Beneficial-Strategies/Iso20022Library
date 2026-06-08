// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Swiss Bank Code. Identifies Swiss institutions on the Swiss national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YW-3E9p-Ed-ak6NoX_4Aeg_-870708087")]
[Description(@"Swiss Bank Code. Identifies Swiss institutions on the Swiss national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<SwissBCIdentifier>))]
public readonly struct SwissBCIdentifier : IIsoSimpleValue<string>, IEquatable<SwissBCIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^SW[0-9]{3,5}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public SwissBCIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(SwissBCIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out SwissBCIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="SwissBCIdentifier"/>.</summary>
    public static implicit operator SwissBCIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(SwissBCIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(SwissBCIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is SwissBCIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(SwissBCIdentifier a, SwissBCIdentifier b)  => a.Equals(b);
    public static bool operator !=(SwissBCIdentifier a, SwissBCIdentifier b)  => !a.Equals(b);
    public static bool operator ==(SwissBCIdentifier a, string? b)  => a.Value == b;
    public static bool operator !=(SwissBCIdentifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, SwissBCIdentifier b)  => a == b.Value;
    public static bool operator !=(string? a, SwissBCIdentifier b)  => a != b.Value;
}
