// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYer4tp-Ed-ak6NoX_4Aeg_1324881819")]
[Description(@"Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<TickerIdentifier>))]
public readonly struct TickerIdentifier : IIsoSimpleValue<string>, IEquatable<TickerIdentifier>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 35;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> or
    /// <see cref="Iso20022FormatViolation.TooLong"/> when length is outside [1..35].
    /// </exception>
    public TickerIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(TickerIdentifier), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(TickerIdentifier), value, MaxLength);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out TickerIdentifier result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="TickerIdentifier"/>.</summary>
    public static implicit operator TickerIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(TickerIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(TickerIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is TickerIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(TickerIdentifier a, TickerIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(TickerIdentifier a, TickerIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(TickerIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(TickerIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, TickerIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, TickerIdentifier b) => a != b.Value;
}
