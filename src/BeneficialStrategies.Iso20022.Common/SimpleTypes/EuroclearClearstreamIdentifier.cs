// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Identifier of securities issued in Luxembourg. The common code is a 9-digit code that replaces the CEDEL (Clearstream) and Euroclear codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYLJ59p-Ed-ak6NoX_4Aeg_1324881759")]
[Description(@"Identifier of securities issued in Luxembourg. The common code is a 9-digit code that replaces the CEDEL (Clearstream) and Euroclear codes.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<EuroclearClearstreamIdentifier>))]
public readonly struct EuroclearClearstreamIdentifier : IIsoSimpleValue<string>, IEquatable<EuroclearClearstreamIdentifier>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 12;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> or
    /// <see cref="Iso20022FormatViolation.TooLong"/> when length is outside [1..12].
    /// </exception>
    public EuroclearClearstreamIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(EuroclearClearstreamIdentifier), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(EuroclearClearstreamIdentifier), value, MaxLength);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out EuroclearClearstreamIdentifier result)
    {
        if (value is { Length: >= MinLength and <= MaxLength }) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="EuroclearClearstreamIdentifier"/>.</summary>
    public static implicit operator EuroclearClearstreamIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(EuroclearClearstreamIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(EuroclearClearstreamIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is EuroclearClearstreamIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(EuroclearClearstreamIdentifier a, EuroclearClearstreamIdentifier b) => a.Equals(b);
    public static bool operator !=(EuroclearClearstreamIdentifier a, EuroclearClearstreamIdentifier b) => !a.Equals(b);
    public static bool operator ==(EuroclearClearstreamIdentifier a, string? b) => a.Value == b;
    public static bool operator !=(EuroclearClearstreamIdentifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, EuroclearClearstreamIdentifier b) => a == b.Value;
    public static bool operator !=(string? a, EuroclearClearstreamIdentifier b) => a != b.Value;
}
