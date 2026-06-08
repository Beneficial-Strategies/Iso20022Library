// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies an alpha string between 1 and 6 characters.</summary>
[DataContract]
[Serializable]
[IsoId("_RkngMJUUEea7vKctaoIyEQ")]
[Description(@"Specifies an alpha string between 1 and 6 characters.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max6AlphaText>))]
public readonly struct Max6AlphaText : IIsoSimpleValue<string>, IEquatable<Max6AlphaText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[a-zA-Z]{1,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public Max6AlphaText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(Max6AlphaText), value, Pattern);
        Value = value;
    }

    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max6AlphaText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    public static implicit operator Max6AlphaText(string value) => new(value);
    public static implicit operator string(Max6AlphaText t) => t.Value;
    public override string ToString() => Value ?? string.Empty;
    public bool Equals(Max6AlphaText other) => Value == other.Value;
    public override bool Equals(object? obj) => obj is Max6AlphaText other && Equals(other);
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    public static bool operator ==(Max6AlphaText a, Max6AlphaText b) => a.Equals(b);
    public static bool operator !=(Max6AlphaText a, Max6AlphaText b) => !a.Equals(b);
    public static bool operator ==(Max6AlphaText a, string? b) => a.Value == b;
    public static bool operator !=(Max6AlphaText a, string? b) => a.Value != b;
    public static bool operator ==(string? a, Max6AlphaText b) => a == b.Value;
    public static bool operator !=(string? a, Max6AlphaText b) => a != b.Value;
}
