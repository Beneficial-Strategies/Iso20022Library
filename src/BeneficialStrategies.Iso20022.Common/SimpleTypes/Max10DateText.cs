// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a date expressed either in the YY-MM format, YYYY-MM format, or in the YYYY-MM-DD format.</summary>
[DataContract]
[Serializable]
[IsoId("_YiAxELY6Ee-wjpoShWc5lw")]
[Description(@"Specifies a date expressed either in the YY-MM format, YYYY-MM format, or in the YYYY-MM-DD format.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max10DateText>))]
public readonly struct Max10DateText : IIsoSimpleValue<string>, IEquatable<Max10DateText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^([0-9]{4,4}-[0-9]{2,2}-[0-9]{2,2})|([0-9]{2,2}-[0-9]{2,2})|([0-9]{4,4}-[0-9]{2,2})$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public Max10DateText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(Max10DateText), value, Pattern);
        Value = value;
    }

    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max10DateText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    public static implicit operator Max10DateText(string value) => new(value);
    public static implicit operator string(Max10DateText t) => t.Value;
    public override string ToString() => Value ?? string.Empty;
    public bool Equals(Max10DateText other) => Value == other.Value;
    public override bool Equals(object? obj) => obj is Max10DateText other && Equals(other);
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    public static bool operator ==(Max10DateText a, Max10DateText b) => a.Equals(b);
    public static bool operator !=(Max10DateText a, Max10DateText b) => !a.Equals(b);
    public static bool operator ==(Max10DateText a, string? b) => a.Value == b;
    public static bool operator !=(Max10DateText a, string? b) => a.Value != b;
    public static bool operator ==(string? a, Max10DateText b) => a == b.Value;
    public static bool operator !=(string? a, Max10DateText b) => a != b.Value;
}
