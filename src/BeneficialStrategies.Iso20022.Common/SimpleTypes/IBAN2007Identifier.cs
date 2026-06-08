// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// The International Bank Account Number is a code used internationally by financial institutions to uniquely identify the account of a customer at a financial institution as described in the 2007 edition of the ISO 13616 standard.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYxm0dp-Ed-ak6NoX_4Aeg_1226525818")]
[Description(@"The International Bank Account Number is a code used internationally by financial institutions to uniquely identify the account of a customer at a financial institution as described in the 2007 edition of the ISO 13616 standard.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<IBAN2007Identifier>))]
public readonly struct IBAN2007Identifier : IIsoSimpleValue<string>, IEquatable<IBAN2007Identifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public IBAN2007Identifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(IBAN2007Identifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out IBAN2007Identifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="IBAN2007Identifier"/>.</summary>
    public static implicit operator IBAN2007Identifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(IBAN2007Identifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(IBAN2007Identifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is IBAN2007Identifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(IBAN2007Identifier a, IBAN2007Identifier b) => a.Equals(b);
    public static bool operator !=(IBAN2007Identifier a, IBAN2007Identifier b) => !a.Equals(b);
    public static bool operator ==(IBAN2007Identifier a, string? b) => a.Value == b;
    public static bool operator !=(IBAN2007Identifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, IBAN2007Identifier b) => a == b.Value;
    public static bool operator !=(string? a, IBAN2007Identifier b) => a != b.Value;
}
