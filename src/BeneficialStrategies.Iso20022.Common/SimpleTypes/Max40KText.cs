// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with a maximum length of 40 000 characters.</summary>
[DataContract]
[Serializable]
[IsoId("_YnWrADHQEeyTT91yHXSlSQ")]
[Description(@"Specifies a character string with a maximum length of 40 000 characters.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max40KText>))]
public readonly struct Max40KText : IIsoSimpleValue<string>, IEquatable<Max40KText>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 40000;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with TooShort or TooLong.</exception>
    public Max40KText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Max40KText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Max40KText), value, MaxLength);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max40KText result)
    {
        if (value is { Length: >= MinLength and <= MaxLength }) { result = new(value); return true; }
        result = default; return false;
    }

    /// <inheritdoc/>
    public static implicit operator Max40KText(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(Max40KText t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max40KText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max40KText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(Max40KText a, Max40KText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max40KText a, Max40KText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max40KText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max40KText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max40KText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max40KText b) => a != b.Value;
}
