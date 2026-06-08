// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:unsignedInt — unsigned 32-bit integer (0 to 4 294 967 295).
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:unsignedInt</c>.
/// Wire format: decimal integer string (e.g. <c>"42"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <see cref="uint"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("unsignedInt_ID")]
[Description(@"W3C XML Schema xs:unsignedInt — unsigned 32-bit integer (0 to 4 294 967 295).")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdUnsignedInt, uint>))]
public readonly struct XsdUnsignedInt : IIsoSimpleValue<uint>, IEquatable<XsdUnsignedInt>
{
    /// <inheritdoc/>
    public uint Value { get; }

    /// <summary>Initializes from the native <see cref="uint"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside the allowed range.</exception>
    public XsdUnsignedInt(uint value)
    {
        Value = value;
    }

    /// <summary>Initializes by parsing the W3C XSD decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid uint.</exception>
    public XsdUnsignedInt(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!uint.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(XsdUnsignedInt), value, "xs:unsignedInt — uint decimal integer");
        this = new(parsed); // delegate to native ctor for range check
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(uint value, [NotNullWhen(true)] out XsdUnsignedInt result)
    {
        try { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid uint.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdUnsignedInt result)
    {
        if (value is not null && uint.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            try { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a <see cref="uint"/> as a <see cref="XsdUnsignedInt"/>.</summary>
    public static implicit operator XsdUnsignedInt(uint value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="uint"/> value.</summary>
    public static implicit operator uint(XsdUnsignedInt v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdUnsignedInt"/>.</summary>
    public static implicit operator XsdUnsignedInt(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdUnsignedInt v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdUnsignedInt other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdUnsignedInt other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(XsdUnsignedInt a, XsdUnsignedInt b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(XsdUnsignedInt a, XsdUnsignedInt b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdUnsignedInt a, uint b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdUnsignedInt a, uint b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(uint a, XsdUnsignedInt b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(uint a, XsdUnsignedInt b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdUnsignedInt a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdUnsignedInt a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdUnsignedInt b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdUnsignedInt b) => a != b.ToString();
}
