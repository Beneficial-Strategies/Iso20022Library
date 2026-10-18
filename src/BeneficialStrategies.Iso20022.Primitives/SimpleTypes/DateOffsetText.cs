// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a date offset in the form of an integer value of business days. Restricted to the values 0, -1 and -2.</summary>
[DataContract]
[Serializable]
[IsoId("_RuDV8JVJEeaYkf5FCqYMeA")]
[Description(@"Specifies a date offset in the form of an integer value of business days. Restricted to the values 0, -1 and -2.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<DateOffsetText>))]
public readonly struct DateOffsetText : IIsoSimpleValue<string>, IEquatable<DateOffsetText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^0|-1|-2$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public DateOffsetText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(DateOffsetText), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out DateOffsetText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <inheritdoc/>
    public static implicit operator DateOffsetText(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(DateOffsetText t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(DateOffsetText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is DateOffsetText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(DateOffsetText a, DateOffsetText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(DateOffsetText a, DateOffsetText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(DateOffsetText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(DateOffsetText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, DateOffsetText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, DateOffsetText b) => a != b.Value;
}
