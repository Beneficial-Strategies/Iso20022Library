// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Basic Bank Account Number. Identifier used nationally by financial institutions, generally as part of a National Account Numbering Scheme, which uniquely identifies the account of a customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YWr8Jtp-Ed-ak6NoX_4Aeg_-1329929778")]
[Description(@"Basic Bank Account Number. Identifier used nationally by financial institutions, generally as part of a National Account Numbering Scheme, which uniquely identifies the account of a customer.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<BBANIdentifier>))]
public readonly struct BBANIdentifier : IIsoSimpleValue<string>, IEquatable<BBANIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[a-zA-Z0-9]{1,30}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public BBANIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(BBANIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out BBANIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="BBANIdentifier"/>.</summary>
    public static implicit operator BBANIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(BBANIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(BBANIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is BBANIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(BBANIdentifier a, BBANIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(BBANIdentifier a, BBANIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(BBANIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(BBANIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, BBANIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, BBANIdentifier b) => a != b.Value;
}
