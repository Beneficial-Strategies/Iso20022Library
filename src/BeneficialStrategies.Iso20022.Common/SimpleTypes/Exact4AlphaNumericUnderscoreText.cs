// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies an alphanumeric string with a length of 4 characters, which may contain underscores.
/// The string must not start with an underscore.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__lmUsLGREeuSTr8k0UEM8A")]
[Description(@"Specifies an alphanumeric string with a length of 4 characters, which may contain underscores. The string must not start with a underscore.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact4AlphaNumericUnderscoreText>))]
public readonly struct Exact4AlphaNumericUnderscoreText : IIsoSimpleValue<string>, IEquatable<Exact4AlphaNumericUnderscoreText>
{
    /// <summary>ISO 20022 exact length — 4 chars; first must be alphanumeric, remainder may include underscore.</summary>
    public const int MinLength = 4;
    /// <summary>ISO 20022 exact length — 4 chars; first must be alphanumeric, remainder may include underscore.</summary>
    public const int MaxLength = 4;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown when the value is not exactly 4 characters or contains invalid characters.
    /// Pattern: first character must be alphanumeric; characters 2-4 may additionally be underscore.
    /// </exception>
    public Exact4AlphaNumericUnderscoreText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Exact4AlphaNumericUnderscoreText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Exact4AlphaNumericUnderscoreText), value, MaxLength);
        var first = value[0];
        if (!((first >= 'a' && first <= 'z') || (first >= 'A' && first <= 'Z') || (first >= '0' && first <= '9')))
            throw Iso20022FormatException.ForInvalidCharacter(typeof(Exact4AlphaNumericUnderscoreText), value,
                "first char: a-z A-Z 0-9; chars 2-4: a-z A-Z 0-9 _");
        for (int i = 1; i < value.Length; i++)
        {
            var c = value[i];
            if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') || c == '_'))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(Exact4AlphaNumericUnderscoreText), value,
                    "first char: a-z A-Z 0-9; chars 2-4: a-z A-Z 0-9 _");
        }
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact4AlphaNumericUnderscoreText result)
    {
        if (value is { Length: 4 })
        {
            var first = value[0];
            if ((first >= 'a' && first <= 'z') || (first >= 'A' && first <= 'Z') || (first >= '0' && first <= '9'))
            {
                bool valid = true;
                for (int i = 1; i < value.Length; i++)
                {
                    var c = value[i];
                    if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') || c == '_'))
                    { valid = false; break; }
                }
                if (valid) { result = new(value); return true; }
            }
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Exact4AlphaNumericUnderscoreText"/>.</summary>
    public static implicit operator Exact4AlphaNumericUnderscoreText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Exact4AlphaNumericUnderscoreText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact4AlphaNumericUnderscoreText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact4AlphaNumericUnderscoreText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Exact4AlphaNumericUnderscoreText a, Exact4AlphaNumericUnderscoreText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Exact4AlphaNumericUnderscoreText a, Exact4AlphaNumericUnderscoreText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Exact4AlphaNumericUnderscoreText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Exact4AlphaNumericUnderscoreText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Exact4AlphaNumericUnderscoreText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Exact4AlphaNumericUnderscoreText b) => a != b.Value;
}
