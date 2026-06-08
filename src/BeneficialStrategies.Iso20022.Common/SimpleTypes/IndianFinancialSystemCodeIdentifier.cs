// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Indian Financial System Code Identifier. Identifies Indian financial institutions on the Indian national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYn10Np-Ed-ak6NoX_4Aeg_-1110573084")]
[Description(@"Indian Financial System Code Identifier. Identifies Indian financial institutions on the Indian national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<IndianFinancialSystemCodeIdentifier>))]
public readonly struct IndianFinancialSystemCodeIdentifier : IIsoSimpleValue<string>, IEquatable<IndianFinancialSystemCodeIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^IN[a-zA-Z0-9]{11,11}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public IndianFinancialSystemCodeIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(IndianFinancialSystemCodeIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out IndianFinancialSystemCodeIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="IndianFinancialSystemCodeIdentifier"/>.</summary>
    public static implicit operator IndianFinancialSystemCodeIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(IndianFinancialSystemCodeIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(IndianFinancialSystemCodeIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is IndianFinancialSystemCodeIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(IndianFinancialSystemCodeIdentifier a, IndianFinancialSystemCodeIdentifier b)  => a.Equals(b);
    public static bool operator !=(IndianFinancialSystemCodeIdentifier a, IndianFinancialSystemCodeIdentifier b)  => !a.Equals(b);
    public static bool operator ==(IndianFinancialSystemCodeIdentifier a, string? b)  => a.Value == b;
    public static bool operator !=(IndianFinancialSystemCodeIdentifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, IndianFinancialSystemCodeIdentifier b)  => a == b.Value;
    public static bool operator !=(string? a, IndianFinancialSystemCodeIdentifier b)  => a != b.Value;
}
