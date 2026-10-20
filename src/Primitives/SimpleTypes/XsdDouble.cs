// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:double — an IEEE double-precision 64-bit floating-point number.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:double</c>.
/// Wire format: decimal or scientific notation (e.g. <c>"42.5"</c>, <c>"1.2E3"</c>), or one of
/// the special lexical values <c>"INF"</c>, <c>"-INF"</c>, <c>"NaN"</c> — NOT the .NET
/// <see cref="double.ToString()"/> output of <c>"Infinity"</c>/<c>"-Infinity"</c>/<c>"NaN"</c>.
/// Programmatic access via <see cref="Value"/> returns the native <see cref="double"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("double_ID")]
[Description(@"W3C XML Schema xs:double — an IEEE double-precision 64-bit floating-point number.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdDouble, double>))]
public readonly struct XsdDouble : IIsoSimpleValue<double>, IEquatable<XsdDouble>
{
    /// <inheritdoc/>
    public double Value { get; }

    /// <summary>Initializes from the native <see cref="double"/> value.</summary>
    /// <remarks>Every <see cref="double"/> bit pattern, including <see cref="double.PositiveInfinity"/>,
    /// <see cref="double.NegativeInfinity"/>, and <see cref="double.NaN"/>, is a valid xs:double value.</remarks>
    public XsdDouble(double value)
    {
        Value = value;
    }

    /// <summary>
    /// Initializes by parsing the W3C XSD xs:double lexical space: decimal/scientific notation,
    /// or the special values <c>"INF"</c>, <c>"-INF"</c>, <c>"NaN"</c>.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid xs:double.</exception>
    public XsdDouble(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!TryParseWireFormat(value, out var parsed))
            throw new Iso20022FormatException(typeof(XsdDouble), value, "xs:double — decimal/scientific notation, \"INF\", \"-INF\", or \"NaN\"");
        Value = parsed;
    }

    /// <summary>Always succeeds — every <see cref="double"/> is a valid xs:double value.</summary>
    public static bool TryCreate(double value, out XsdDouble result)
    {
        result = new(value);
        return true;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid xs:double.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdDouble result)
    {
        if (value is not null && TryParseWireFormat(value, out var parsed))
        {
            result = new(parsed);
            return true;
        }
        result = default;
        return false;
    }

    private static bool TryParseWireFormat(string text, out double result)
    {
        switch (text)
        {
            case "INF":
                result = double.PositiveInfinity;
                return true;
            case "-INF":
                result = double.NegativeInfinity;
                return true;
            case "NaN":
                result = double.NaN;
                return true;
            default:
                return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out result);
        }
    }

    /// <summary>Implicitly wraps a <see cref="double"/> as a <see cref="XsdDouble"/>.</summary>
    public static implicit operator XsdDouble(double value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="double"/> value.</summary>
    public static implicit operator double(XsdDouble v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdDouble"/>.</summary>
    public static implicit operator XsdDouble(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdDouble v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() =>
        double.IsPositiveInfinity(Value) ? "INF"
        : double.IsNegativeInfinity(Value) ? "-INF"
        : double.IsNaN(Value) ? "NaN"
        : Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdDouble other) => Value.Equals(other.Value);
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdDouble other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(XsdDouble a, XsdDouble b) => a.Value.Equals(b.Value);
    /// <inheritdoc/>
    public static bool operator !=(XsdDouble a, XsdDouble b) => !a.Value.Equals(b.Value);
    /// <inheritdoc/>
    public static bool operator ==(XsdDouble a, double b) => a.Value.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdDouble a, double b) => !a.Value.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(double a, XsdDouble b) => a.Equals(b.Value);
    /// <inheritdoc/>
    public static bool operator !=(double a, XsdDouble b) => !a.Equals(b.Value);
    /// <inheritdoc/>
    public static bool operator ==(XsdDouble a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdDouble a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdDouble b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdDouble b) => a != b.ToString();
}
