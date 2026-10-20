// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:unsignedByte — unsigned 8-bit integer (0 to 255).
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:unsignedByte</c>.
/// Wire format: decimal integer string (e.g. <c>"42"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <see cref="byte"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("unsignedByte_ID")]
[Description(@"W3C XML Schema xs:unsignedByte — unsigned 8-bit integer (0 to 255).")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdUnsignedByte, byte>))]
public readonly struct XsdUnsignedByte : IIsoSimpleValue<byte>, IEquatable<XsdUnsignedByte>
{
    /// <inheritdoc/>
    public byte Value { get; }

    /// <summary>Initializes from the native <see cref="byte"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside the allowed range.</exception>
    public XsdUnsignedByte(byte value)
    {
        Value = value;
    }

    /// <summary>Initializes by parsing the W3C XSD decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid byte.</exception>
    public XsdUnsignedByte(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!byte.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(XsdUnsignedByte), value, "xs:unsignedByte — byte decimal integer");
        this = new(parsed); // delegate to native ctor for range check
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(byte value, [NotNullWhen(true)] out XsdUnsignedByte result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid byte.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdUnsignedByte result)
    {
        if (value is not null && byte.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            try
            { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="byte"/> as a <see cref="XsdUnsignedByte"/>.</summary>
    public static implicit operator XsdUnsignedByte(byte value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="byte"/> value.</summary>
    public static implicit operator byte(XsdUnsignedByte v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdUnsignedByte"/>.</summary>
    public static implicit operator XsdUnsignedByte(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdUnsignedByte v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdUnsignedByte other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdUnsignedByte other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(XsdUnsignedByte a, XsdUnsignedByte b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(XsdUnsignedByte a, XsdUnsignedByte b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdUnsignedByte a, byte b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdUnsignedByte a, byte b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(byte a, XsdUnsignedByte b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(byte a, XsdUnsignedByte b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdUnsignedByte a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdUnsignedByte a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdUnsignedByte b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdUnsignedByte b) => a != b.ToString();
}
