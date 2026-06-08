// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:unsignedLong — unsigned 64-bit integer (0 to 18 446 744 073 709 551 615).
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:unsignedLong</c>.
/// Wire format: decimal integer string (e.g. <c>"42"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <see cref="ulong"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("unsignedLong_ID")]
[Description(@"W3C XML Schema xs:unsignedLong — unsigned 64-bit integer (0 to 18 446 744 073 709 551 615).")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdUnsignedLong, ulong>))]
public readonly struct XsdUnsignedLong : IIsoSimpleValue<ulong>, IEquatable<XsdUnsignedLong>
{
    /// <inheritdoc/>
    public ulong Value { get; }

    /// <summary>Initializes from the native <see cref="ulong"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside the allowed range.</exception>
    public XsdUnsignedLong(ulong value)
    {
        Value = value;
    }

    /// <summary>Initializes by parsing the W3C XSD decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid ulong.</exception>
    public XsdUnsignedLong(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!ulong.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(XsdUnsignedLong), value, "xs:unsignedLong — ulong decimal integer");
        this = new(parsed); // delegate to native ctor for range check
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(ulong value, [NotNullWhen(true)] out XsdUnsignedLong result)
    {
        try { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid ulong.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdUnsignedLong result)
    {
        if (value is not null && ulong.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            try { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a <see cref="ulong"/> as a <see cref="XsdUnsignedLong"/>.</summary>
    public static implicit operator XsdUnsignedLong(ulong value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="ulong"/> value.</summary>
    public static implicit operator ulong(XsdUnsignedLong v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdUnsignedLong"/>.</summary>
    public static implicit operator XsdUnsignedLong(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdUnsignedLong v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdUnsignedLong other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdUnsignedLong other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(XsdUnsignedLong a, XsdUnsignedLong b) => a.Value == b.Value;
    public static bool operator !=(XsdUnsignedLong a, XsdUnsignedLong b) => a.Value != b.Value;
    public static bool operator ==(XsdUnsignedLong a, ulong b) => a.Value == b;
    public static bool operator !=(XsdUnsignedLong a, ulong b) => a.Value != b;
    public static bool operator ==(ulong a, XsdUnsignedLong b) => a == b.Value;
    public static bool operator !=(ulong a, XsdUnsignedLong b) => a != b.Value;
    public static bool operator ==(XsdUnsignedLong a, string? b) => a.ToString() == b;
    public static bool operator !=(XsdUnsignedLong a, string? b) => a.ToString() != b;
    public static bool operator ==(string? a, XsdUnsignedLong b) => a == b.ToString();
    public static bool operator !=(string? a, XsdUnsignedLong b) => a != b.ToString();
}
