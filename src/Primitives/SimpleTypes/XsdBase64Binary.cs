// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:base64Binary — arbitrary binary data encoded as base64.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:base64Binary</c>. This is the first
/// <see cref="IIsoSimpleValue{T}"/> type in this library with <c>T = byte[]</c> — the
/// serializer's generic leaf handling already treats <see cref="byte"/>[] as base64-encoded on
/// both the XML and JSON layers, matching this type's wire format exactly, so no special-casing
/// is required (contrast <see cref="XsdHexBinary"/>, whose different wire encoding is handled by
/// wrapping <see cref="string"/> instead).
/// </remarks>
/// <seealso cref="XsdHexBinary"/>
[DataContract]
[Serializable]
[IsoId("base64Binary_ID")]
[Description(@"W3C XML Schema xs:base64Binary — arbitrary binary data encoded as base64.")]
[JsonConverter(typeof(Iso20022BinaryValueJsonConverter<XsdBase64Binary>))]
public readonly struct XsdBase64Binary : IIsoSimpleValue<byte[]>, IEquatable<XsdBase64Binary>
{
    /// <inheritdoc/>
    public byte[] Value { get; }

    /// <summary>Initializes from raw binary data.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    public XsdBase64Binary(byte[] value)
    {
        ArgumentNullException.ThrowIfNull(value);
        Value = value;
    }

    /// <summary>Initializes by decoding a base64 string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> is not valid base64.</exception>
    public XsdBase64Binary(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        try
        {
            Value = Convert.FromBase64String(value);
        }
        catch (FormatException ex)
        {
            throw new Iso20022FormatException(typeof(XsdBase64Binary), value, "xs:base64Binary — a valid base64-encoded string", ex);
        }
    }

    /// <summary>Returns <see langword="true"/> for any non-null <paramref name="value"/>.</summary>
    public static bool TryCreate(byte[]? value, [NotNullWhen(true)] out XsdBase64Binary result)
    {
        if (value is not null)
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is valid base64.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdBase64Binary result)
    {
        if (value is not null)
        {
            try
            { result = new(value); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps raw binary data as a <see cref="XsdBase64Binary"/>.</summary>
    public static implicit operator XsdBase64Binary(byte[] value) => new(value);
    /// <summary>Implicitly unwraps to the raw binary data.</summary>
    public static implicit operator byte[](XsdBase64Binary v) => v.Value;
    /// <summary>Implicitly wraps a base64 wire string as a <see cref="XsdBase64Binary"/>.</summary>
    public static implicit operator XsdBase64Binary(string value) => new(value);
    /// <summary>Implicitly unwraps to the base64 wire string representation.</summary>
    public static implicit operator string(XsdBase64Binary v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value is null ? string.Empty : Convert.ToBase64String(Value);
    /// <inheritdoc/>
    public bool Equals(XsdBase64Binary other) =>
        Value is null ? other.Value is null
        : other.Value is not null && Value.AsSpan().SequenceEqual(other.Value);
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdBase64Binary other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => ToString().GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(XsdBase64Binary a, XsdBase64Binary b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdBase64Binary a, XsdBase64Binary b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdBase64Binary a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdBase64Binary a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdBase64Binary b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdBase64Binary b) => a != b.ToString();
}
