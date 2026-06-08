// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>The collection of information which identifies a specific phone or FAX number as defined by telecom services. It consists of a "+" followed by the country code (from 1 to 3 characters) then a "-" and finally, any combination of numbers, "(", ")", "+" and "-" (up to 30 characters).</summary>
[DataContract]
[Serializable]
[IsoId("_YXvFB9p-Ed-ak6NoX_4Aeg_-1045927120")]
[Description(@"The collection of information which identifies a specific phone or FAX number as defined by telecom services. It consists of a ""+"" followed by the country code (from 1 to 3 characters) then a ""-"" and finally, any combination of numbers, ""("", "")"", ""+"" and ""-"" (up to 30 characters).")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<PhoneNumber>))]
public readonly struct PhoneNumber : IIsoSimpleValue<string>, IEquatable<PhoneNumber>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^\+[0-9]{1,3}-[0-9()+\-]{1,30}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public PhoneNumber(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(PhoneNumber), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out PhoneNumber result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <inheritdoc/>
    public static implicit operator PhoneNumber(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(PhoneNumber t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(PhoneNumber other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is PhoneNumber other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(PhoneNumber a, PhoneNumber b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(PhoneNumber a, PhoneNumber b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(PhoneNumber a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(PhoneNumber a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, PhoneNumber b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, PhoneNumber b) => a != b.Value;
}
