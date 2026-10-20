// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:hexBinary — arbitrary binary data encoded as hexadecimal.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:hexBinary</c>. Wire format: an even number of uppercase
/// hex digits (e.g. <c>"1A2B"</c>) — the lexical space technically permits lowercase too, but
/// this type only accepts the canonical uppercase form on input, matching this library's other
/// hex-encoded types (e.g. <see cref="Exact1HexBinaryText"/>).
/// </remarks>
/// <seealso cref="XsdBase64Binary"/>
[DataContract]
[Serializable]
[IsoId("hexBinary_ID")]
[Description(@"W3C XML Schema xs:hexBinary — arbitrary binary data encoded as an even number of uppercase hexadecimal digits.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdHexBinary>))]
public readonly struct XsdHexBinary : IIsoSimpleValue<string>, IEquatable<XsdHexBinary>
{
    /// <summary>ISO 20022 format constraint for this type: an even number of uppercase hex digits.</summary>
    public const string Pattern = @"^([0-9A-F]{2})*$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The binary data represented by this instance.</summary>
    public byte[] Bytes => Convert.FromHexString(Value);

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public XsdHexBinary(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(XsdHexBinary), value, "xs:hexBinary — an even number of uppercase hex digits (0-9, A-F)");
        Value = value;
    }

    /// <summary>Initializes from raw binary data, encoding it as uppercase hex.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="bytes"/> is null.</exception>
    public XsdHexBinary(byte[] bytes)
    {
        ArgumentNullException.ThrowIfNull(bytes);
        Value = Convert.ToHexString(bytes);
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdHexBinary result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Returns <see langword="true"/> for any non-null <paramref name="bytes"/>.</summary>
    public static bool TryCreate(byte[]? bytes, [NotNullWhen(true)] out XsdHexBinary result)
    {
        if (bytes is not null)
        { result = new(bytes); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a hex <see cref="string"/> as a <see cref="XsdHexBinary"/>.</summary>
    public static implicit operator XsdHexBinary(string value) => new(value);
    /// <summary>Implicitly unwraps to the hex <see cref="string"/> representation.</summary>
    public static implicit operator string(XsdHexBinary v) => v.Value;
    /// <summary>Implicitly wraps raw binary data as a <see cref="XsdHexBinary"/>.</summary>
    public static implicit operator XsdHexBinary(byte[] bytes) => new(bytes);
    /// <summary>Implicitly unwraps to the raw binary data.</summary>
    public static implicit operator byte[](XsdHexBinary v) => v.Bytes;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdHexBinary other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdHexBinary other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdHexBinary a, XsdHexBinary b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdHexBinary a, XsdHexBinary b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdHexBinary a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdHexBinary a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdHexBinary b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdHexBinary b) => a != b.Value;
}
