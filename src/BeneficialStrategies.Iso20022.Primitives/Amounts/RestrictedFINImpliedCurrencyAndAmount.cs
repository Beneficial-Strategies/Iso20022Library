// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// ISO 20022 RestrictedFINImpliedCurrencyAndAmount — an amount whose currency is implied by the context.
/// </summary>
/// <remarks>
/// Per the ISO 20022 data dictionary: "Number of monetary units specified in a currency where the unit of currency is implied by
/// the context and compliant with ISO 4217. The decimal separator is a dot. Note: a zero amount is considered a positive amount."
/// The dictionary entry has no currency identifier set, so this type is a plain decimal on the wire (<c>&lt;Amt&gt;10.50&lt;/Amt&gt;</c>,
/// no <c>Ccy</c> attribute): not negative, at most 14 digits in total, of which at most 5 after the decimal point.
/// The amount types that do name their currency are records with a <c>Currency</c> and an <c>Amount</c>.
/// It is an <see cref="IIsoCompositeSimpleValue"/> only so that the XML reader hands the whole text to the <c>(string)</c> constructor,
/// which accepts digits with an optional decimal point and nothing else (no sign, blanks or thousands separators).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_XZJV1Np-Ed-ak6NoX_4Aeg_681057429")]
[Description(
    @"Number of monetary units specified in a currency where the unit of currency is implied by the context and compliant with ISO 4217. The decimal separator is a dot.|Note: a zero amount is considered a positive amount."
)]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<RestrictedFINImpliedCurrencyAndAmount, decimal>))]
public readonly struct RestrictedFINImpliedCurrencyAndAmount : IIsoSimpleValue<decimal>, IIsoAmount, IIsoCompositeSimpleValue, IEquatable<RestrictedFINImpliedCurrencyAndAmount>
{
    /// <summary>The most digits the value may have in total.</summary>
    public const int TotalDigits = 14;

    /// <summary>The most digits the value may have after the decimal point.</summary>
    public const int FractionDigits = 5;

    /// <inheritdoc/>
    public decimal Value { get; }

    /// <summary>Initializes from a decimal: not negative, within the digit limits.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is negative or has too many digits.</exception>
    public RestrictedFINImpliedCurrencyAndAmount(decimal value)
    {
        if (value < 0m)
            throw new Iso20022FormatException(typeof(RestrictedFINImpliedCurrencyAndAmount), value.ToString(CultureInfo.InvariantCulture), "not negative");
        var scale = GetScale(value);
        if (scale > FractionDigits)
            throw new Iso20022FormatException(typeof(RestrictedFINImpliedCurrencyAndAmount), value.ToString(CultureInfo.InvariantCulture), $"at most {FractionDigits} fraction digits");
        if (CountIntegerDigits(value) + scale > TotalDigits)
            throw new Iso20022FormatException(typeof(RestrictedFINImpliedCurrencyAndAmount), value.ToString(CultureInfo.InvariantCulture), $"at most {TotalDigits} significant digits total");
        Value = value;
    }

    /// <summary>Initializes by parsing a decimal string (a dot as the decimal separator).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid amount.</exception>
    public RestrictedFINImpliedCurrencyAndAmount(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!decimal.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(RestrictedFINImpliedCurrencyAndAmount), value, "decimal string, digits with an optional decimal point");
        this = new(parsed);
    }

    private static byte GetScale(decimal d) => (byte)((decimal.GetBits(d)[3] >> 16) & 0x7F);

    private static int CountIntegerDigits(decimal value)
    {
        var integerPart = Math.Truncate(Math.Abs(value));
        return integerPart == 0m ? 1 : integerPart.ToString(CultureInfo.InvariantCulture).Length;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid amount.</summary>
    public static bool TryCreate(decimal value, [NotNullWhen(true)] out RestrictedFINImpliedCurrencyAndAmount result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid amount string.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINImpliedCurrencyAndAmount result)
    {
        if (value is not null && decimal.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var parsed))
        {
            try
            { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="decimal"/>.</summary>
    public static implicit operator RestrictedFINImpliedCurrencyAndAmount(decimal value) => new(value);
    /// <summary>Implicitly unwraps to the <see cref="decimal"/>.</summary>
    public static implicit operator decimal(RestrictedFINImpliedCurrencyAndAmount v) => v.Value;
    /// <summary>Implicitly wraps a wire string.</summary>
    public static implicit operator RestrictedFINImpliedCurrencyAndAmount(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(RestrictedFINImpliedCurrencyAndAmount v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(RestrictedFINImpliedCurrencyAndAmount other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINImpliedCurrencyAndAmount other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(RestrictedFINImpliedCurrencyAndAmount a, RestrictedFINImpliedCurrencyAndAmount b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(RestrictedFINImpliedCurrencyAndAmount a, RestrictedFINImpliedCurrencyAndAmount b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(RestrictedFINImpliedCurrencyAndAmount a, decimal b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(RestrictedFINImpliedCurrencyAndAmount a, decimal b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(decimal a, RestrictedFINImpliedCurrencyAndAmount b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(decimal a, RestrictedFINImpliedCurrencyAndAmount b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(RestrictedFINImpliedCurrencyAndAmount a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(RestrictedFINImpliedCurrencyAndAmount a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, RestrictedFINImpliedCurrencyAndAmount b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, RestrictedFINImpliedCurrencyAndAmount b) => a != b.ToString();
}
