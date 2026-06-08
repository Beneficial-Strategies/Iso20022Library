// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string representing exactly 1 binary byte as 2 uppercase hexadecimal characters (e.g. <c>"1A"</c>, <c>"FF"</c>).
/// </summary>
/// <remarks>
/// The ISO 20022 spec pattern is <c>([0-9A-F][0-9A-F]){1}</c> — two uppercase hex digits, no lowercase.
/// <para>
/// Though the wire format is a 2-character hex string, this type also supports direct assignment
/// from and comparison with <see cref="byte"/> values for convenience.
/// </para>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_nQuWsZckEeme5LKU36W8xA")]
[Description(@"Specifies a character string with an exact length of 1 binary bytes (2 hexadecimal text characters).")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact1HexBinaryText>))]
public readonly struct Exact1HexBinaryText : IIsoSimpleValue<string>, IEquatable<Exact1HexBinaryText>
{
    /// <summary>ISO 20022 pattern constraint — exactly 2 uppercase hexadecimal characters.</summary>
    public const string Pattern = @"^[0-9A-F]{2}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The byte value represented by this instance (e.g. <c>"1A"</c> → <c>26</c>).</summary>
    public byte ByteValue => Convert.ToByte(Value, 16);

    // ── String-based construction ──────────────────────────────────────────────

    /// <summary>Initializes a new instance from a 2-character uppercase hex string (e.g. <c>"1A"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (not uppercase hex).
    /// </exception>
    public Exact1HexBinaryText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < 2)
            throw Iso20022FormatException.ForTooShort(typeof(Exact1HexBinaryText), value, 2);
        if (value.Length > 2)
            throw Iso20022FormatException.ForTooLong(typeof(Exact1HexBinaryText), value, 2);
        foreach (var c in value)
            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(Exact1HexBinaryText), value, "0-9 A-F (uppercase)");
        Value = value;
    }

    // ── Byte-based construction ────────────────────────────────────────────────

    /// <summary>Initializes a new instance from a byte value (e.g. <c>26</c> → <c>"1A"</c>).</summary>
    public Exact1HexBinaryText(byte value)
    {
        Value = value.ToString("X2");
    }

    // ── TryCreate ──────────────────────────────────────────────────────────────

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact1HexBinaryText result)
    {
        if (value is { Length: 2 })
        {
            foreach (var c in value)
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')))
                { result = default; return false; }
            result = new(value); return true;
        }
        result = default; return false;
    }

    /// <summary>Returns a valid instance for any <see cref="byte"/> value.</summary>
    public static bool TryCreate(byte value, out Exact1HexBinaryText result)
    {
        result = new(value);
        return true;
    }

    // ── Implicit operators ─────────────────────────────────────────────────────

    /// <summary>Implicitly wraps a hex string as a <see cref="Exact1HexBinaryText"/>.</summary>
    public static implicit operator Exact1HexBinaryText(string value) => new(value);
    /// <summary>Implicitly wraps a byte as a <see cref="Exact1HexBinaryText"/>.</summary>
    public static implicit operator Exact1HexBinaryText(byte value) => new(value);
    /// <summary>Implicitly unwraps to the 2-char hex string.</summary>
    public static implicit operator string(Exact1HexBinaryText text) => text.Value;
    /// <summary>Implicitly unwraps to the byte value.</summary>
    public static implicit operator byte(Exact1HexBinaryText text) => text.ByteValue;

    // ── Equality ───────────────────────────────────────────────────────────────

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact1HexBinaryText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact1HexBinaryText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(Exact1HexBinaryText a, Exact1HexBinaryText b) => a.Equals(b);
    public static bool operator !=(Exact1HexBinaryText a, Exact1HexBinaryText b) => !a.Equals(b);
    public static bool operator ==(Exact1HexBinaryText a, string? b) => a.Value == b;
    public static bool operator !=(Exact1HexBinaryText a, string? b) => a.Value != b;
    public static bool operator ==(string? a, Exact1HexBinaryText b) => a == b.Value;
    public static bool operator !=(string? a, Exact1HexBinaryText b) => a != b.Value;
    public static bool operator ==(Exact1HexBinaryText a, byte b) => a.ByteValue == b;
    public static bool operator !=(Exact1HexBinaryText a, byte b) => a.ByteValue != b;
    public static bool operator ==(byte a, Exact1HexBinaryText b) => a == b.ByteValue;
    public static bool operator !=(byte a, Exact1HexBinaryText b) => a != b.ByteValue;
}
