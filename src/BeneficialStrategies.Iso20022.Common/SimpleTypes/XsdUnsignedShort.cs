// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:unsignedShort — unsigned 16-bit integer (0 to 65 535).
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:unsignedShort</c>.
/// Wire format: decimal integer string (e.g. <c>"42"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <see cref="ushort"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("unsignedShort_ID")]
[Description(@"W3C XML Schema xs:unsignedShort — unsigned 16-bit integer (0 to 65 535).")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdUnsignedShort, ushort>))]
public readonly struct XsdUnsignedShort : IIsoSimpleValue<ushort>, IEquatable<XsdUnsignedShort>
{
    /// <inheritdoc/>
    public ushort Value { get; }

    /// <summary>Initializes from the native <see cref="ushort"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside the allowed range.</exception>
    public XsdUnsignedShort(ushort value)
    {
        Value = value;
    }

    /// <summary>Initializes by parsing the W3C XSD decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid ushort.</exception>
    public XsdUnsignedShort(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!ushort.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(XsdUnsignedShort), value, "xs:unsignedShort — ushort decimal integer");
        this = new(parsed); // delegate to native ctor for range check
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(ushort value, [NotNullWhen(true)] out XsdUnsignedShort result)
    {
        try { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid ushort.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdUnsignedShort result)
    {
        if (value is not null && ushort.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            try { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a <see cref="ushort"/> as a <see cref="XsdUnsignedShort"/>.</summary>
    public static implicit operator XsdUnsignedShort(ushort value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="ushort"/> value.</summary>
    public static implicit operator ushort(XsdUnsignedShort v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdUnsignedShort"/>.</summary>
    public static implicit operator XsdUnsignedShort(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdUnsignedShort v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdUnsignedShort other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdUnsignedShort other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(XsdUnsignedShort a, XsdUnsignedShort b) => a.Value == b.Value;
    public static bool operator !=(XsdUnsignedShort a, XsdUnsignedShort b) => a.Value != b.Value;
    public static bool operator ==(XsdUnsignedShort a, ushort b) => a.Value == b;
    public static bool operator !=(XsdUnsignedShort a, ushort b) => a.Value != b;
    public static bool operator ==(ushort a, XsdUnsignedShort b) => a == b.Value;
    public static bool operator !=(ushort a, XsdUnsignedShort b) => a != b.Value;
    public static bool operator ==(XsdUnsignedShort a, string? b) => a.ToString() == b;
    public static bool operator !=(XsdUnsignedShort a, string? b) => a.ToString() != b;
    public static bool operator ==(string? a, XsdUnsignedShort b) => a == b.ToString();
    public static bool operator !=(string? a, XsdUnsignedShort b) => a != b.ToString();
}
