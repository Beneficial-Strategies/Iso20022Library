// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a rate source.</summary>
[DataContract]
[Serializable]
[IsoId("_n-vS8JULEeak6e8_Fc5fQg")]
[Description(@"Specifies a rate source.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RateSourceText>))]
public readonly struct RateSourceText : IIsoSimpleValue<string>, IEquatable<RateSourceText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[a-zA-Z]{3}[0-9]{1,2}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public RateSourceText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(RateSourceText), value, Pattern);
        Value = value;
    }

    public static bool TryCreate(string? value, [NotNullWhen(true)] out RateSourceText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    public static implicit operator RateSourceText(string value) => new(value);
    public static implicit operator string(RateSourceText t) => t.Value;
    public override string ToString() => Value ?? string.Empty;
    public bool Equals(RateSourceText other) => Value == other.Value;
    public override bool Equals(object? obj) => obj is RateSourceText other && Equals(other);
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    public static bool operator ==(RateSourceText a, RateSourceText b) => a.Equals(b);
    public static bool operator !=(RateSourceText a, RateSourceText b) => !a.Equals(b);
    public static bool operator ==(RateSourceText a, string? b) => a.Value == b;
    public static bool operator !=(RateSourceText a, string? b) => a.Value != b;
    public static bool operator ==(string? a, RateSourceText b) => a == b.Value;
    public static bool operator !=(string? a, RateSourceText b) => a != b.Value;
}
