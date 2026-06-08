// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Code and / or description for values that are not yet part of the related code list.</summary>
[DataContract]
[Serializable]
[IsoId("_YWPQNtp-Ed-ak6NoX_4Aeg_-2084377979")]
[Description(@"Code and / or description for values that are not yet part of the related code list.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Extended350Code>))]
public readonly struct Extended350Code : IIsoSimpleValue<string>, IEquatable<Extended350Code>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 350;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with TooShort or TooLong.</exception>
    public Extended350Code(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Extended350Code), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Extended350Code), value, MaxLength);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Extended350Code result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <inheritdoc/>
    public static implicit operator Extended350Code(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(Extended350Code t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Extended350Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Extended350Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(Extended350Code a, Extended350Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Extended350Code a, Extended350Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Extended350Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Extended350Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Extended350Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Extended350Code b) => a != b.Value;
}
