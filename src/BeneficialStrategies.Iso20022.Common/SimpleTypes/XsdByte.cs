// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:byte — signed 8-bit integer (-128 to 127). Note: this is C# sbyte, NOT byte.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:byte</c>.
/// Wire format: decimal integer string (e.g. <c>"42"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <see cref="sbyte"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("byte_ID")]
[Description(@"W3C XML Schema xs:byte — signed 8-bit integer (-128 to 127). Note: this is C# sbyte, NOT byte.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdByte, sbyte>))]
public readonly struct XsdByte : IIsoSimpleValue<sbyte>, IEquatable<XsdByte>
{
    /// <inheritdoc/>
    public sbyte Value { get; }

    /// <summary>Initializes from the native <see cref="sbyte"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside the allowed range.</exception>
    public XsdByte(sbyte value)
    {
        Value = value;
    }

    /// <summary>Initializes by parsing the W3C XSD decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid sbyte.</exception>
    public XsdByte(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!sbyte.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(XsdByte), value, "xs:byte — sbyte decimal integer");
        this = new(parsed); // delegate to native ctor for range check
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(sbyte value, [NotNullWhen(true)] out XsdByte result)
    {
        try { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid sbyte.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdByte result)
    {
        if (value is not null && sbyte.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            try { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a <see cref="sbyte"/> as a <see cref="XsdByte"/>.</summary>
    public static implicit operator XsdByte(sbyte value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="sbyte"/> value.</summary>
    public static implicit operator sbyte(XsdByte v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdByte"/>.</summary>
    public static implicit operator XsdByte(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdByte v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdByte other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdByte other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(XsdByte a, XsdByte b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(XsdByte a, XsdByte b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdByte a, sbyte b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdByte a, sbyte b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(sbyte a, XsdByte b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(sbyte a, XsdByte b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdByte a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdByte a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdByte b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdByte b) => a != b.ToString();
}
