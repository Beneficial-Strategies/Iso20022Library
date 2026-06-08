// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// International Business Entity Identifier to uniquely identify business entities playing a role in the lifecycle of and events related to a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYer5dp-Ed-ak6NoX_4Aeg_-1802674178")]
[Description(@"International Business Entity Identifier to uniquely identify business entities playing a role in the lifecycle of and events related to a financial instrument.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<IBEIIdentifier>))]
public readonly struct IBEIIdentifier : IIsoSimpleValue<string>, IEquatable<IBEIIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z]{2,2}[B-DF-HJ-NP-TV-XZ0-9]{7,7}[0-9]{1,1}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public IBEIIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(IBEIIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out IBEIIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="IBEIIdentifier"/>.</summary>
    public static implicit operator IBEIIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(IBEIIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(IBEIIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is IBEIIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(IBEIIdentifier a, IBEIIdentifier b)  => a.Equals(b);
    public static bool operator !=(IBEIIdentifier a, IBEIIdentifier b)  => !a.Equals(b);
    public static bool operator ==(IBEIIdentifier a, string? b)  => a.Value == b;
    public static bool operator !=(IBEIIdentifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, IBEIIdentifier b)  => a == b.Value;
    public static bool operator !=(string? a, IBEIIdentifier b)  => a != b.Value;
}
