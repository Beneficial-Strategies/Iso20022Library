// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>String of characters equal to UNLIMITED.</summary>
[DataContract]
[Serializable]
[IsoId("_u-ol0EqAEeKw5sECfP82rg")]
[Description(@"String of characters equal to UNLIMITED.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Unlimited9Text>))]
public readonly struct Unlimited9Text : IIsoSimpleValue<string>, IEquatable<Unlimited9Text>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^UNLIMITED$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public Unlimited9Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(Unlimited9Text), value, Pattern);
        Value = value;
    }

    public static bool TryCreate(string? value, [NotNullWhen(true)] out Unlimited9Text result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    public static implicit operator Unlimited9Text(string value) => new(value);
    public static implicit operator string(Unlimited9Text t) => t.Value;
    public override string ToString() => Value ?? string.Empty;
    public bool Equals(Unlimited9Text other) => Value == other.Value;
    public override bool Equals(object? obj) => obj is Unlimited9Text other && Equals(other);
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    public static bool operator ==(Unlimited9Text a, Unlimited9Text b) => a.Equals(b);
    public static bool operator !=(Unlimited9Text a, Unlimited9Text b) => !a.Equals(b);
    public static bool operator ==(Unlimited9Text a, string? b) => a.Value == b;
    public static bool operator !=(Unlimited9Text a, string? b) => a.Value != b;
    public static bool operator ==(string? a, Unlimited9Text b) => a == b.Value;
    public static bool operator !=(string? a, Unlimited9Text b) => a != b.Value;
}
