// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:short — signed 16-bit integer (-32 768 to 32 767).
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:short</c>.
/// Wire format: decimal integer string (e.g. <c>"42"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <see cref="short"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("short_ID")]
[Description(@"W3C XML Schema xs:short — signed 16-bit integer (-32 768 to 32 767).")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdShort, short>))]
public readonly struct XsdShort : IIsoSimpleValue<short>, IEquatable<XsdShort>
{
    /// <inheritdoc/>
    public short Value { get; }

    /// <summary>Initializes from the native <see cref="short"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside the allowed range.</exception>
    public XsdShort(short value)
    {
        Value = value;
    }

    /// <summary>Initializes by parsing the W3C XSD decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid short.</exception>
    public XsdShort(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!short.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(XsdShort), value, "xs:short — short decimal integer");
        this = new(parsed); // delegate to native ctor for range check
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(short value, [NotNullWhen(true)] out XsdShort result)
    {
        try { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid short.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdShort result)
    {
        if (value is not null && short.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            try { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a <see cref="short"/> as a <see cref="XsdShort"/>.</summary>
    public static implicit operator XsdShort(short value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="short"/> value.</summary>
    public static implicit operator short(XsdShort v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdShort"/>.</summary>
    public static implicit operator XsdShort(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdShort v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdShort other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdShort other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(XsdShort a, XsdShort b) => a.Value == b.Value;
    public static bool operator !=(XsdShort a, XsdShort b) => a.Value != b.Value;
    public static bool operator ==(XsdShort a, short b) => a.Value == b;
    public static bool operator !=(XsdShort a, short b) => a.Value != b;
    public static bool operator ==(short a, XsdShort b) => a == b.Value;
    public static bool operator !=(short a, XsdShort b) => a != b.Value;
    public static bool operator ==(XsdShort a, string? b) => a.ToString() == b;
    public static bool operator !=(XsdShort a, string? b) => a.ToString() != b;
    public static bool operator ==(string? a, XsdShort b) => a == b.ToString();
    public static bool operator !=(string? a, XsdShort b) => a != b.ToString();
}
