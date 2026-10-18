// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Binary data of 10K maximum.
/// </summary>
/// <remarks>
/// Wire format is base64, matching <see cref="XsdBase64Binary"/> and the serializer's generic
/// byte[] leaf handling — <see cref="ToString"/> renders the same base64 text the serializer
/// writes to the wire.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YWZBOtp-Ed-ak6NoX_4Aeg_1011241677")]
[Description(@"Binary data of 10K maximum.")]
[JsonConverter(typeof(Iso20022BinaryValueJsonConverter<Max10KBinary>))]
public readonly struct Max10KBinary : IIsoSimpleValue<byte[]>, IEquatable<Max10KBinary>
{
    /// <summary>ISO 20022 minimum length constraint, in bytes.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint, in bytes.</summary>
    public const int MaxLength = 10240;

    /// <inheritdoc/>
    public byte[] Value { get; }

    /// <summary>Initializes a new instance from raw binary data.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> when the value is shorter than
    /// <see cref="MinLength"/> bytes, or <see cref="Iso20022FormatViolation.TooLong"/> when it
    /// exceeds <see cref="MaxLength"/> bytes.
    /// </exception>
    public Max10KBinary(byte[] value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Max10KBinary), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Max10KBinary), value, MaxLength);
        Value = value;
    }

    /// <summary>Initializes a new instance by decoding a base64 wire string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown when <paramref name="value"/> is not valid base64, or the decoded length fails the
    /// same length constraints as the <see cref="byte"/>[] constructor.
    /// </exception>
    public Max10KBinary(string value) : this(DecodeBase64(value)) { }

    private static byte[] DecodeBase64(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        try
        {
            return Convert.FromBase64String(value);
        }
        catch (FormatException ex)
        {
            throw new Iso20022FormatException(typeof(Max10KBinary), value, "a valid base64-encoded string", ex);
        }
    }

    /// <summary>
    /// Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies
    /// the length constraints; otherwise <see langword="false"/>.
    /// </summary>
    public static bool TryCreate(byte[]? value, [NotNullWhen(true)] out Max10KBinary result)
    {
        if (value is { } v && v.Length >= MinLength && v.Length <= MaxLength)
        {
            result = new(v);
            return true;
        }
        result = default;
        return false;
    }

    /// <summary>
    /// Returns <see langword="true"/> and a valid instance when <paramref name="value"/> is valid
    /// base64 and its decoded length satisfies the length constraints; otherwise <see langword="false"/>.
    /// </summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max10KBinary result)
    {
        if (value is not null)
        {
            try
            {
                return TryCreate(Convert.FromBase64String(value), out result);
            }
            catch (FormatException) { }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps raw binary data as a <see cref="Max10KBinary"/>.</summary>
    public static implicit operator Max10KBinary(byte[] value) => new(value);
    /// <summary>Implicitly unwraps to the raw binary data.</summary>
    public static implicit operator byte[](Max10KBinary v) => v.Value;
    /// <summary>Implicitly wraps a base64 wire string as a <see cref="Max10KBinary"/>.</summary>
    public static implicit operator Max10KBinary(string value) => new(value);
    /// <summary>Implicitly unwraps to the base64 wire string representation.</summary>
    public static implicit operator string(Max10KBinary v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value is null ? string.Empty : Convert.ToBase64String(Value);
    /// <inheritdoc/>
    public bool Equals(Max10KBinary other) =>
        Value is null ? other.Value is null
        : other.Value is not null && Value.AsSpan().SequenceEqual(other.Value);
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max10KBinary other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => ToString().GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(Max10KBinary a, Max10KBinary b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max10KBinary a, Max10KBinary b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max10KBinary a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(Max10KBinary a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max10KBinary b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max10KBinary b) => a != b.ToString();
}
