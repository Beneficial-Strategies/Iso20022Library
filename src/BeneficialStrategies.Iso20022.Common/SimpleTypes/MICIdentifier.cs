// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXvFANp-Ed-ak6NoX_4Aeg_1224758022")]
[Description(@"Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<MICIdentifier>))]
public readonly struct MICIdentifier : IIsoSimpleValue<string>, IEquatable<MICIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z0-9]{4,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public MICIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(MICIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out MICIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="MICIdentifier"/>.</summary>
    public static implicit operator MICIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(MICIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(MICIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is MICIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(MICIdentifier a, MICIdentifier b)  => a.Equals(b);
    public static bool operator !=(MICIdentifier a, MICIdentifier b)  => !a.Equals(b);
    public static bool operator ==(MICIdentifier a, string? b)  => a.Value == b;
    public static bool operator !=(MICIdentifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, MICIdentifier b)  => a == b.Value;
    public static bool operator !=(string? a, MICIdentifier b)  => a != b.Value;
}
