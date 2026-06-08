// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:int — signed 32-bit integer (-2 147 483 648 to 2 147 483 647).
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:int</c>.
/// Wire format: decimal integer string (e.g. <c>"42"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <see cref="int"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("int_ID")]
[Description(@"W3C XML Schema xs:int — signed 32-bit integer (-2 147 483 648 to 2 147 483 647).")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdInt, int>))]
public readonly struct XsdInt : IIsoSimpleValue<int>, IEquatable<XsdInt>
{
    /// <inheritdoc/>
    public int Value { get; }

    /// <summary>Initializes from the native <see cref="int"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside the allowed range.</exception>
    public XsdInt(int value)
    {
        Value = value;
    }

    /// <summary>Initializes by parsing the W3C XSD decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid int.</exception>
    public XsdInt(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(XsdInt), value, "xs:int — int decimal integer");
        this = new(parsed); // delegate to native ctor for range check
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(int value, [NotNullWhen(true)] out XsdInt result)
    {
        try { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid int.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdInt result)
    {
        if (value is not null && int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            try { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a <see cref="int"/> as a <see cref="XsdInt"/>.</summary>
    public static implicit operator XsdInt(int value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="int"/> value.</summary>
    public static implicit operator int(XsdInt v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdInt"/>.</summary>
    public static implicit operator XsdInt(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdInt v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdInt other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdInt other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(XsdInt a, XsdInt b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(XsdInt a, XsdInt b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdInt a, int b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdInt a, int b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(int a, XsdInt b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(int a, XsdInt b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdInt a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdInt a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdInt b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdInt b) => a != b.ToString();
}
