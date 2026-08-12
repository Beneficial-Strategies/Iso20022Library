// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:float — an IEEE single-precision 32-bit floating-point number.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:float</c>.
/// Wire format: decimal or scientific notation (e.g. <c>"42.5"</c>, <c>"1.2E3"</c>), or one of
/// the special lexical values <c>"INF"</c>, <c>"-INF"</c>, <c>"NaN"</c> — NOT the .NET
/// <see cref="float.ToString()"/> output of <c>"Infinity"</c>/<c>"-Infinity"</c>/<c>"NaN"</c>.
/// Programmatic access via <see cref="Value"/> returns the native <see cref="float"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("float_ID")]
[Description(@"W3C XML Schema xs:float — an IEEE single-precision 32-bit floating-point number.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdFloat, float>))]
public readonly struct XsdFloat : IIsoSimpleValue<float>, IEquatable<XsdFloat>
{
    /// <inheritdoc/>
    public float Value { get; }

    /// <summary>Initializes from the native <see cref="float"/> value.</summary>
    /// <remarks>Every <see cref="float"/> bit pattern, including <see cref="float.PositiveInfinity"/>,
    /// <see cref="float.NegativeInfinity"/>, and <see cref="float.NaN"/>, is a valid xs:float value.</remarks>
    public XsdFloat(float value)
    {
        Value = value;
    }

    /// <summary>
    /// Initializes by parsing the W3C XSD xs:float lexical space: decimal/scientific notation,
    /// or the special values <c>"INF"</c>, <c>"-INF"</c>, <c>"NaN"</c>.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid xs:float.</exception>
    public XsdFloat(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!TryParseWireFormat(value, out var parsed))
            throw new Iso20022FormatException(typeof(XsdFloat), value, "xs:float — decimal/scientific notation, \"INF\", \"-INF\", or \"NaN\"");
        Value = parsed;
    }

    /// <summary>Always succeeds — every <see cref="float"/> is a valid xs:float value.</summary>
    public static bool TryCreate(float value, out XsdFloat result)
    {
        result = new(value);
        return true;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid xs:float.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdFloat result)
    {
        if (value is not null && TryParseWireFormat(value, out var parsed))
        {
            result = new(parsed);
            return true;
        }
        result = default;
        return false;
    }

    private static bool TryParseWireFormat(string text, out float result)
    {
        switch (text)
        {
            case "INF":
                result = float.PositiveInfinity;
                return true;
            case "-INF":
                result = float.NegativeInfinity;
                return true;
            case "NaN":
                result = float.NaN;
                return true;
            default:
                return float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out result);
        }
    }

    /// <summary>Implicitly wraps a <see cref="float"/> as a <see cref="XsdFloat"/>.</summary>
    public static implicit operator XsdFloat(float value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="float"/> value.</summary>
    public static implicit operator float(XsdFloat v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdFloat"/>.</summary>
    public static implicit operator XsdFloat(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdFloat v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() =>
        float.IsPositiveInfinity(Value) ? "INF"
        : float.IsNegativeInfinity(Value) ? "-INF"
        : float.IsNaN(Value) ? "NaN"
        : Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdFloat other) => Value.Equals(other.Value);
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdFloat other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(XsdFloat a, XsdFloat b) => a.Value.Equals(b.Value);
    /// <inheritdoc/>
    public static bool operator !=(XsdFloat a, XsdFloat b) => !a.Value.Equals(b.Value);
    /// <inheritdoc/>
    public static bool operator ==(XsdFloat a, float b) => a.Value.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdFloat a, float b) => !a.Value.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(float a, XsdFloat b) => a.Equals(b.Value);
    /// <inheritdoc/>
    public static bool operator !=(float a, XsdFloat b) => !a.Equals(b.Value);
    /// <inheritdoc/>
    public static bool operator ==(XsdFloat a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdFloat a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdFloat b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdFloat b) => a != b.ToString();
}
